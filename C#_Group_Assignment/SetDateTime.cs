using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Group_Assignment
{
    public static class SetDateTime
    {
        private static DateTime currentDateTime = DateTime.Now.Date.AddHours(DateTime.Now.Hour);

        public static DateTime CurrentDateTime
        {
            get { return currentDateTime; }
            set { currentDateTime = value; }
        }
    }
}
