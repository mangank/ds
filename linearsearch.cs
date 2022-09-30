class ls
{
    public static void Mainsearch(String[] args)
    {
        int[] element = {45,87,30,20,97,63,75,34,88};
        int item = 34;
        int noe = element.Length;
        int flag = -1;

        for(int i=0;i<noe;i++)
        {

            if(element[i]==item)
            {

              Console.WriteLine("The item " + item  +" is found in position " + (i+1));
              flag = -1;
              break;
            }
             else 
               flag = 10;   
        }   
            if(flag==10)
         Console.WriteLine("The item " + "is NOT found.");
    }

}