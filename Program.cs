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
                if (numeral == 'M')
                {
                    total += 1000;
                }
                else if (numeral == 'D')
                {
                    total += 500;
                }
                else if (numeral == 'C')
                {
                    total += 100;
                }
                else if (numeral == 'L')
                {
                    total += 50;
                }
                else if (numeral == 'X')
                {
                    total += 10;
                }
                else if (numeral == 'V')
                {
                    total += 5;
                }
                else if (numeral == 'I')
                {
                    total += 1;
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
            //thousands logic
            digit = number / 1000;
            if (digit != 0)
            {
                for (int i = 0; i < digit; i++)
                {
                    RomanNumeral += "M";
                }
                number = number - digit * 1000;
            }
            //hundreds logic
            digit = number / 100;
            if (digit != 0)
            {
                if (digit >= 1 && digit <= 3)
                {
                    for (int i = 0; i < digit; i++)
                    {
                        RomanNumeral += "C";
                    }
                }

                if (digit == 4)
                {
                    RomanNumeral += "CD";
                }

                else if (digit == 5)
                {
                    RomanNumeral += "D";
                }

                else if (digit >= 6 && digit <= 8)
                {
                    RomanNumeral += "D";
                    for (int i = 0; i < digit - 5; i++)
                    {
                        RomanNumeral += "C";
                    }
                }

                else if (digit == 9)
                {
                    RomanNumeral += "CM";
                }

                number = number - digit * 100;
            }

            //tens logic
            digit = number / 10;
            if (digit != 0)
            {
                if (digit >= 1 && digit <= 3)
                {
                    for (int i = 0; i < digit; i++)
                    {
                        RomanNumeral += "X";
                    }
                }

                if (digit == 4)
                {
                    RomanNumeral += "XL";
                }

                if (digit == 5)
                {
                    RomanNumeral += "L";
                }

                if (digit >= 6 && digit <= 8)
                {
                    RomanNumeral += "L";
                    for (int i = 0; i < digit - 5; i++)
                    {
                        RomanNumeral += "X";
                    }
                }

                if (digit == 9)
                {
                    RomanNumeral += "XC";
                }

                number = number - digit * 10;
            }

            //ones logic
            if (number != 0)
            {
                if (number >= 1 && number <= 3)
                {
                    for (int i = 0; i < number; i++)
                    {
                        RomanNumeral += "I";
                    }
                }

                if (number == 4)
                {
                    RomanNumeral += "IV";
                }

                if (number == 5)
                {
                    RomanNumeral += "V";
                }

                if (number >= 6 && number <= 8)
                {
                    RomanNumeral += "V";
                    for (int i = 0; i < number - 5; i++)
                    {
                        RomanNumeral += "I";
                    }
                }

                if (number == 9)
                {
                    RomanNumeral += "IX";
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
