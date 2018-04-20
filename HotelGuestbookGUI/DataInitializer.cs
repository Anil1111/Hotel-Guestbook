using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;
using HotelGuestbook.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Reflection;

namespace HotelGuestbookGUI
{
    public class DataInitializer : DropCreateDatabaseAlways<GuestBook>
    {
        private const string SampleApartmentsRelativePath = @"../../../SampleData/SampleApartments.csv";
        private const string SamplePersonsRelativePath = @"../../../SampleData/SamplePersons.csv";
        private const string SampleReservationsRelativePath = @"../../../SampleData/SampleReservations.csv";

        private readonly string SampleApartmentsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SampleApartmentsRelativePath);
        private readonly string SamplePersonsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SamplePersonsRelativePath);
        private readonly string SampleReservationsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SampleReservationsRelativePath);

        protected static List<ApartmentInfo> Apartments = new List<ApartmentInfo>();
        protected static List<PersonInfo> Persons = new List<PersonInfo>();
        protected static List<ReservationInfo> Reservations = new List<ReservationInfo>();


        /// <summary>
        /// Generates test data and optionally base on <paramref name="saveToDb"/>, saves them to database defined by <paramref name="context"/>.
        /// </summary>
        /// <param name="context">Context of test database.</param>
        /// <param name="saveToDb">If true, the generated data is saved to the database based on <paramref name="context"/>.</param>
        public void GenerateTestData(GuestBook context = null, bool saveToDb = false)
        {
            GenerateData<ApartmentInfo>(SampleApartmentsLocation);
            GenerateData<PersonInfo>(SamplePersonsLocation);
            GenerateData<ReservationInfo>(SampleReservationsLocation);

            if (saveToDb)
            {
                Seed(context);
            }
        }


        /// <summary>
        /// Generates sample data.
        /// </summary>
        /// <typeparam name="T">Type of generated data.</typeparam>
        /// <param name="sample">Sample file name.</param>
        private void GenerateData<T>(string sample)
            where T : class
        {
            using (var reader = new StreamReader(sample))
            {
                reader.ReadLine();

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
        /// Saves apartments to DB from <see cref="SampleApartmentsRelativePath"/>.
        /// </summary>
        /// <param name="currentLine">Current line being read.</param>
        private void GenerateApartment(string currentLine)
        {
            var segments = currentLine.Split(';');

            if (segments.Length != 4)
            {
                throw new InvalidDataException(nameof(segments));
            }

            var apartment = new ApartmentInfo(int.Parse(segments[0]), int.Parse(segments[1]), int.Parse(segments[2]), int.Parse(segments[3]));

            Apartments.Add(apartment);
        }


        /// <summary>
        /// Saves apartments to DB from <see cref="SamplePersonsRelativePath"/>.
        /// </summary>
        /// <param name="currentLine">Current line being read.</param>
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
        /// Saves apartments to DB from <see cref="SampleReservationsRelativePath"/>.
        /// </summary>
        /// <param name="currentLine">Current line being read.</param>
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
