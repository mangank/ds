using System;
namespace searching
{
    class bs
    {
        public static void Main2(String[] args)
        {
            int[] element = { 20, 30, 34, 45, 63, 75, 87, 88 };
            int item = 630;
            int lowidx = 0;
            int highidx = element.Length - 1;
            int mididx =0;


           bool flag = false;

           while (lowidx <= highidx)
            {
                 mididx = (lowidx + highidx) / 2;



               if (element[mididx] == item)
                {
                      Console.WriteLine("Item is found at position " + (mididx + 1));
                      flag = true;
                      break;
                }



               if (element[mididx] < item)
                    lowidx = mididx + 1;
                else
                    highidx = mididx - 1;
            }



           if (flag == false)
                Console.WriteLine("Item is NOT found.");
        }
    }
}
