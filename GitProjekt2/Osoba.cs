﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public string Vek()
        {
            DateTime dnes = DateTime.Now;
            return (dnes - DatumNarozeni).ToString();
        }
    }
}