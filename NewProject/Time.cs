using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewProject
{
    struct Time
    {
        private int maxHour { get => 24; }
        public int TotalTimeInMinutes { get; set; }
        public int NumberOfMinutes { get; set; }
        public int NumberOfHours { get; set; }
        public int Noon { get => 720; }



        public Time(int value)
        {
            this.TotalTimeInMinutes = value;
            // ete jamy 24ic mec e vercvume mnacordy
            int temp = (int)Math.Floor((double)value / 60);
            if (temp >= 24)
            {
                Console.WriteLine("Hour is Bigger than 24.");
                this.NumberOfHours = temp % 24;
            }
            else
            {
                this.NumberOfHours = (int)Math.Floor((double)value / 60);
            }

            this.NumberOfMinutes = value % 60;
        }
        public Time(DateTime time)
        {
            this.TotalTimeInMinutes = (time.Hour) * 60 + time.Minute;
            this.NumberOfHours = time.Hour;
            this.NumberOfMinutes = time.Minute;
        }

        // operator overload
        public static Time operator +(Time timeOne, Time timeTwo)
        {
            return new Time(timeOne.TotalTimeInMinutes + timeTwo.TotalTimeInMinutes);
        }
        public static Time operator -(Time timeOne, Time timeTwo)
        {
            return new Time(timeOne.TotalTimeInMinutes - timeTwo.TotalTimeInMinutes);
        }

        //implicit explicit cast
        static public implicit operator Time(int value)
        {
            return new Time(value);
        }
        static public explicit operator int(Time value)
        {
            return value.TotalTimeInMinutes;
        }

        public override string ToString()
        {
            return $"{this.NumberOfHours}:{this.NumberOfMinutes}";
        }

    }
}
