using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanbeCancelledBy(User user)
        {
            if (user == null)
                throw new NullUserException("Null user given for CanbeCancelledBy");

            if (user.IsAdmin)
                return true;

            if (user == MadeBy)
                return true;

            return false;
        }

        public float CalcAverageTables(int tables, int hours)
        {
            if (tables < 0 || hours < 0)
                throw new ArgumentException($"Wrong input to method CalcAverageTables: "
                    + $"hours : {hours} tables : {tables}");

            return tables / hours;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }

    
}
