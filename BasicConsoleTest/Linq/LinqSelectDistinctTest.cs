﻿using BasicConsoleTest.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace BasicConsoleTest.Linq
{
    public class LinqSelectDistinctTest
    {
        public List<dynamic> GetUniqueMerchantIdAndName(List<MerchantModel> list)
        {
            List<dynamic> uniqueMerchant = list
                .Select(x => new { x.Id, x.Name })
                .Distinct()
                .Select(x => GetDynamicMerchant(x.Id, x.Name))
                .ToList();

            return uniqueMerchant;
        }

        public List<dynamic> GetUniqueBatch(List<MerchantModel> list)
        {
            List<dynamic> uniqueBatch = list
               .Select(x => x.Batch)
               .Distinct()
               .Select(x => GetDynamicBatch(x))
               .ToList();

            return uniqueBatch;
        }

        public dynamic GetDynamicMerchant(long id, string name)
        {
            dynamic runTimeObject = new ExpandoObject();
            runTimeObject.merchantId = id;
            runTimeObject.merchantName = name;
            return runTimeObject;
        }

        public dynamic GetDynamicBatch(string batch)
        {
            dynamic runTimeObject = new ExpandoObject();
            runTimeObject.batch = batch;
            return runTimeObject;
        }

        public List<MerchantModel> DataEntry()
        {
            List<MerchantModel> merchantList = new List<MerchantModel>();
            MerchantModel merchantModel = new MerchantModel();

            merchantModel.Id = 1;
            merchantModel.Name = "Cola";
            merchantModel.Batch = "Summer Party";
            merchantModel.AlbumId = 1;
            merchantList.Add(merchantModel);

            MerchantModel merchantModel2 = new MerchantModel();
            merchantModel2.Id = 2;
            merchantModel2.Name = "Pepsi";
            merchantModel2.Batch = "Spring Party";
            merchantModel2.AlbumId = 1;
            merchantList.Add(merchantModel2);

            MerchantModel merchantModel3 = new MerchantModel();
            merchantModel3.Id = 1;
            merchantModel3.Name = "Cola";
            merchantModel3.Batch = "Open Collab";
            merchantModel3.AlbumId = 1;
            merchantList.Add(merchantModel3);

            MerchantModel merchantModel4 = new MerchantModel();
            merchantModel4.Id = 2;
            merchantModel4.Name = "Pepsi";
            merchantModel4.Batch = "Summer Party";
            merchantModel4.AlbumId = 1;
            merchantList.Add(merchantModel4);

            return merchantList;
        }
    }

}
