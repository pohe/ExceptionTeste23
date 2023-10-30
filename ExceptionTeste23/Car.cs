using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTeste23
{
    public class Car
    {
        

		private string _model;
        private int _year;

        public string RegNo { get; set; }
        public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

        public int Year
		{
			get { return _year; }
			set { _year = value; }
		}

        public Car(string regNo, string model, int year)
        {
            if (regNo.Length != 8)
            {
                throw new ArgumentException("Registreringsnummer skal være på 8 karakterer!!");
            }
            RegNo = regNo;
            _model = model;
            _year = year;
        }




    }
}
