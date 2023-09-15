using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace BasicConsoleTest.Linq
{
    public class LinqTest
    {
        public List<dynamic> GetUniqueMerchantIdAndName(List<MerchantModel> list)
        {
            List<dynamic> uniqueMerchant = list
                .Select(x => new { x.id, x.name })
                .Distinct()
                .Select(x => GetDynamicMerchant(x.id, x.name))
                .ToList();

            return uniqueMerchant;
        }

        public List<dynamic> GetUniqueBatch(List<MerchantModel> list)
        {
            List<dynamic> uniqueBatch = list
               .Select(x => x.batch)
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

            merchantModel.id = 1;
            merchantModel.name = "Cola";
            merchantModel.batch = "Summer Party";
            merchantModel.albumId = 1;
            merchantList.Add(merchantModel);

            MerchantModel merchantModel2 = new MerchantModel();
            merchantModel2.id = 2;
            merchantModel2.name = "Pepsi";
            merchantModel2.batch = "Spring Party";
            merchantModel2.albumId = 1;
            merchantList.Add(merchantModel2);

            MerchantModel merchantModel3 = new MerchantModel();
            merchantModel3.id = 1;
            merchantModel3.name = "Cola";
            merchantModel3.batch = "Open Collab";
            merchantModel3.albumId = 1;
            merchantList.Add(merchantModel3);

            MerchantModel merchantModel4 = new MerchantModel();
            merchantModel4.id = 2;
            merchantModel4.name = "Pepsi";
            merchantModel4.batch = "Summer Party";
            merchantModel4.albumId = 1;
            merchantList.Add(merchantModel4);

            return merchantList;
        }
    }

}
