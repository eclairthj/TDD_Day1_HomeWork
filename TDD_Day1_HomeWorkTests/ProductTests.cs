using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Day1_HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day1_HomeWork.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void Test_Sum_Cost_6_15_24_21()
        {
            var actual = new List<int>()
            {
                GetCostSum(0, 3, GetTestData()),
                GetCostSum(3, 3, GetTestData()),
                GetCostSum(6, 3, GetTestData()),
                GetCostSum(9, 3, GetTestData())
            };
            var expected = new List<int> { 6, 15, 24, 21 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_Sum_Revenue_50_66_60()
        {
            var actual = new List<int>()
            {
                GetRevenueSum(0, 4, GetTestData()),
                GetRevenueSum(4, 4, GetTestData()),
                GetRevenueSum(8, 4, GetTestData())
            };
            var expected = new List<int> { 50, 66, 60 };
            CollectionAssert.AreEqual(expected, actual);
        }
        public int GetCostSum(int index, int range, List<Product> list)
        {
            return list.Skip(index).Take(range).Sum(a => a.cost);
        }

        public int GetRevenueSum(int index, int range, List<Product> list)
        {
            return list.Skip(index).Take(range).Sum(a => a.revenue);
        }

        public List<Product> GetTestData()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { id = 1, cost = 1, revenue = 11, sellPrice = 21 });
            products.Add(new Product { id = 2, cost = 2, revenue = 12, sellPrice = 22 });
            products.Add(new Product { id = 3, cost = 3, revenue = 13, sellPrice = 23 });
            products.Add(new Product { id = 4, cost = 4, revenue = 14, sellPrice = 24 });
            products.Add(new Product { id = 5, cost = 5, revenue = 15, sellPrice = 25 });
            products.Add(new Product { id = 6, cost = 6, revenue = 16, sellPrice = 26 });
            products.Add(new Product { id = 7, cost = 7, revenue = 17, sellPrice = 27 });
            products.Add(new Product { id = 8, cost = 8, revenue = 18, sellPrice = 28 });
            products.Add(new Product { id = 9, cost = 9, revenue = 19, sellPrice = 29 });
            products.Add(new Product { id = 10, cost = 10, revenue = 20, sellPrice = 30 });
            products.Add(new Product { id = 11, cost = 11, revenue = 21, sellPrice = 31 });
            return products;
        }
    }
}