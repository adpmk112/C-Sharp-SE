using BasicConsoleTest.DateTimeTest;
using BasicConsoleTest.DynamicKeyword;
using BasicConsoleTest.Linq;
using BasicConsoleTest.Models;
using BasicConsoleTest.ObjectKeyword;
using BasicConsoleTest.PhoneNumberValidation;
using BasicConsoleTest.Reflection;
using BasicConsoleTest.StaticKeyword;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {


            #region GetAllDateTest

            //DateTime startDate = DateTime.Parse("2023-09-1 00:00:00.000");
            //DateTime endDate = DateTime.Parse("2023-09-8 00:00:00.000");

            //GetDateTest dateTest = new GetDateTest();
            //List<DateTime> dateList = new List<DateTime>();

            //dateList = dateTest.GetAllDates(startDate, endDate);

            //foreach (DateTime date in dateList)
            //{
            //    Console.WriteLine(date.ToString("yyyyy-MM-dd HH:mm:ss.fff"));
            //}

            #endregion

            #region GetDateBetweenTest
            //DateTime startDate = DateTime.Parse("2023-09-1 00:00:00.000");
            //DateTime endDate = DateTime.Parse("2023-09-8 00:00:00.000");

            //GetDateTest dateTest = new GetDateTest();
            //List<DateTime> datesBetween = new List<DateTime>();

            //datesBetween = dateTest.GetDatesBetween(startDate, endDate);

            //foreach (DateTime date in datesBetween)
            //{
            //    Console.WriteLine(date.ToString("yyyyy-MM-dd HH:mm:ss.fff"));
            //}
            #endregion

            #region Reflection Test
            //AlbumModel albumDto = new AlbumModel();
            //albumDto.Id = 6;
            //albumDto.Name = "PopStar";

            //ReflectionTest reflectionTest = new ReflectionTest();

            //string result = reflectionTest.GetResult(albumDto);
            //Console.WriteLine(result);
            #endregion

            #region PhoneValidation Test

            //PhoneValidation phoneValidation = new PhoneValidation();

            //string phone = "09262634956";
            //string countryCode = "MM";

            //phoneValidation.Validate(phone, countryCode);
            #endregion

            #region LinQ Test
            //LinqSelectDistinctTest linqTest = new LinqSelectDistinctTest();

            //List<MerchantModel> list = linqTest.DataEntry();

            //Console.WriteLine("DataList");

            //foreach (MerchantModel model in list)
            //{
            //    Console.WriteLine("Model id --> " + model.Id + "  Model Name --> " + model.Name +
            //                      "  Model Batch --> " + model.Batch);
            //}

            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine("Unique Merchant");

            //List<dynamic> uniqueMerchant = linqTest.GetUniqueMerchantIdAndName(list);

            //foreach (dynamic merchant in uniqueMerchant)
            //{
            //    Console.WriteLine("MerchantId --> " + merchant.merchantId + "  MerchantName -->" + merchant.merchantName);
            //}

            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine("Unique Batch");

            //List<dynamic> uniqueBatch = linqTest.GetUniqueBatch(list);

            //foreach (dynamic batch in uniqueBatch)
            //{
            //    Console.WriteLine("Batch --> " + batch.batch);
            //}

            //Console.WriteLine("-----------------------------------------------");
            #endregion

            #region Dynamic Keyword Test
            //DynamicTest dynamicTest = new DynamicTest();

            //dynamic outputObject = dynamicTest.Calulate(13);

            //Console.WriteLine(outputObject.feet);
            //Console.WriteLine(outputObject.inches);
            #endregion

            #region Static Keyword Test
            //Person person = new Person();
            //person.Pname = "PMK";

            //Console.WriteLine("Instance name --> " + person.Pname);

            //string classLevelName = Person.Name;

            //Console.WriteLine("ClassLevelName --> " + classLevelName);
            #endregion

            #region Object Keyword Test
            //ObjectTest objectTest = new ObjectTest();

            //MerchantModel merchantModel = new MerchantModel();
            //merchantModel.Id = 1;
            //merchantModel.Name = "Cola";

            //// need typecast to get field data from object
            //// can't do like this --> objectTest.ReturnObject(merchantModel).name
            //// cannot type cast if not merchantModel as it is stil merchantModel 

            //MerchantModel outMerchant = (MerchantModel)objectTest.ReturnObject(merchantModel);
            //Console.WriteLine("Merchant name --> " + outMerchant.Name);

            ////in my sight, object keyword is good to use for primitive type input and to carry unpredictable object
            //int number = 10;
            //string line = "Hello World";
            //decimal deciNum = 1.13m;
            //char word = 'A';

            //Console.WriteLine(objectTest.ReturnObject(number));
            //Console.WriteLine(objectTest.ReturnObject(line));
            //Console.WriteLine(objectTest.ReturnObject(deciNum));
            //Console.WriteLine(objectTest.ReturnObject(word));
            #endregion
        }
    }
}
