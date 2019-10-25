using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CustomException : Exception
    {
        public int type { get; }
        public string message { get; }
        public const int REGISTER_EXISTS = 1;
        public const int REGISTER_NOTEXISTS = 2;
        public const int USER_HAVE_LOAN = 3;

        public CustomException(string message,int type)
        {
            this.message = message;
            this.type = type;
        }

        public static void RegisterExistThrow(int registro)
        {
            throw new CustomException("Error : El registro " + registro + " ya existe", CustomException.REGISTER_EXISTS);
        }

        public static void RegisterNotExistThrow(int registro)
        {
            throw new CustomException("Error : El registro " + registro + " no existe", CustomException.REGISTER_NOTEXISTS);
        }

        public static void UserHaveLoanThrow(int registro)
        {
            throw new CustomException("Error : El registro " + registro + " tiene un prestamo pendiente", CustomException.USER_HAVE_LOAN);
        }
    }
}
