using System;
using Day = System.DayOfWeek;

namespace lab4
{
    class Program
    {
        public static void Main(string[] st)
        {
            // example 1
            var tempRecord = new TempRecord();
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine($"element {i} : {tempRecord[i]}");
            }

            // example 2
            var week = new DayCollection();
            Console.WriteLine(week["Fri"]);
            try
            {
                Console.WriteLine(week["Made-up day"]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Not supported input: {e.Message}");
            }

            // example 3
            var week1 = new DayOfWeekCollection();
            Console.WriteLine(week1[DayOfWeek.Friday]);

            try
            {
                Console.WriteLine(week1[(DayOfWeek)43]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Not supported input: {e.Message}");
            }
        }
    }

    class DayOfWeekCollection
    {
        Day[] days =
        {
        Day.Sunday, Day.Monday, Day.Tuesday, Day.Wednesday,
        Day.Thursday, Day.Friday, Day.Saturday
    };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[Day day] => FindDayIndex(day);

        private int FindDayIndex(Day day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }
            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be a defined System.DayOfWeek value.");
        }
    }

    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[string day] => FindDayIndex(day);

        private int FindDayIndex(string day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be in the form \"Sun\", \"Mon\", etc");
        }
    }

    public class TempRecord
    {
        float[] temps = new float[10]
        {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };

        public int Length => temps.Length;

        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
}