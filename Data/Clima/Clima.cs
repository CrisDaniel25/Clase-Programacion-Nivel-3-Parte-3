using System;
using System.Collections.Generic;

namespace Tarea_3.Data
{
    public class Loc    {
        public double lat { get; set; } 
        public double @long { get; set; } 
    }

    public class Temp    {
        public double maxC { get; set; } 
        public double minC { get; set; } 
        public double avgC { get; set; } 
        public double maxF { get; set; } 
        public double minF { get; set; } 
        public double avgF { get; set; } 
        public int maxTimestamp { get; set; } 
        public DateTime maxDateTimeISO { get; set; } 
        public int minTimestamp { get; set; } 
        public DateTime minDateTimeISO { get; set; } 
    }

    public class Feelslike    {
        public double maxC { get; set; } 
        public double minC { get; set; } 
        public double avgC { get; set; } 
        public double maxF { get; set; } 
        public double minF { get; set; } 
        public double avgF { get; set; } 
        public int maxTimestamp { get; set; } 
        public DateTime maxDateTimeISO { get; set; } 
        public int minTimestamp { get; set; } 
        public DateTime minDateTimeISO { get; set; } 
    }

    public class Humidity    {
        public double max { get; set; } 
        public double min { get; set; } 
        public double avg { get; set; } 
        public int maxTimestamp { get; set; } 
        public DateTime maxDateTimeISO { get; set; } 
        public int minTimestamp { get; set; } 
        public DateTime minDateTimeISO { get; set; } 
    }

    public class WindSpeed    {
        public double maxKTS { get; set; } 
        public double minKTS { get; set; } 
        public double avgKTS { get; set; } 
        public double maxKPH { get; set; } 
        public double minKPH { get; set; } 
        public double avgKPH { get; set; } 
        public double maxMPH { get; set; } 
        public double minMPH { get; set; } 
        public double avgMPH { get; set; } 
        public int maxTimestamp { get; set; } 
        public DateTime maxDateTimeISO { get; set; } 
        public int minTimestamp { get; set; } 
        public DateTime minDateTimeISO { get; set; } 
        public int maxDirDEG { get; set; } 
        public string maxDir { get; set; } 
        public int minDirDEG { get; set; } 
        public string minDir { get; set; } 
    }

    public class Coded    {
        public string code { get; set; } 
        public int timestamp { get; set; } 
        public DateTime dateTimeISO { get; set; } 
    }

    public class Weather    {
        public string phrase { get; set; } 
        public string primary { get; set; } 
        public string primaryCoded { get; set; } 
        public string icon { get; set; } 
        public List<Coded> coded { get; set; } 
    }

    public class Period    {
        public DateTime dateTimeISO { get; set; } 
        public Temp temp { get; set; } 
        public Feelslike feelslike { get; set; } 
        public Humidity humidity { get; set; } 
        public WindSpeed windSpeed { get; set; } 
        public Weather weather { get; set; } 
    }

    public class Response    {
        public Loc loc { get; set; } 
        public List<Period> periods { get; set; } 
    }

    public class Clima    {
        public bool success { get; set; } 
        public object error { get; set; } 
        public List<Response> response { get; set; } 
    }
}