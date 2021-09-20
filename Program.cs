using System;

namespace Roman_Numeral_Converter
{
    class Program
    {
        public static int RomanNumeralToInt(string romanNumeral)
        {
            int total = 0;
            foreach (char numeral in romanNumeral)
            {
                switch (numeral)
                {
                    case 'M':
                        total += 1000;
                        break;

                    case 'D':
                        total += 500;
                        break;

                    case 'C':
                        total += 100;
                        break;

                    case 'L':
                        total += 50;
                        break;

                    case 'X':
                        total += 10;
                        break;

                    case 'V':
                        total += 5;
                        break;

                    case 'I':
                        total += 1;
                        break;

                }
            }

            if (romanNumeral.Contains("CD") || romanNumeral.Contains("CM"))
            {
                total -= 200;
            }
            if (romanNumeral.Contains("XL") || romanNumeral.Contains("XC"))
            {
                total -= 20;
            }
            if (romanNumeral.Contains("IV") || romanNumeral.Contains("IX"))
            {
                total -= 2;
            }

            return total;
        }

        public static string IntToRomanNumeral(int number)
        {
            string RomanNumeral = "";
            int digit = 0;
            //thousands digit logic
            digit = number / 1000;
            if (digit != 0)
            {
                for (int i = 0; i < digit; i++)
                {
                    RomanNumeral += "M";
                }
                number = number - digit * 1000;
            }
            //hundreds digit logic
            digit = number / 100;
            if (digit != 0)
            {
                switch (digit)
                {
                    case 1:
                        RomanNumeral += "C";
                        break;
                    case 2:
                        RomanNumeral += "CC";
                        break;
                    case 3:
                        RomanNumeral += "CCC";
                        break;
                    case 4:
                        RomanNumeral += "CD";
                        break;
                    case 5:
                        RomanNumeral += "D";
                        break;
                    case 6:
                        RomanNumeral += "DC";
                        break;
                    case 7:
                        RomanNumeral += "DCC";
                        break;
                    case 8:
                        RomanNumeral += "DCCC";
                        break;
                    case 9:
                        RomanNumeral += "CM";
                        break;
                }

                number = number - digit * 100;
            }

            //tens digit logic
            digit = number / 10;
            if (digit != 0)
            {
                switch (digit)
                {
                    case 1:
                        RomanNumeral += "X";
                        break;
                    case 2:
                        RomanNumeral += "XX";
                        break;
                    case 3:
                        RomanNumeral += "XXX";
                        break;
                    case 4:
                        RomanNumeral += "XL";
                        break;
                    case 5:
                        RomanNumeral += "L";
                        break;
                    case 6:
                        RomanNumeral += "LX";
                        break;
                    case 7:
                        RomanNumeral += "LXX";
                        break;
                    case 8:
                        RomanNumeral += "LXXX";
                        break;
                    case 9:
                        RomanNumeral += "XC";
                        break;
                }
                number = number - digit * 10;
            }

            //ones digit logic
            if (number != 0)
            {
                switch (number)
                {
                    case 1:
                        RomanNumeral += "I";
                        break;
                    case 2:
                        RomanNumeral += "II";
                        break;
                    case 3:
                        RomanNumeral += "III";
                        break;
                    case 4:
                        RomanNumeral += "IV";
                        break;
                    case 5:
                        RomanNumeral += "V";
                        break;
                    case 6:
                        RomanNumeral += "VI";
                        break;
                    case 7:
                        RomanNumeral += "VII";
                        break;
                    case 8:
                        RomanNumeral += "VIII";
                        break;
                    case 9:
                        RomanNumeral += "IX";
                        break;
                }

            }
            return RomanNumeral;
        }
        static void Main(string[] args)
        {
            int num4 = RomanNumeralToInt("IV");
            int num10 = RomanNumeralToInt("X");
            int num789 = RomanNumeralToInt("DCCLXXXIX");
            int num1776 = RomanNumeralToInt("MDCCLXXVI");
            int num1912 = RomanNumeralToInt("MCMXII");
            int num2021 = RomanNumeralToInt("MMXXI");

            Console.WriteLine($"\nIV converted to integer: {num4}");
            Console.WriteLine($"X converted to integer: {num10}");
            Console.WriteLine($"DCCLXXXIX converted to integer: {num789}");
            Console.WriteLine($"MDCCLXXVI converted to integer: {num1776}");
            Console.WriteLine($"MCMXII converted to integer: {num1912}");
            Console.WriteLine($"MMXXI converted to integer: {num2021}");

            string romanNumIV = IntToRomanNumeral(4);
            string romanNumX = IntToRomanNumeral(10);
            string romanNumDCCLXXXIX = IntToRomanNumeral(789);
            string romanNumMDCCLXXVI = IntToRomanNumeral(1776);
            string romanNumMCMXII = IntToRomanNumeral(1912);
            string romanNumMMXXI = IntToRomanNumeral(2021);

            Console.WriteLine($"\n4 converted to integers: {romanNumIV}");
            Console.WriteLine($"10 converted to Roman Numerals: {romanNumX}");
            Console.WriteLine($"789 converted to Roman Numerals: {romanNumDCCLXXXIX}");
            Console.WriteLine($"1776 converted to Roman Numerals: {romanNumMDCCLXXVI}");
            Console.WriteLine($"1912 converted to Roman Numerals: {romanNumMCMXII}");
            Console.WriteLine($"2021 converted to Roman Numerals: {romanNumMMXXI}");
        }
    }
}
