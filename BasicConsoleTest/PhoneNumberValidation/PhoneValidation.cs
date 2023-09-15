using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleTest.PhoneNumberValidation
{
    public class PhoneValidation // testing libphonenumber-csharp library
    {
        public void Validate(string phone, string countryCode)
        {
            if (string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("Phone number is null");
                return;
            }

            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            PhoneNumber phoneNumber = phoneUtil.Parse(phone, countryCode);
            bool isValidPhone = phoneUtil.IsValidNumber(phoneNumber);

            if (!isValidPhone)
            {
                Console.WriteLine("Fail Validation");
                return;
            }
            else
            {
                Console.WriteLine("Pass Validation");
                return;
            }
        }
    }
}
