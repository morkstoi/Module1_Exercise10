using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree
{
    class Degrees
    {
        private int gradus;
        private int min;
        private int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value >= 0 && value <=360)
                {
                    gradus = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(gradus), "Значение градуса должно быть в диапазоне [0°;360°].");
                }
            }
        }
        public int Minutes
        {
            get
            {
                return min;
            }
            set
            {
                if(value >= 0 && value<60)
                {
                    min = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(min), "Значение градуса должно быть в диапазоне [0°;60°).");
                }

            }
        }
        public int Seconds
        {
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(sec), "Значение градуса должно быть в диапазоне [0°;60°).");
                }

            }
        }
        public Degrees (int gradus, int min, int sec)
        {
            Gradus = gradus;
            Minutes = min;
            Seconds = sec;
        }
        public double ToRadians()
        {
            double totalDegrees = gradus + (min/60)+(sec/3600);
            return totalDegrees * Math.PI / 180;
        }


    }
}
