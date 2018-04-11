using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;
using HotelGuestbook.Helpers;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Reflection;

namespace HotelGuestbook.Tests
{
    public class DataInitializer : DropCreateDatabaseAlways<GuestBook>
    {
        private const string SAMPLE_APARTMENTS_RELATIVE_PATH = @"../../../SampleData/SampleApartments.csv";
        private const string SAMPLE_PERSONS_RELATIVE_PATH = @"../../../SampleData/SamplePersons.csv";
        private const string SAMPLE_RESERVATIONS_RELATIVE_PATH = @"../../../SampleData/SampleReservations.csv";

        private readonly string sampleApartmentsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SAMPLE_APARTMENTS_RELATIVE_PATH);
        private readonly string samplePersonsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SAMPLE_PERSONS_RELATIVE_PATH);
        private readonly string sampleReservationsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SAMPLE_RESERVATIONS_RELATIVE_PATH);

        protected static List<ApartmentInfo> Apartments = new List<ApartmentInfo>();
        protected static List<PersonInfo> Persons = new List<PersonInfo>();
        protected static List<ReservationInfo> Reservations = new List<ReservationInfo>();


        /// <summary>
        /// Generates test data and optionally base on <paramref name="saveToDB"/>, saves them to database defined by <paramref name="context"/>.
        /// </summary>
        /// <param name="context">Context of test database.</param>
        /// <param name="saveToDB">If true, the generated data is saved to the database based on <paramref name="context"/>.</param>
        protected void GenerateTestData(GuestBook context = null, bool saveToDB = false)
        {
            GenerateData<ApartmentInfo>(sampleApartmentsLocation);
            GenerateData<PersonInfo>(samplePersonsLocation);
            GenerateData<ReservationInfo>(sampleReservationsLocation);

            if (saveToDB)
            {
                Seed(context);
            }
        }

        private void GenerateData<T>(string sample)
            where T : class, new()
        {
            using (var reader = new StreamReader(sample))
            {
                var header = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var currentLine = reader.ReadLine();

                    switch (typeof(T).Name)
                    {
                        case nameof(ApartmentInfo):
                        {
                            GenerateApartment(currentLine);
                            break;
                        }
                        case nameof(PersonInfo):
                        {
                            GeneratePerson(currentLine);
                            break;
                        }
                        case nameof(ReservationInfo):
                        {
                            GenerateReservation(currentLine);
                            break;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Saves the generated data to the database.
        /// </summary>
        /// <param name="context">Database context.</param>
        protected override void Seed(GuestBook context)
        {
            Apartments.ForEach(apartment => context.Apartments.Add(apartment));
            Persons.ForEach(person => context.Persons.Add(person));
            Reservations.ForEach(reservation => context.Reservations.Add(reservation));

            context.SaveChanges();
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SAMPLE_APARTMENTS_RELATIVE_PATH"/>.
        /// </summary>
        /// <param name="context">DB context.</param>
        private void GenerateApartment(string currentLine)
        {
            var segments = currentLine.Split(';');

            if (segments.Length != 2)
            {
                throw new InvalidDataException(nameof(segments));
            }

            var apartment = new ApartmentInfo(Int32.Parse(segments[0]), Int32.Parse(segments[1]));

            Apartments.Add(apartment);
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SAMPLE_PERSONS_RELATIVE_PATH"/>.
        /// </summary>
        /// <param name="context">DB context.</param>
        private void GeneratePerson(string currentLine)
        {
            var segments = currentLine.Split(';');

            if (segments.Length != 4)
            {
                throw new InvalidDataException(nameof(segments));
            }

            var dateOfBirth = ConversionHelper.ConvertStringToDateTime(segments[3]);
            var person = new PersonInfo(segments[0], segments[1], segments[2], dateOfBirth);

            Persons.Add(person);
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SAMPLE_RESERVATIONS_RELATIVE_PATH"/>.
        /// </summary>
        /// <param name="context">DB context.</param>
        private void GenerateReservation(string currentLine)
        {
            var segments = currentLine.Split(';');

            if (segments.Length != 4)
            {
                throw new InvalidDataException(nameof(segments));
            }

            var personId = Convert.ToInt32(segments[0]);
            var apartmentId = Convert.ToInt32(segments[1]);
            var from = ConversionHelper.ConvertStringToDateTime(segments[2]);
            var to = ConversionHelper.ConvertStringToDateTime(segments[3]);

            var reservation = new ReservationInfo(personId, apartmentId, from, to);

            Reservations.Add(reservation);
        }
    }
}
