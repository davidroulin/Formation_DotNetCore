using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FixMe001
    {

        // What are the differences? Which is better? Which would you rename and why?

        public string HorizontalLine1 = new string('#', 10);


        public string HorizontalLine2 => new string('#', 10);


        public string HorizontalLine3 { get => new string('#', 10); }


        public string HorizontalLine4 { get { return new string('#', 10); } }



        private string _HorizontalLine4Bis;
        public string HorizontalLine4Bis
        {
            get
            {
                //_HorizontalLine4Bis = _HorizontalLine4Bis ?? new string('#', 10);
                _HorizontalLine4Bis ??= new string('#', 10);
                return _HorizontalLine4Bis;
            }
        }




        public string HorizontalLine5 { get; }
        public FixMe001()
        {
            HorizontalLine5 = new string('#', 10);
        }

    }
}
