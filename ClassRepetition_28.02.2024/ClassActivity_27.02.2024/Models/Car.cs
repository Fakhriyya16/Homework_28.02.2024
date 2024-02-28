
using System.Globalization;

namespace ClassActivity_27._02._2024.Models
{
    internal class Car
    {
        public string name;
        public int speed;
        private string color;
        public string Color 
        {
            get
            {   
                if(speed > 400)
                {
                    return color;
                }
                return null;                
            }        
            set
            {
                color = value;
            }
                
        }
    }
}
