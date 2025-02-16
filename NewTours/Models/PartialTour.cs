using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTours.Models
{
    public partial class Tour
    {
        public string Actual
        {
            get
            {
                string s;
                if (IsActual == 1)
                {
                    return s = "Актуален";
                }
                else
                {
                    return s = "Не актуален";
                }
            }
        }

        public string StringPrice
        {
            get
            {
                string s;
                return s = Convert.ToString(Price) + " РУБ";
            }
        }
    }
}
