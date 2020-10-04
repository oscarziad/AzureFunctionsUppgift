using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibraries.Models
{
    public class TemperatureModel
    {
        public Main main { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public int humidity { get; set; }
    }
}
