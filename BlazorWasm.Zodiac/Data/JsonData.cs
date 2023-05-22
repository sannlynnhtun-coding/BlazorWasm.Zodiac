using BlazorWasm.Zodiac.Models;
using Newtonsoft.Json;

namespace BlazorWasm.Zodiac.Data
{
    public class JsonData
    {
        private static string Zodiac = @"
[
    {
      ""name"": ""Aries"",
      ""dates"": ""March 21 - April 19"",
      ""element"": ""Fire"",
      ""traits"": [
        { ""name"": ""Courageous"", ""percentage"": 80 },
        { ""name"": ""Confident"", ""percentage"": 70 },
        { ""name"": ""Energetic"", ""percentage"": 90 },
        { ""name"": ""Impulsive"", ""percentage"": 60 },
        { ""name"": ""Passionate"", ""percentage"": 75 }
      ]
    },
    {
    ""name"": ""Taurus"",
      ""dates"": ""April 20 - May 20"",
      ""element"": ""Earth"",
      ""traits"": [
        { ""name"": ""Reliable"", ""percentage"": 70 },
        { ""name"": ""Patient"", ""percentage"": 80 },
        { ""name"": ""Practical"", ""percentage"": 75 },
        { ""name"": ""Stubborn"", ""percentage"": 85 },
        { ""name"": ""Sensual"", ""percentage"": 65 }
      ]
    },
    {
    ""name"": ""Gemini"",
      ""dates"": ""May 21 - June 20"",
      ""element"": ""Air"",
      ""traits"": [
        { ""name"": ""Adaptable"", ""percentage"": 75 },
        { ""name"": ""Curious"", ""percentage"": 85 },
        { ""name"": ""Intellectual"", ""percentage"": 80 },
        { ""name"": ""Inconsistent"", ""percentage"": 60 },
        { ""name"": ""Social"", ""percentage"": 90 }
      ]
    },
    {
    ""name"": ""Cancer"",
      ""dates"": ""June 21 - July 22"",
      ""element"": ""Water"",
      ""traits"": [
        { ""name"": ""Loyal"", ""percentage"": 85 },
        { ""name"": ""Emotional"", ""percentage"": 75 },
        { ""name"": ""Intuitive"", ""percentage"": 80 },
        { ""name"": ""Moody"", ""percentage"": 70 },
        { ""name"": ""Protective"", ""percentage"": 90 }
      ]
    },
    {
    ""name"": ""Leo"",
      ""dates"": ""July 23 - August 22"",
      ""element"": ""Fire"",
      ""traits"": [
        { ""name"": ""Generous"", ""percentage"": 80 },
        { ""name"": ""Creative"", ""percentage"": 85 },
        { ""name"": ""Warm-hearted"", ""percentage"": 75 },
        { ""name"": ""Arrogant"", ""percentage"": 65 },
        { ""name"": ""Dominant"", ""percentage"": 70 }
      ]
    },
    {
    ""name"": ""Virgo"",
      ""dates"": ""August 23 - September 22"",
      ""element"": ""Earth"",
      ""traits"": [
        { ""name"": ""Analytical"", ""percentage"": 90 },
        { ""name"": ""Practical"", ""percentage"": 85 },
        { ""name"": ""Modest"", ""percentage"": 70 },
        { ""name"": ""Overcritical"", ""percentage"": 80 },
        { ""name"": ""Reliable"", ""percentage"": 75 }
      ]
    },
    {
    ""name"": ""Libra"",
      ""dates"": ""September 23 - October 22"",
      ""element"": ""Air"",
      ""traits"": [
        { ""name"": ""Diplomatic"", ""percentage"": 75 },
        { ""name"": ""Harmonious"", ""percentage"": 80 },
        { ""name"": ""Idealistic"", ""percentage"": 70 },
        { ""name"": ""Indecisive"", ""percentage"": 65 },
        { ""name"": ""Charming"", ""percentage"": 85 }
      ]
    },
    {
    ""name"": ""Scorpio"",
      ""dates"": ""October 23 - November 21"",
      ""element"": ""Water"",
      ""traits"": [
        { ""name"": ""Passionate"", ""percentage"": 85 },
        { ""name"": ""Magnetic"", ""percentage"": 80 },
        { ""name"": ""Resolute"", ""percentage"": 75 },
        { ""name"": ""Jealous"", ""percentage"": 70 },
        { ""name"": ""Secretive"", ""percentage"": 60 }
      ]
    },
    {
    ""name"": ""Sagittarius"",
      ""dates"": ""November 22 - December 21"",
      ""element"": ""Fire"",
      ""traits"": [
        { ""name"": ""Adventurous"", ""percentage"": 90 },
        { ""name"": ""Optimistic"", ""percentage"": 85 },
        { ""name"": ""Straightforward"", ""percentage"": 80 },
        { ""name"": ""Impatient"", ""percentage"": 70 },
        { ""name"": ""Versatile"", ""percentage"": 75 }
      ]
    },
    {
    ""name"": ""Capricorn"",
      ""dates"": ""December 22 - January 19"",
      ""element"": ""Earth"",
      ""traits"": [
        { ""name"": ""Ambitious"", ""percentage"": 80 },
        { ""name"": ""Disciplined"", ""percentage"": 85 },
        { ""name"": ""Prudent"", ""percentage"": 75 },
        { ""name"": ""Pessimistic"", ""percentage"": 60 },
        { ""name"": ""Determined"", ""percentage"": 70 }
      ]
    },
    {
    ""name"": ""Aquarius"",
      ""dates"": ""January 20 - February 18"",
      ""element"": ""Air"",
      ""traits"": [
        { ""name"": ""Independent"", ""percentage"": 80 },
        { ""name"": ""Intellectual"", ""percentage"": 85 },
        { ""name"": ""Unconventional"", ""percentage"": 75 },
        { ""name"": ""Stubborn"", ""percentage"": 70 },
        { ""name"": ""Humanitarian"", ""percentage"": 90 }
      ]
    },
    {
    ""name"": ""Pisces"",
      ""dates"": ""February 19 - March 20"",
      ""element"": ""Water"",
      ""traits"": [
        { ""name"": ""Compassionate"", ""percentage"": 85 },
        { ""name"": ""Intuitive"", ""percentage"": 80 },
        { ""name"": ""Artistic"", ""percentage"": 75 },
        { ""name"": ""Escapist"", ""percentage"": 60 },
        { ""name"": ""Sensitive"", ""percentage"": 70 }
      ]
    }
  ]
";

        public static List<ZodiacSignModel> ZodiacSigns => 
            JsonConvert.DeserializeObject<List<ZodiacSignModel>>(Zodiac);
    }
}