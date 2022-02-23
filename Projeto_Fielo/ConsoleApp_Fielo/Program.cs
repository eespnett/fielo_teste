using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_Fielo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.ReadKey();
            System.Console.WriteLine("What is the Monkey position?");
            string arrayFiled = System.Console.ReadLine();

        
            int[,] resultsArray=   ;

          string[]  arrRow = arrayFiled.Split('{{');

            for (int i = 0; i < arrRow.Length; i++)
            {
                string strItemsMyRow = arrRow[i].Remove('},');
                string[] arrstrItemsMyRow = strItemsMyRow.Split(',');
                for (int j = 0; j < arrstrItemsMyRow.Length; j++)
                {
                    resultsArray[i, j] = int.Parse(arrstrItemsMyRow[j]);
                }
            }
           
         


             System.Console.ReadKey();
            System.Console.WriteLine("What is the Monkey position?");
            int intPositionMonkey=  int.Parse(System.Console.ReadLine());


            int OutPutBananas = 0;

            OutPutBananas = CalculateBananasFromField(intPositionMonkey, resultsArray);




        }

        private static int CalculateBananasFromField(int intPositionMonkey, int[,] resultsArray)
        {
            int intCalculateBananasFromField = 0;

            for (int i = int; i < resultsArray.Length; i++)
            {
                if (resultsArray[intCalculateBananasFromField,i]>0)
                {
                    intCalculateBananasFromField = resultsArray[intCalculateBananasFromField, i];
                }
                else
                {
                    if (resultsArray[intCalculateBananasFromField, i+1]>0 
                        && resultsArray[intCalculateBananasFromField, i + 1]> resultsArray[intCalculateBananasFromField, i+1 + 1] 
                        && resultsArray[intCalculateBananasFromField, i - 1] > resultsArray[intCalculateBananasFromField, i + 1 + 1])
                    {
                        intCalculateBananasFromField += resultsArray[intCalculateBananasFromField, i + 1];
                    }
                    else
                    {
                        if (resultsArray[intCalculateBananasFromField+1, i + 1] > 0 
                            && resultsArray[intCalculateBananasFromField+1, i + 1] < resultsArray[intCalculateBananasFromField, i + 1] && resultsArray[intCalculateBananasFromField+1, i - 1] < resultsArray[intCalculateBananasFromField+1, i + 1 + 1])
                        {
                            intCalculateBananasFromField += resultsArray[intCalculateBananasFromField+1, i + 1];
                        }
                        else
                        {
                            intCalculateBananasFromField += resultsArray[intCalculateBananasFromField - 1, i + 1];
                        }
                    }
                }
            }

            return intCalculateBananasFromField;
        }
    }
}
