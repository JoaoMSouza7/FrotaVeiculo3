using System;

namespace FrotaPim.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string error) : base(error)
        {

        }

        public static void when(bool valid, string error)
        {
            if(!valid)
            {
                throw new DomainException(error);
            }       
        }
    }
}