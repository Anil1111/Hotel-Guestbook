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
    public class DataInitializer : DropCreateDatabaseIfModelChanges<GuestBook>
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
            using (TextFieldParser parser = new TextFieldParser(sample))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                parser.TrimWhiteSpace = true;

                var header = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    var currentLine = parser.ReadFields();

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
        private void GenerateApartment(string[] currentLine)
        {
            var apartment = new ApartmentInfo(Int32.Parse(currentLine[0]), Int32.Parse(currentLine[1]));

            Apartments.Add(apartment);
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SAMPLE_PERSONS_RELATIVE_PATH"/>.
        /// </summary>
        /// <param name="context">DB context.</param>
        private void GeneratePerson(string[] currentLine)
        {
            var dateOfBirth = ConversionHelper.ConvertStringToDateTime(currentLine[3]);
            var person = new PersonInfo(currentLine[0], currentLine[1], currentLine[2], dateOfBirth);

            Persons.Add(person);
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SAMPLE_RESERVATIONS_RELATIVE_PATH"/>.
        /// </summary>
        /// <param name="context">DB context.</param>
        private void GenerateReservation(string[] currentLine)
        {

            var personId = Convert.ToInt32(currentLine[0]);
            var apartmentId = Convert.ToInt32(currentLine[1]);
            var from = ConversionHelper.ConvertStringToDateTime(currentLine[2]);
            var to = ConversionHelper.ConvertStringToDateTime(currentLine[3]);

            var reservation = new ReservationInfo(personId, apartmentId, from, to);

            Reservations.Add(reservation);
        }
    }
}
