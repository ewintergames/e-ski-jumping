using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenSkiJumping.Competition;

namespace OpenSkiJumping.Jumping
{
    [Serializable]
    public class CompetitorSkill
    {
        public float inrun;
        public float takeOff;
        public float flight;
        public float landing;
        public float style;
    }
    
    [Serializable]
    public class Competitor
    {
        public string id = "";
        public string lastName = "";
        public string firstName = "";
        public string countryCode = "";

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender gender;

        public CompetitorSkill skill;
        public DateTime birthdate = new DateTime(1999, 8, 22);
        public string imagePath = "";
        public string helmetColor = "000000";
        public string suitTopFrontColor = "000000";
        public string suitTopBackColor = "000000";
        public string suitBottomFrontColor = "000000";
        public string suitBottomBackColor = "000000";
        public string skisColor = "000000";
        public string skinColor = "ECB494";
    }
}