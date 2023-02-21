﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockManagement
{
    public class FetchStock
    {
        public StockDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockDetails>(json);

                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
