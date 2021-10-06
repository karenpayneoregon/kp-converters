using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleNetCoreApp1
{
    /// <summary>
    /// https://devblogs.microsoft.com/dotnet/announcing-net-6-preview-4/
    /// https://www.stevejgordon.co.uk/using-dateonly-and-timeonly-in-dotnet-6
    /// https://dotnetcoretutorials.com/2021/09/07/dateonly-and-timeonly-types-in-net-6/
    /// https://josef.codes/custom-dictionary-string-object-jsonconverter-for-system-text-json/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            var table = DataOperations.GetDataTable();

            var result = table.AsEnumerable().FirstOrDefault().ToEntity<Person>();
            Debug.WriteLine($"{result.Id} {result.FirstName} {result.LastName}");
        }

        private static void NewMethod1()
        {
            IEnumerable<int[]> chunks = Enumerable.Range(0, 10).Chunk(size: 3);
            Enumerable.Empty<int>().SingleOrDefault(-1);

            Debug.WriteLine(Enumerable.Range(1, 10).ElementAt(^2));

            List<Person> peopleList = new List<Person>
            {
                new() { Id = 1, FirstName = "Karen", LastName = "Payne", BirthDateOnly = new DateOnly(1956, 9, 24) },
                new() { Id = 2, FirstName = "Anne", LastName = "Smith", BirthDateOnly = new DateOnly(2000, 9, 24) }
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(peopleList, options);

            Debug.WriteLine("Serialized");
            Debug.WriteLine(jsonString);
            Debug.WriteLine("");

            var peep = JsonSerializer.Deserialize<List<Person>>(jsonString);

            foreach (var person in peep)
            {
                Debug.WriteLine($"{person.Id}{person.FirstName,10}{person.BirthDateOnly,12}{person.BirthDate,12}");
            }
        }


        private static void NewMethod()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            Debug.WriteLine(currentDate);
            var currentTime = TimeOnly.FromDateTime(DateTime.Now);
            TimeOnly startTime = new TimeOnly(7, 45);
            TimeOnly endTime = new TimeOnly(10, 45);
            var isBetween = currentTime.IsBetween(startTime, endTime);
            Debug.WriteLine($"Current time {(isBetween ? "is" : "is not")} between start and end");

            TimeSpan timeSpan = startTime.ToTimeSpan();
        }
    }

    public class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly BirthDateOnly { get; set; }
        [JsonIgnore]
        public DateTime BirthDate 
            => new(BirthDateOnly.Year, BirthDateOnly.Month, BirthDateOnly.Day);

    }

    public sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateOnly.FromDateTime(reader.GetDateTime());
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            var isoDate = value.ToString("O");
            writer.WriteStringValue(isoDate);
        }
    }

    public class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
    {
        private const string TimeFormat = "HH:mm:ss.FFFFFFF";

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return TimeOnly.ParseExact(reader.GetString()!, TimeFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(TimeFormat, CultureInfo.InvariantCulture));
        }
    }

}
