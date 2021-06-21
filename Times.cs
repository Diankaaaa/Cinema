using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   public class Times
    {
        public int hour { get; set; }
        public int minute { get; set; }

        //Инициализация времени строкой
        public Times(string stTime)
        {
            string[] mas = stTime.Split(':');
            this.hour = int.Parse(mas[0]);
            this.minute = int.Parse(mas[1]);
        }

        //Сложение времени и заданного количества минут
        public DateTime AddingTheTimeAndTheSpecifiedNumberOfSeconds(DateTime a, double s)
        {
            DateTime res = a.AddMinutes(s);
            return res;
        }
    }
}
