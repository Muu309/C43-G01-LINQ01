using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static LINQ01.ListGenerator;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Restriction Operators
            #region 1
            //var res = ProductsList.Where(p => p.UnitsInStock <= 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region 2
            //var res = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3M);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where((N, I) => N.Length < I);
            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion
            #endregion

            #region Element Operators
            #region 1
            //var result = ProductsList.First(p=>p.UnitsInStock<=0);
            //Console.WriteLine(result);
            #endregion
            #region 2
            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result?.ProductName ?? "Not Found");
            #endregion
            #region 3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var NumGreaterThan5 = Arr.Where(x => x > 5).ElementAt(1);
            //Console.WriteLine(NumGreaterThan5);

            #endregion
            #endregion

            #region Aggregate Operators
            #region 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(p => p%2!=0);
            //Console.WriteLine(result);
            #endregion
            #region 2
            //var res = CustomersList.Select(c => new { c.CustomerName, Ordercount = c.Orders.Count() });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3
            //var res = ProductsList.Select(p => new { Category = p.Category, NumOfProudct = ProductsList.Count(c => c.Category == p.Category) }).ToHashSet();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum();
            //Console.WriteLine(res);
            #endregion
            #region 5
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Sum(w => w.Length);
            //Console.WriteLine(res);
            #endregion
            #region 6
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Min(x => x.Length);
            //Console.WriteLine(res);
            #endregion
            #region 7
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Max(x => x.Length);
            //Console.WriteLine(res);
            #endregion
            #region 8
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = (int)words.Average(x => x.Length);
            //Console.WriteLine(res);
            #endregion
            #endregion

            #region Ordering Operators
            #region 1
            //var res = ProductsList.OrderBy(x => x.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #endregion
            #region 3
            // var res = ProductsList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var item in res)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region 4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //foreach (var x in res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region 5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(x=>x.Length).ThenBy(b=>b);
            #endregion
            #region 6
            //var res = ProductsList.OrderBy(x => x.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7

            #endregion
            #region 8

            #endregion

            #endregion

            #region Transformation Operators

            #region 1
            //var res = ProductsList.Select(x => x.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w => new { Uppercase = w.ToUpper(), Lowercase = w.ToLower() });
            //foreach (var word in res)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 3
            //var res = ProductsList.Select(p => new { p.ProductID, p.ProductName, p.UnitsInStock, Price = p.UnitPrice });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select((x, i) => new
            //{

            //    Number = x,
            //    x = i == x ? "True" : "False"

            //});
            //foreach (var x in res)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion
            #region 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select new { NumberA = a, NumberB = b };
            //foreach (var x in res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region 6
            //var res = CustomersList.SelectMany(o => o.Orders).Where(o => o.Total < 500);
            //foreach (var o in res)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #region 7
            //var res = CustomersList.SelectMany(o => o.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var o in res)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #endregion
        }
    }
}
