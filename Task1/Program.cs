using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program : MyList
    {
        /*
        const int listSize = 10;
        const int minValue = 0;
        const int maxValue = 100;
*/
        static void Main(string[] args)
        {
            MyList list = new MyList(200);

            // 1
            list.popList();
            //list.showAll();

            // 2
            List<int> reservedThird = list.getReservedThird();
            //showAllItems(reservedThird);

            // 3
            List<int> avgList = list.getAvgList();
            //showAllItems(avgList);

            // 4
            List<int> onlyBig = list.getBiggerThen(90);
            showAllItems(onlyBig);

            // 5
            //List<int> mList = list.getMultipledList();
           // showAllItems(mList);



            void showAllItems(List<int> l)
            {
                int index = 0;
                foreach (var item in l)
                {
                    Console.WriteLine(index+". "+item);
                    index++;
                }
                Console.WriteLine(". . . . .\n");
            }
        }
    }
}
