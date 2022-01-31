using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        // member variable
        private string color = "white";
        private int length;
        private int height;
        //private int width;
        private int volume;

        // auto - implemented property - enter "prop" + press double tab
        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }


        public int Volume
        {
            get
            {
                return Heigth * Width * Length;
            }

            set
            {
                volume = value;
            }

        }


        // read only
        public int Heigth
        {
            get
            {
                return height;
            }
            /*
            set
            {
                if (value < 0)
                    value = -value;
                    
                    //throw new Exception("Size should be positive");
                height = value;
            }
            */
        }


        public int Length
        {
            get => length;
            set => length = value;
        }

        /*
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        */
        /*
        public void SetLength(int length)
        {
            this.length = length;
        }
        
        public int GetLength()
        {
            return this.length;
        }
        */

        public int FrontSurface
        {
            get { return height * length; }

        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, Width, volume = Width * height * length);
        }
    }
}
