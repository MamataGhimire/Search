<Query Kind="Program" />

void Main()
{
    Console.WriteLine("number for the search");
	int search=Convert.ToInt32(Console.ReadLine());
	List<int>num=new List<int>(){1,5,3,6,9,2};
	int IsFound=LinearSearch(num,search);
	if(IsFound==-1)
	{
	Console.WriteLine("your number is not found");
	return;
	}
	
	Console.WriteLine(search+" "+"is found in"+" "+(IsFound+1)+" "+"index" );
	
}

  

// You can define other methods, fields, classes and namespaces here
 int LinearSearch(List<int>num,int search)
   {
      for (int i=0;i<num.Count;i++)
	  {
	    if (num[i]==search)
		{
		   return i;
		}
	  }
     return -1;
   }