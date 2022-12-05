using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BinaryCalculator
{
    internal class Calcs
    {
        //===================== CONVERSIONS =========================
        public static string ConvertBinToDec(string number)
        {
            if (ValidateInputBinary(number) == false)
            {
                throw new Exception("Please enter a valid binary number");
            }
            return Convert.ToInt32(number, 2).ToString();
        }

        public static string ConvertBinToHex(string number)
        {
            if (ValidateInputBinary(number) == false)
            {
                throw new Exception("Please enter a valid binary number");
            }
            return Convert.ToInt32(number, 2).ToString("X");
        }

        public static string ConvertDecToBin(string number)
        {
            if (ValidateInputDecimal(number) == false)
            {
                throw new Exception("Please enter a valid decimal number");
            }

            string binary = "";
            int binaryInt;

            if(int.TryParse(number, out binaryInt))
            {
                binary = Convert.ToString(binaryInt, 2);
            }
            return binary;
        }

        public static string ConvertDecToHex(string number)
        {

            if (ValidateInputDecimal(number) == false)
            {
                throw new Exception("Please enter a valid decimal number");
            }

            string hex = "";
            int decNumber;

            if (int.TryParse(number, out decNumber))
            {
                hex = decNumber.ToString("X");
            }
            return hex;
        }

        public static string ConvertHexToBin(string number)
        {
            if (ValidateInputHexadecimal(number) == false)
            {
                throw new Exception("Please enter a valid hexadecimal number");
            }
            return Convert.ToString(Convert.ToInt64(number, 16), 2);
        }

        public static string ConvertHexToDec(string number)
        {
            if (ValidateInputHexadecimal(number) == false)
            {
                throw new Exception("Please enter a valid hexadecimal number");
            }
            int decValue = int.Parse(number, System.Globalization.NumberStyles.HexNumber);
            return decValue.ToString();
        }




        //===================== VALIDATIONS =========================

        private static bool ValidateInputBinary(string number)
        {
            bool validation = true;
            char[] charArray = number.ToCharArray();
            char[] validDigits = new char[2] {'0', '1'};

            foreach (char item in charArray)
            {
                if(!validDigits.Contains(item))
                {
                    validation = false;
                    break;
                }
            }

            return validation;
        }

        private static bool ValidateInputDecimal(string number)
        {
            bool validation = true;
            char[] charArray = number.ToCharArray();
            char[] validDigits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            foreach (char item in charArray)
            {
                if (!validDigits.Contains(item))
                {
                    validation = false;
                    break;
                }
            }

            return validation;
        }

        private static bool ValidateInputHexadecimal(string number)
        {
            bool validation = true;
            char[] charArray = number.ToCharArray();
            char[] validDigits = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' , 'A', 'B', 'C', 'D', 'E', 'F'};

            foreach (char item in charArray)
            {
                if (!validDigits.Contains(item))
                {
                    validation = false;
                    break;
                }
            }

            return validation;
        }
    }
}
