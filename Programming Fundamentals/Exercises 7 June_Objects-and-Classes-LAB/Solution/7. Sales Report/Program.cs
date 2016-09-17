using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Sale
{
    public string Town { get; set; }

    public string Product { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public decimal TotalPrice
    {
        get
        {
            return this.Quantity * this.Price;
        }
    }
}

/*
 * Write a class Sale holding the following data:
 *   - Town, product, price, quantity
 * Read a list of sales and print the total sales by town
 */
public class SalesReport
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Sale[] sales = ReadSales(n);

        /* By SortedDictionary */

        SortedDictionary<string, decimal> totalSalesByTown = new SortedDictionary<string, decimal>();

        foreach (var sale in sales)
        {
            if (totalSalesByTown.ContainsKey(sale.Town))
            {
                totalSalesByTown[sale.Town] += sale.TotalPrice;
            }
            else
            {
                totalSalesByTown.Add(sale.Town, sale.TotalPrice);
            }
        }

        Console.WriteLine(string.Join("\r\n", totalSalesByTown.Select(s => s.Key + " -> " + s.Value.ToString("F2"))));

        /* By List and LINQ */

        // List<string> totalSalesByTown = new List<string>();

        // var towns = sales.Select(sale => sale.Town).Distinct();

        // foreach (string town in towns)
        // {
        //     decimal totalSumByTown = sales
        //         .Where(sale => sale.Town == town)
        //         .Select(sale => sale.TotalPrice)
        //         .Sum();

        //     totalSalesByTown.Add(string.Format("{0} -> {1:F2}", town, totalSumByTown));
        // }

        // totalSalesByTown.Sort();

        // Console.WriteLine(string.Join("\r\n", totalSalesByTown));
    }

    private static Sale ReadSale()
    {
        string[] saleParts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        Sale sale = new Sale()
        {
            Town = saleParts[0],
            Product = saleParts[1],
            Price = decimal.Parse(saleParts[2]),
            Quantity = decimal.Parse(saleParts[3])
        };

        return sale;
    }

    private static Sale[] ReadSales(int n)
    {
        Sale[] sales = new Sale[n];

        for (int i = 0; i < n; i++)
        {
            sales[i] = ReadSale();
        }

        return sales;
    }
}
