using System;

namespace FrotaPim.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string error) : base(error)
        {

        }

        public static void when(bool notValid, string error)
        {
            if(notValid)
            {
                throw new DomainException(error);
            }       
        }
    }
}