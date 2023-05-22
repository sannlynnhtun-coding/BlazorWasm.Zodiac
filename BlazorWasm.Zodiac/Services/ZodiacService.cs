using BlazorWasm.Zodiac.Models;

namespace BlazorWasm.Zodiac.Services
{
    public class ZodiacService
    {
        public static EnumChineseZodiac GetChineseZodiac(int birthYear)
        {
            int startYear = 1900; // Start year of the Chinese zodiac cycle
            int offset = (birthYear - startYear) % 12; // Calculate the offset from the start year

            // Determine the Chinese zodiac sign based on the offset
            EnumChineseZodiac zodiacSign = (EnumChineseZodiac)offset;
            return zodiacSign;
        }

        public static EnumZodiacSign GetHoroscope(DateTime birthDate)
        {
            int day = birthDate.Day;
            int month = birthDate.Month;

            // Determine the Zodiac sign based on the birth date
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return EnumZodiacSign.Aries;
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return EnumZodiacSign.Taurus;
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return EnumZodiacSign.Gemini;
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return EnumZodiacSign.Cancer;
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return EnumZodiacSign.Leo;
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return EnumZodiacSign.Virgo;
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return EnumZodiacSign.Libra;
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return EnumZodiacSign.Scorpio;
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return EnumZodiacSign.Sagittarius;
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return EnumZodiacSign.Capricorn;
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return EnumZodiacSign.Aquarius;
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return EnumZodiacSign.Pisces;
            else
                throw new ArgumentException("Invalid birth date.");
        }
    }
}
