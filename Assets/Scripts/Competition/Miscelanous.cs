using System;
using System.Collections.Generic;

namespace OpenSkiJumping.Competition
{
    [Flags]
    public enum JumpResultState
    {
        None = 0,
        Advanced = 1,
        KoLoser = 2
    }

    [Serializable]
    public class Country
    {
        public string alpha2;
        public string en;
        public string ioc;
    }

    [Serializable]
    public class CountryData
    {
        public List<Country> countryList;
        public List<string> spritesList;
    }

    public enum HillSurface
    {
        Snow,
        Matting
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum LimitType
    {
        None,
        Normal,
        Exact
    }

    public enum RoundType
    {
        Normal,
        KO
    }

    public enum EventType
    {
        Individual,
        Team
    }

    public enum ClassificationType
    {
        Place,
        Points,
        Medal
    }

    public enum RankType
    {
        None,
        Event,
        Classification
    }
}