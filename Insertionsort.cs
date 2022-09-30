using System;
namespace insertionsort
{
    class MyInsertionSort
    {
        public static void Main4(string[] args)
        {
            int[] element = {45,87,30,20,97,63,75,34,88};
            int count = element.Length;
            int temp;
            int j =0;

            for (int i = 0; i <count ;i++)

            {
                
                temp = element[i +1];
                j =i;
               while (j>= 0 && temp < element[j]){

                 element[j+1] = element[j];
                j = j-1;
                
                }                
                element[j+1] = temp;
            }
            for (int i = 0; i < count; i++)

                Console.WriteLine (element[i]);
        }
    }
}
