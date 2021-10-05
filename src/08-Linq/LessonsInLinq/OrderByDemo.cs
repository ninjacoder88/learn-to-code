using System.Collections.Generic;
using System.Linq;

namespace LessonsInLinq
{
    public class OrderByDemo
    {
        public void Demo01()
        {
            //this involves sorting algorithms which is a whole topic by itself
            //Swap Sort, Heap Sort, Insertion Sort, Bubble Sort, Merge Sort
            var salesOrders = new SalesOrderLoader().LoadSalesOrders().ToArray();

            var array = salesOrders.ToArray();
            int n = array.Length;
            while(true)
            {
                bool swapped = false;
                for(int i = 1; i < n; i++)
                {
                    if(array[i-1].Total > array[i].Total)
                    {
                        var temp = array[i-1];
                        array[i-1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                if(swapped == false)
                    break;
            }

            array.ToList().Dump();
        }

        public void Demo02()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.OrderBy(x => x.Total).ToList().Dump();
        }

        public void Demo03()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.OrderByDescending(x => x.Total).ToList().Dump();
        }

        public void Demo04()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.OrderBy(x => x.CustomerName).ThenBy(x => x.Total).ToList().Dump();
        }
    }
}