using System;

namespace VideoMaster.Iznimke
{
    public class RegistracijaException : ApplicationException
    {
        public string Poruka { get; set; }

        public RegistracijaException(string poruka) : base(poruka)
        {
            Poruka = poruka;
        }
    }
}
