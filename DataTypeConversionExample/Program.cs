using System;

namespace DataTypeConversionExample
{
    class Program
    {
        public struct ImperialMeasurement
        {
            public float feet;

            public ImperialMeasurement(float r)
            {
                this.feet = r;
            }

            public static implicit operator ImperialMeasurement(int m) // change 'implicit' keyword to 'explicit' keyword to force 'explicit' conversion operation
            {
                float conversionResult = 3.28f * m;

                ImperialMeasurement temp = new ImperialMeasurement(conversionResult);

                return temp;

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number measurement in meters");

            int mm = Convert.ToInt32(Console.ReadLine());

            ImperialMeasurement im = mm; //(ImperialMeasurement)mm; - Explicit Conversion - And you must change ImperialMeasurement class user defined conversion operation method keyword from 'implicit' to 'explicit'
             
            Console.WriteLine($"The measurement of {mm} in meters is {im.feet} in feet.");

            Console.ReadKey();


        }
    }
}
