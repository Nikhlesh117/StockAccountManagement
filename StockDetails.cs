using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class StockDetails
    {
        public List<Stocks> stocks;
    }
    public class Stocks
    {
        public string Stock;
        public int Shares;
        public int Price;
    }
}
