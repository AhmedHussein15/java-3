

1 - Write a Java method to find the smallest number among three
numbers?

package javaapplicationl;
import java.util.Scanner;
import java.lang.Math;
import java.util.Arrays;
public class JavaApplication1
{

    public static double smallest(double x, double y, double z)
    {
        return Math.min(Math.min(x, y), z);
    }

    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        System.out.print("Input the first number: ");
        double x = in.nextDouble();
        System.out.print("Input the Second number: ");
        double y = in.next Double();
        System.out.print("Input the third number: ");
        double z = in.nextDouble();

        System.out.print("The smallest value is " + smallest(x, y, z) + "\n");
    }
---------------------------------------------------------------------
2-Write a Java method to compute the average of three numbers?

import java.util.Scanner; 
import java.lang.Math;
    import java.util.Arrays;
    public class JavaApplication1
    {

        public static double average(double x, double y, double z)
        {
            return (x + y + z) / 3;
        }
        public static void main(String[] args)
        {
        }
        Scanner in = new Scanner(System.in);
        System.out.print("Input the first number: ");
        double x = in.nextDouble();
        System.out.print("Input the second number: ");
        double y = in.nextDouble();
        System.out.print("Input the third number: ");
        double z = in.nextDouble();
        System.out.print("The average value is " + average (x, y, z)+"\n");
    }
}
-------------------------------------------------------------------
3 - Write a Java method to count all vowels in a string?

import java.util.Scanner;
import java.lang.Math;
import java.util.Arrays;
public class JavaApplication1
{
    public static int count_Vowels(String str)
    {
        int count = 0;
        for (int i = 0; i < str.length(); i++)
        {
            if (str.charAt(i) == 'a' str.charAt(i) == 'e' | str.charAt(i) == 'i'
                     || str.charAt(i) == 'o' || str.charAt(i) == 'u')

{
            count++;
        }
        return count;
    }
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        System.out.print("Input the string: ");
        String str = in.nextLine();
        System.out.print("Number of Vowels in the string: + count_Vowels (str)+"\n");
     }
}
---------------------------------------------------------------------------------
4 - Write a Java methods to make a small calculator?

package sara;
import java.util.Arrays;
public class MyClass
{

    static int get_sum(int num1, int num2)
    {
        return num1 + num2;
    }
    static int get_sub(int num1, int num2)
    {
        return num1 - num2;
    }
    static int get_multi(int num1, int num2)
    {
        return num1 * num2;
    }

    static int get_mod(int num1, int num2)
    {
        return num1 % num2;
    }
-------------------------------------------
5. Write a Java method to check whether a year(integer) entered
by the user is a leap year or not?

blic class MyClass
    {
        public static boolean isLeap Year(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void main(String[] args)
        {
        }
        Scanner in = new Scanner(System.in);
        System.out.print("Input a year: ");
        int year = in.nextInt();
        System.out.println(isLeap Year (year));
    }
-----------------------------------------
6- Write Java methods to calculate maximum number in array of
elements?

import java.util.Arrays;
public class MyClass
    {
        static int get_max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.length; i++)
            {
                if (arr[0] < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void main(String[] args)
        {
            int[] arr(3,6,7,9,4,23};
        System.out.print(get_max(arr));
--------------------------------------------
7-Write a Java method to display the factors of 3 in a given
integer?

package java application1;
        import java.util.Scanner;
        import java.lang.Math;
        import java.util.Arrays;
        public class JavaApplication1
        {
            public static void test(int n)
            {
                System.out.print(n + " = ");
                int result = n;
                while (result % 3 == 0)
                {

                    System.out.print("3");
                    result = result / 3;
                }
                System.out.print(result);
            }
            public static void main(String[] args)
            {

                Scanner in = new Scanner(System.in);
                System.out.print("Input an integer (positive/negative):");
                int n = in.nextInt();
                System.out.print("\nFactors of 3 of the said integer: \n");
                test(n);
            }
        }
---------------------------------------------
8- Write a Java method to display sum of odd numbers until 50?

package javaapplicationl;
        import java.util.Scanner;
        import java.lang.Math;
        import java.util.Arrays;
        public class JavaApplication1
        {
            public static int test_odd()
            {
                int sum = 0;
                for (int i = 1; i < 50; i += 2)
                {
                    sum = sum + i;
                }
                return sum;
            }

            public static void main(String[] args)
            {
            }
            int sum-test_odd();
            System.out.print("the sum is : "+sum);
        }
------------------------------------------
9-Write a Java method(takes a number n as input) to displays an
n-by-n matrix?

package java applicationl;
import java.util.Scanner;
        import java.lang.Math;
        import java.util.Arrays;
        public class JavaApplication1
        {
            public static void printMatrix(int n)
            {
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < n; j++)
                    {
                        System.out.print((int)(Math.random() * 2)"
                    }
                    System.out.println();
                }
            }
            public static void main(String[] args)
            {
            }
            Scanner in = new Scanner(System.in);
            System.out.print("Input a number: ");
            int n = in.nextInt();
            printMatrix(n);
        }
    }

