using System;
using System.Collections.Generic;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.Write(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try  // logic: 1. The first step for this question that I want to split every digit of the number between 1 to 22. 
                 //        2. From 1-22 I split each digit by divide 10. if the remainder is 0, I define if the number is self-dividing number. 
                 //        3. If the number has a digit is zero, I judge this number not the self-dividing number. 
                 // self-reflection: In this question, I got stuck in how to split the digits and judge if the number is the self-dividing number. 
                 //                  I need to do more practice for the conditional clause to increase proficiency.
            {
                int rem ;// define remainder is int
                
                for (int i = x; i <= y; i++)// outer loop from x increase to y each time add 1 and pick up the number belong to self-dividing number between x and y.
                {
                    int num = i; // denfine as print out the self-dividing number.
                    int d = i; // the d means each digit split from i.
                    while (d!=0)// this inner loop do the condition select self-dividing number and judge which number is self-dividing number.
                    {
                        rem = i % 10; // 
                        d = d / 10; // split the digit as divisor.
                   
                        if (rem == 0) // this statement is used to remove the number which is the times of 10.
                            break;
                        if (num % rem != 0) // this statement remove the number which is not self-dividing number.
                            break;
                        if (d == 0) // this statement is used to output the self-dividing number.
                            Console.Write(" " + num); // print out the result.

                    }
                    
                }
                Console.WriteLine();
                
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try  // logic: 1. Find the rule of number repeat times.
                 //        2. List the number and show the duplicate number in the list. example: 1,2,2,3,3,3,4,4,4,4,5,5,5,5,5,5
                 //        3. Set a variable to limit the total number of output.
                 // self-reflection: It's easy to find the rule of the question, but I feel struggling to repeat the number and how to limit the output number.
                 //                  From this question I learned how to set a limit to output the result.
            {
                int k = 1;  // use variable K to limit the output numbers
                for (  int i = 1;i<=n;i++)  // this outer loop is used to list the number series. example:1,2,3,4,5,6,7.....,n
                {
                    for(int j=1;j<=i;j++)  // this inner loop is used to define repeat times in list.
                    {

                        if (k <= 5)  // limit the output number
                        { Console.Write(" " + i);  
                            k++;
                        }
                    }
                }
                

                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try  // Logic: 1. Find the rule of the star numbers in each row.
                 //        2. Find the rule of the space numbers in each row.
                 // Self-reflection: This question is a little bit similar with question 2 each of them need to find the rule. 
                 //                  In this question I get stuck in display the trangle form correctly, at the beginning I got right rangle.
                 //                  If I can't execute the result correctly, I need repeat and do experiments again and again.
            {
                for (int i = 1; i <= 5; i++) // the outer loop demonstrate how to display the trangle and judge how many stars and space in each row.
                {
                    for (int k = 1; k <= i; k++)// this inner loop is used to display the rule of space numbers in the left of each row
                    {
                        Console.Write(" "); 
                    }
                    for (int j = 1; j <= 2 * (5 - i) + 1; j++)// this inner loop is used to display the rule of star numbers in each row of the trangle.
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            int count = 0;
            try  // Logic: 1. compare these two sets which is the Jewels, and the other set is the stone you have, If the stones have the same number with J set, we can define the stone is jewels and count the number.
                 // Sef-reflection: This question test us compare the elements in different sets.
                 //                 From this question learned how to compared and select common elements in two sets.
            {
            
                for (int i = 0; i < J.Length; i++) // This outer loop define the elements in set J start from the first element.
                {
                    for (int k = 0; k < S.Length; k++) // This inner loop define the elements in set S start from the first element.
                    {
                        if (J[i] == S[k]) // Compare two sets if the S set has the same number with J set, we judge element as jewel and count the number.
                        {
                            count++; // Display how many stones in set S are jewels.
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return count;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            // Logic: 1. get the numbers from a and b
            //        2. then compare the elements in set a and set b
            //        3. if the elements are equal, count the number of the equal elements
            //        4. record how many contiguous equal numbers(elements) have been counted and the last position of contiguous equal numbers
            //        5. output the numbers in step 4
            // self-reflection: I formed a idea to solve this question, but I did not work out it.
            //                  I think I need do more practice and work more efficient.
            try
            {
           

               
               
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}

