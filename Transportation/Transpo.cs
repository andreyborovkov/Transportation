using System;

namespace Transportation
{
    public class Transpo
    {
        //properties
        public string GetMake { get; set; }
        public string GetModel { get; set; }
        public string GetYear { get; set; }
        public string GetNumWheel { get; set; }
        public string GetColor { get; set; }
        public string GetEngineSize { get; set; }

        //methods
        public int GetMPH(int value)
        {
            return value;
        }

        public int GetMPG(int valueOne, int valueTwo)
        {
            int mpg = valueOne * valueTwo;
            return mpg;
        }

        public string GetWear(int miles, int temp, double rogtread)
        {
            string condition = " ";
            if (temp != 0)
            {
                int calcOne = miles*4 / temp;
                double calcTwo = rogtread * 0.5;
                if (calcOne < calcTwo)
                {
                    condition = "Unsafe";
                }
                else
                {
                    condition = "Safe";
                }
            }
            else
            {
                condition = "Invalid Entry";
            }
            return condition;
        }
    }
    
}