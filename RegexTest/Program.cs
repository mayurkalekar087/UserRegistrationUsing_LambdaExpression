﻿using System;
using System.Linq;
using System.Text;

namespace RegexTest
{
    class RegexProgram : Exception
    {
        public RegexProgram(String message) : base(message)
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Using Lambda Expression !");
            Console.WriteLine("User ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Choose what to Enter:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.\n6. Exit");
            Console.WriteLine("-------------------------");
            var userinput = Console.ReadLine();
            while (true)
            {
                try
                {
                    switch (userinput)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("Enter your First Name:");
                                RegexPatterns name = new RegexPatterns();
                                bool result = name.ValidateName(Console.ReadLine(), RegexPatterns.FIRSTNAME_REGEX);
                                Console.WriteLine(result);
                                if (result == false)
                                {
                                    throw new RegexProgram("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                                }
                            }
                            catch (RegexProgram e)
                            {
                                Console.WriteLine("====================\nInvalid Input\n====================");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "2":
                            try
                            {
                                Console.WriteLine("Enter your Last Name:");
                                RegexPatterns lastname = new RegexPatterns();
                                bool resultlastname = lastname.ValidateLastName(Console.ReadLine(), RegexPatterns.LASTNAME_REGEX);
                                Console.WriteLine(resultlastname);
                                if (resultlastname == false)
                                {
                                    throw new RegexProgram("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                                }
                            }
                            catch (RegexProgram e)
                            {
                                Console.WriteLine("====================\nInvalid Input\n====================");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case "3":
                            try
                            {
                                Console.WriteLine("Enter your Phone Number:");
                                RegexPatterns phonenum = new RegexPatterns();
                                bool resultphonenum = phonenum.ValidatePhoneNum(Console.ReadLine(), RegexPatterns.PHONENUM_REGEX);
                                Console.WriteLine(resultphonenum);
                                if (resultphonenum == false)
                                {
                                    throw new RegexProgram("Must contain integers only. Starting with '91' and space and having exact 10 digits as Phone Number.\n====================");
                                }
                            }
                            catch (RegexProgram e)
                            {
                                Console.WriteLine("====================\nInvalid Input\n====================");
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case "4":
                            try
                            {
                                Console.WriteLine("Enter your Email Id:");
                                RegexPatterns emailid = new RegexPatterns();
                                bool resultemailid = emailid.ValidateEmail(Console.ReadLine(), RegexPatterns.EMAIL_REGEX);
                                Console.WriteLine(resultemailid);
                                if (resultemailid == false)
                                {
                                    throw new RegexProgram("Must contain Alphabet and Numeric Combination only.\nEnding with proper domain address e.g. '@gmail.com'\n====================");
                                }
                            }
                            catch (RegexProgram e)
                            {
                                Console.WriteLine("====================\nInvalid Input\n====================");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "5":
                            try
                            {
                                Console.WriteLine("Enter your Password:");
                                RegexPatterns pass = new RegexPatterns();
                                bool resultpass = pass.ValidatePassword(Console.ReadLine(), RegexPatterns.PASSWORD_REGEX);
                                Console.WriteLine(resultpass);
                                if (resultpass == false)
                                {
                                    throw new RegexProgram("Must contain Alphanumeric combination.\nConsisting atleast 1 uppercase character, atleast 1 numeric value.\nAnd exactly one special character.\n====================");
                                }
                            }
                            catch (RegexProgram e)
                            {
                                Console.WriteLine("====================\nInvalid Input\n====================");
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("!! Invalid Input !!");
                            break;
                    }
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Choose what to Enter:");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1. First Name.\n2. Last Name.\n3. Phone Number.\n4. Email Id.\n5. Password.\n6. Exit");
                    Console.WriteLine("-------------------------");
                    userinput = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

    }
}