using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    public class sockPairs
    {
        int arrayIndex,traverseIndex;
        int count=0;
        List<int> sockList = new List<int>();
        List<int> duplicateList = new List<int>();

        public int totalSocks(int numberOfSocks)
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
            return numberOfSocks;
        }
        public List<int> getSockList(int numberOfSocks)
        { 
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
            return sockList;
        }

       
        public int findDuplicates(List<int> sockList)
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
            
            int result;
            for (arrayIndex = 0; arrayIndex < sockList.Count; arrayIndex++)
            {
                result = -1;
                if (sockList[arrayIndex] <= 0)
                {
                    return result;
                }
                else
                {
                    result = 1;
              
                }
                
            }
            return count;
        }
        public static void Main(string[] args)
        {
            sockPairs sock = new sockPairs();
            int numberOfSocks = -1;
            numberOfSocks = sock.totalSocks(numberOfSocks);
            List<int>sockList=sock.getSockList(numberOfSocks);
            int count = sock.findDuplicates(sockList);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
