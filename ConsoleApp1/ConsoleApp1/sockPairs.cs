using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sockPairs
    {
        int arrayIndex,traverseIndex;
        int numberOfSocks = -1,count=0;
        List<int> sockList = new List<int>();
        List<int> duplicateList = new List<int>();

        public void getValue()
        {


            while (numberOfSocks <= 0)
            {
                try
                {
                    Console.WriteLine("\nEnter the total number of socks");
                    numberOfSocks = Convert.ToInt32(Console.ReadLine());
                    if (numberOfSocks <= 0)
                    {
                        Console.WriteLine("\nEnter a Positive or Non Zero Input");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nEnter a Valid Input");
                }
            }
            string _sock_String;
            int validInputFlag = 0;

            while (validInputFlag == 0)
            {
                Console.WriteLine("\nEnter the different socks");
                _sock_String = Console.ReadLine();
                for (arrayIndex = 0; arrayIndex < numberOfSocks; arrayIndex++)
                {
                    try
                    {
                        try
                        {
                            sockList.Add( Int32.Parse(_sock_String.Split(' ')[arrayIndex]));
                            if (sockList[arrayIndex] <= 0)
                            {
                                Console.WriteLine("\nEnter a Positive or Non Zero Input");
                                break;
                            }
                            else
                            {
                                validInputFlag = 1;
                            }

                        }
                        catch(IndexOutOfRangeException)
                        {
                            Console.WriteLine("\nEnter values in range");
                            break;
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("\nEnter a Valid Input");
                        break;
                    }
                }
            }
        }
        public void printDetail()
        {
            for(arrayIndex=0;arrayIndex<numberOfSocks;arrayIndex++)
            {
                Console.WriteLine("\n\n{0}", sockList[arrayIndex]);
            }
        }
        public void findDuplicates()
        {
            duplicateList = sockList;
            for(arrayIndex=0;arrayIndex< duplicateList.Count-1;arrayIndex++)
            {
                for(traverseIndex=arrayIndex+1;traverseIndex< duplicateList.Count; traverseIndex++)
                {
                    if(duplicateList[arrayIndex]== duplicateList[traverseIndex])
                    {
                        count = count + 1;
                        duplicateList.RemoveAt(arrayIndex);
                        duplicateList.RemoveAt(traverseIndex-1);
                        arrayIndex = -1;
                        break;
                    }
                    else
                    {
                       if(duplicateList == null)
                        {
                            break;
                        }
                       else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine("\nThe number of matching pairs are : {0}", count);

        }
        public static void Main(string[] args)
        {
            sockPairs sock = new sockPairs();
            sock.getValue();
            sock.findDuplicates();
            Console.ReadLine();
        }
    }
}
