using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string [,] array2D = new string [3,3];
    string firstname, surname, gender;
   
   for(int i = 0;i<array2D.GetLength(0);i++)
    for(int j = 0;j<array2D.GetLength(1);j++)
      {
      if(j==0)
        {
          Console.WriteLine("please enter your first name");
          firstname = Console.ReadLine();
          array2D[i,j] = firstname;
        }  
     else if (j==1)
        {
          Console.WriteLine("please enter your surname");
          surname = Console.ReadLine();
        }
     else 
        {
          Console.WriteLine("please enter gender");
          gender = Console.ReadLine();
        }
      }  
  for(int i=0;i<array2D.GetLength(0);i++)
  {
    for(int j=1;<array2D.GetLength(1);i++)
    {
      Console.WriteLine(array2D[i,j]+",");
    }
  }

  for(int i=0;i<array2D.GetLength(0);i++)
  {
    Console.WriteLine(array2D[i,1]+",");
  }

  Console.WriteLine("Prints all the male users");
  for(int i=0;i,array2D.GetLength(0);i++)
  {
    if(array2D[1,2]== "male")
    {
      Console.WriteLine(array2D[i,0]+"," + array2D[i,1]+array2D[i,2]);
    }
  }



  string [,] array2Dpart5 = new string[5,3];

  for(int i=0;i<array2Dpart5.GetLength(0);i++)
  {
    for(int j=0;j<array2Dpart5.GetLength(1);j++)
    {
      if(j==0)
      {
        Console.WriteLine ("what is your first name");
        firstname= Console.ReadLine();
        array2Dpart5[i,j] = firstname
      }

      else if (j==1)
      {
        Console.WriteLine ("what is your surname");
        surname= Console.ReadLine();
        array2Dpart5[i,j] = surname
      }

      else 
      {
        Console.WriteLine ("what is your gendeer");
        gender= Console.ReadLine();
        array2Dpart5[i,j] = gender
      }
    
    }
  }
  }
}
  
