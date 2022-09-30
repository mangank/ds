using System;

namespace bubblesort

{

class bsort

{

public static void Main3 (String [] args)

{

int[] element = { 45, 87, 30, 20, 97,63, 75};

int noe = element.Length-1;

int i,j;

int temp;

for (i=0; i<noe; i++)

for (j = 0; j<noe;j++)

{

   if (element[j]<element[j+1])

    {

        temp = element[j];

        element[j] = element[j+1];

        element[j+1]=temp;

    }

}

for (i=0; i<noe; i++)

Console.WriteLine(element[i]);

}

}

}

