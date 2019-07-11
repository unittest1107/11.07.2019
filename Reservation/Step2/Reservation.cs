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
            // TODO:
            // check if negative tables or hours
            // throw argument exception

            return tables / (float)hours;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }

    
}
