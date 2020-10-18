using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Models
{
    public class Actor
    {

        public String Fornavn { get; set; }
        public String Etternavn { get; set; }
        public int Alder { get; set; }

    public Actor(String fornavn, String etternavn, int alder)
        {
            this.Fornavn = fornavn;
            this.Etternavn = etternavn;
            this.Alder = alder;
        }


        public override string ToString()
        {
            return Fornavn + " - " + Etternavn + " - " + Alder;
        }

    }
}
