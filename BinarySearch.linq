<Query Kind="Program" />

void Main()
{
    Console.WriteLine("your number for search");
	int search=Convert.ToInt32(Console.ReadLine());
	List<int>numbers=new List<int>(){1,2,5,7,9,13,24,55};
	IsFound(numbers,search);
	
}

// You can define other methods, fields, classes and namespaces here



   void IsFound(List<int>numbers,int search)
  {
   int low,mid,high;
	   low=0; 
	   high=numbers.Count-1;
   int ForLoop=high;
   
   while(low!=ForLoop)
	 {
	     ForLoop=high-1;
	     mid=(low+high)/2;
	
	  if(numbers[mid]==search||numbers[low]==search||numbers[high]==search)
	   {
	    Console.WriteLine("your number is found");
	    return;
	   }
	  else
	   {
	    if(numbers[mid]>search) high=mid;
	    if(numbers[mid]<search) low=mid;
	   }
	  
   }
	
	Console.WriteLine("not found");
   }