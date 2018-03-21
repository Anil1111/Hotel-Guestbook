using HotelGuestbook.Classes.Person;
using HotelGuestbook.DAL;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Data.Entity;
using System.IO;
using System.Reflection;

namespace HotelGuestbook.Tests.TestsBase
{
    public class DataInitializer : DropCreateDatabaseAlways<GuestBookContext>
    {
        private const string SAMPLE_DATA_RELATIVE_PATH = @"../../../SampleData/SamplePersons.csv";
        private string samplePersonsLocation = Path.Combine(Assembly.GetExecutingAssembly().Location, SAMPLE_DATA_RELATIVE_PATH);


        protected override void Seed(GuestBookContext context)
        {
            using (TextFieldParser parser = new TextFieldParser(samplePersonsLocation))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";", ",");
                parser.TrimWhiteSpace = true;

                var header = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    var currentLine = parser.ReadFields();

                    var dateOfBirth = currentLine[3].Split('.');
                    var person = new PersonInfo(currentLine[0], currentLine[1], currentLine[2], new DateTime(Convert.ToInt32(dateOfBirth[2]), Convert.ToInt32(dateOfBirth[1]), Convert.ToInt32(dateOfBirth[0])));

                    context.Persons.Add(person);
                }
            }

            context.SaveChanges();
        }
    }
}
