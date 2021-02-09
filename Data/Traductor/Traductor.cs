using System;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tarea_3.Data
{
     public class ResponseData    {
        public string translatedText { get; set; } 
        public double match { get; set; } 
    }

    public class Match    {
        public object id { get; set; } 
        public string segment { get; set; } 
        public string translation { get; set; } 
        public string source { get; set; } 
        public string target { get; set; } 
        public object quality { get; set; } 
        public string reference { get; set; } 
        [JsonProperty("usage-count")]
        public int UsageCount { get; set; } 
        public object subject { get; set; } 
        [JsonProperty("created-by")]
        public string CreatedBy { get; set; } 
        [JsonProperty("last-updated-by")]
        public string LastUpdatedBy { get; set; } 
        [JsonProperty("create-date")]
        public string CreateDate { get; set; } 
        [JsonProperty("last-update-date")]
        public string LastUpdateDate { get; set; } 
        public double match { get; set; } 
        public string model { get; set; } 
    }

    public class Translate    {
        public ResponseData responseData { get; set; } 
        public bool quotaFinished { get; set; } 
        public object mtLangSupported { get; set; } 
        public string responseDetails { get; set; } 
        public int responseStatus { get; set; } 
        public string responderId { get; set; } 
        public object exception_code { get; set; } 
        public List<Match> matches { get; set; } 
    }
}