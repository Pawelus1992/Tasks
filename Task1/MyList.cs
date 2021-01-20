using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class MyList
    {
        List<int> list;
        Random random;
        int listSize;
        const int minValue = 0;
        const int maxValue = 100;

        public MyList()
        {
            list = new List<int>();
            listSize = 0;
        }

        public MyList(int size)
        {
            list = new List<int>();
            listSize = size;
        }

        public void showAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(". . . . .\n");
        }

        // 1
        public void popList()
        {
            try
            {
                random = new Random();
                for (int i = 0; i < listSize; i++)
                {
                    list.Add(random.Next(minValue, maxValue));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 2
        public List<int> getReservedThird()
        {
            List<int> tempList = new List<int>();
            list.Reverse();
            int i = 0;
            foreach (var item in list)
            {
                if (i == 0 || i % 3 == 0)
                    tempList.Add(item);
                i++;
            }
            list.Reverse();// return origin list
            return tempList;
        }

        // 3
        public List<int> getAvgList()
        {
            List<int> tempList = new List<int>();
            int index = 0;
            foreach (var item in list)
            {
                if (index == 0)
                    tempList.Add((item + list[index + 1] + 50) / 3);
                else if (index < list.Count - 1)
                    tempList.Add((list[index - 1] + item + list[index + 1]) / 3);
                else
                    tempList.Add((item + list[index - 1] + 50) / 3);
                index++;
            }
            return tempList;
        }


        // 4
        public List<int> getBiggerThen(int i)
        {
            List<int> tempList = new List<int>();
            foreach (var item in list)
            {
                if (item > i)
                    tempList.Add(item);
            }
            return tempList;
        }



        // 5
        public void getMultipledItems()
        {
            foreach (var item in list)
            {
                for (int i = 0; i < listSize; i++)
                {
                    if (list[i] * item > 9000) { 
                        Console.WriteLine("founded ("+item+","+i+")");                       
                    }
                }              
            }
        }

      
    }
}
