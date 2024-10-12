using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
//35            
Console.WriteLine("Enter your annual salary: ");
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
double taxAmount = 0;
double taxableIncome = salary;
if (age >= 60)
{
    taxableIncome -= 5000;
}
if (taxableIncome < 10000)
{
    taxAmount = 0;
}
else if (taxableIncome >= 10000 && taxableIncome <= 50000)
{
    taxAmount = taxableIncome * 0.10;
}
else
{
    taxAmount = taxableIncome * 0.20;
}
Console.WriteLine($"The tax amount to be paid is {taxAmount}");
Console.ReadLine();
            
        //34
        //Console.WriteLine("Enter the marks for Subject 1: ");
        //int subject1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the marks for Subject 2: ");
        //int subject2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the marks for Subject 3: ");
        //int subject3 = Convert.ToInt32(Console.ReadLine());
        //int passingMark = 40;
        //bool passedAllSubjects = subject1 >= passingMark && subject2 >= passingMark && subject3 >= passingMark;
        //if (passedAllSubjects)
        //{
        //    Console.WriteLine("The student has passed in all subjects");
        //    double averageGrade = (subject1 + subject2 + subject3) / 3;
        //    if (averageGrade >= 70)
        //    {
        //        Console.WriteLine($"Distinction! Average Grade {averageGrade}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Average Grade {averageGrade}");
        //    }
        //}
        //else
        //{
        //    int failedSubjects = 0;
        //    if (subject1 < passingMark)
        //    {
        //        failedSubjects++;
        //    }
        //    if (subject2 < passingMark)
        //    {
        //        failedSubjects++;
        //    }
        //    if (subject3 < passingMark)
        //    {
        //        failedSubjects++;
        //    }

        //    Console.WriteLine($"The student has failed in {failedSubjects} subjects");
        //}
        //Console.ReadLine();

        //33
        //Console.WriteLine("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (num > 0)
        //{
        //    Console.WriteLine($"{num} is a positive number");
        //    if (num > 50)
        //    {
        //        Console.WriteLine($"{num} is greater than 50");
        //        if (num % 2 == 0)
        //        {
        //            Console.WriteLine($"{num} is even");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{num} is odd");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is not greater than 50");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is not a positive number");
        //}
        //Console.ReadLine();


        //32
        //Console.WriteLine("Enter a year: ");
        //int year = Convert.ToInt32(Console.ReadLine());
        //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //{
        //    Console.WriteLine($"{year} is a leap year");
        //}
        //else
        //{
        //    Console.WriteLine($"{year} is not a leap year");
        //}
        //Console.ReadLine();


        //31
        //Console.WriteLine("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (num % 3 == 0 && num % 5 == 0)
        //{
        //    Console.WriteLine($"The number {num} is divisible by both 3 and 5");
        //}
        //else
        //{
        //    Console.WriteLine($"The number {num} is not divisible by both 3 and 5");
        //}
        //Console.ReadLine();


        //30
        //Console.WriteLine("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (num >= 1 && num <= 100)
        //{
        //    Console.WriteLine($"The number {num} is within the range");
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine($"The number {num} is even");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {num} is odd");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine($"The number {num} is outside the range of 1 to 100");
        //}
        //Console.ReadLine();

        //29
        //Console.WriteLine("Enter the amount in USD: ");
        //double amountInUSD = Convert.ToDouble(Console.ReadLine());
        //double amountInEUR = amountInUSD * 0.85;
        //Console.WriteLine($"The amount is {amountInEUR}");
        //Console.ReadLine();

        //28
        //Console.WriteLine("Enter the first number: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Enter the second number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Enter the third number: ");
        //double num3 = Convert.ToDouble(Console.ReadLine());
        //double average = (num1 + num2 + num3) / 3;
        //Console.WriteLine($"The average is {average}");
        //Console.ReadLine();


        //27
        //Console.WriteLine("Enter the first number: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the second number: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //int result;
        //Console.WriteLine("\nArithmetic Operations:");
        //Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, num1 + num2);
        //Console.WriteLine("Subtraction: {0} - {1} = {2}", num1, num2, num1 - num2);
        //Console.WriteLine("Multiplication: {0} * {1} = {2}", num1, num2, num1 * num2);
        //if (num2 != 0)
        //{
        //    Console.WriteLine("Division: {0} / {1} = {2}", num1, num2, (float)num1 / num2); 
        //}
        //else
        //{
        //    Console.WriteLine("Division: Cannot divide by zero.");
        //}
        //if (num2 != 0)
        //{
        //    Console.WriteLine("Modulus: {0} % {1} = {2}", num1, num2, num1 % num2);
        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}
        //int incrementNum1 = num1 + 1;
        //int incrementNum2 = num2 + 1;
        //Console.WriteLine("Increment: {0}++ = {1}, {2}++ = {3}", num1, incrementNum1, num2, incrementNum2);
        //int decrementNum1 = num1 - 1;
        //int decrementNum2 = num2 - 1;
        //Console.WriteLine("Decrement: {0}-- = {1}, {2}-- = {3}", num1, decrementNum1, num2, decrementNum2);
        //Console.ReadLine();


        //26
        //Console.WriteLine("Enter the value of a: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value of b: ");
        //int b = Convert.ToInt32(Console.ReadLine());
        //int temp;
        //temp = a;
        //a = b;
        //b = temp;
        //Console.WriteLine("Swapped a = {0}, b = {1}", a, b);
        //a = a + b; 
        //b = a - b; 
        //a = a - b;
        //Console.WriteLine("Swapped using third variable a = {0}, b = {1}", a, b);
        //Console.ReadLine();


        //25
        //Console.WriteLine("Enter the marks (out of 100): ");
        //int marks = Convert.ToInt32(Console.ReadLine());
        //char grade;
        //if (marks >= 90)
        //{
        //    grade = 'A';
        //}
        //else
        //{
        //    if (marks >= 80)
        //    {
        //        grade = 'B';
        //    }
        //    else
        //    {
        //        if (marks >= 70)
        //        {
        //            grade = 'C';
        //        }
        //        else
        //        {
        //            if (marks >= 60)
        //            {
        //                grade = 'D';
        //            }
        //            else
        //            {
        //                grade = 'F';
        //            }
        //        }
        //    }
        //}
        //Console.WriteLine("The grade assigned is: " + grade);
        //Console.ReadLine();



        //24
        //Console.WriteLine("Enter the first number");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the second number");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the operator(+,-,*,/)");
        //char op = Console.ReadLine()[0];
        //double result = 0;
        //bool validOperation = true;

        //if (op == '+')
        //{
        //    result = num1 + num2;
        //}
        //else if (op == '-')
        //{
        //    result = num1 - num2;
        //}
        //else if (op == '*')
        //{
        //    result = num1 * num2;
        //}
        //else if (op == '/')
        //{
        //    if (num2 != 0)
        //    {
        //        result = num1 / num2;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error: Division by zero is not allowed.");
        //        validOperation = false;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Error: Invalid operator entered.");
        //    validOperation = false;
        //}
        //if (validOperation)
        //{
        //    Console.WriteLine("The result of {0} {1} {2} is: {3}", num1, num2, op, result);
        //}
        //Console.ReadLine();


        //23
        //Console.WriteLine("Enter a number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if ((number % 5 == 0) && (number % 11 == 0))
        //{
        //    Console.WriteLine("The number is divisible by both 5 and 11");
        //}
        //else
        //{
        //    Console.WriteLine("The number is not divisible by 5 and 11");
        //}
        //Console.ReadLine();


        //22
        //Console.WriteLine("Enter a number");
        //double number = Convert.ToInt32(Console.ReadLine());
        //if(number ==0)
        //{
        //    Console.WriteLine("The number is zero");
        //}
        //else if (number>0)
        //{
        //    Console.WriteLine("The number is positive");
        //}
        //else
        //{
        //    Console.WriteLine("The number is negative");
        //}
        //Console.ReadLine();


        //21
        //Console.WriteLine("Enter a character:");
        //string character = Console.ReadLine();
        //if ((character == "a")|| (character == "e") || (character == "i")||(character=="0")||(character=="u"))
        //{
        //    Console.WriteLine("It is vowel");
        //}
        //else
        // {
        //    Console.WriteLine("It is consonant");
        //}
        //Console.ReadLine();


        //20
        //Console.WriteLine("Enter your age:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter your years of experience:");
        //int yearExperience = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Have college degree?");
        //string degree = Console.ReadLine();
        //if (((age >=18) && (age<=35)) && ((yearExperience >= 2)) && ((degree == "yes") || (yearExperience >= 5)))
        //{
        //    Console.WriteLine("Eligible to apply for the job");
        //}
        //else
        //    {
        //Console.WriteLine("Not eligible");
        //}
        //Console.ReadLine();


        //19
        //Console.WriteLine("Enter your age:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter your income per year:");
        //double income = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Is there any other loan?");
        //string status = Console.ReadLine();
        //if ((age>=21) && (income >= 30000) && (status == "no"))
        //{
        //    Console.WriteLine("Eligible for loan");
        //}
        //else
        //{
        //    Console.WriteLine("Not eligible for loan");
        //}
        //Console.ReadLine();


        //18
        //Console.WriteLine("Enter your age:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter your citizenship");
        //string citizenship = Console.ReadLine();
        //if  ((age >= 18) && (citizenship == "indian"))
        //{ 
        //Console.WriteLine($"Eligible to vote");
        //}
        // else
        //{
        //Console.WriteLine($"Not eligible to vote");
        //}
        //Console.ReadLine();


        //17
        //Console.WriteLine("Enter the base number:");
        //    int basenumber = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the exponent number:");
        //int exponent = Convert.ToInt32(Console.ReadLine());
        //double power = Math.Pow(basenumber, exponent);
        //Console.WriteLine($"The power is {power}");
        //Console.ReadLine();

            //16
            //Console.WriteLine("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            //Console.ReadLine();


            //15
            //int number1 = 5;
            //int number2 = 3;
            //int sum = number1 + number2;
            //Console.WriteLine($"The sum is {sum}");
            //Console.ReadLine();


            //14
            //Console.WriteLine("Enter employee's name:"); // input employee's name
            //string name = Console.ReadLine();            
            //Console.WriteLine("Enter your age:");        // input age
            //int age = Convert.ToInt32(Console.ReadLine());  
            //Console.WriteLine("Enter your monthly salary:");  //input monthly salary
            //double salary = Convert.ToInt32(Console.ReadLine());  
            //Console.WriteLine($"Employee's name is {name} and age is {age} and monthly salary is {salary}"); //displaying all
            //Console.ReadLine();


            //13
            //Console.WriteLine("Enter the height:");
            //double height = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the width:");
            //double width = Convert.ToInt32(Console.ReadLine());
            //double areaOfRectangle = height * width;
            //double areaInInches = areaOfRectangle * 0.393701;
            //Console.WriteLine($"Area of rectangle in centimeters is {areaOfRectangle} and area of rectangle in inches {areaInInches}");
            //Console.ReadLine();


            //12
            //Console.WriteLine("Enter the radius:");
            //double radius = Convert.ToInt32(Console.ReadLine());
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //double circumference = 2 * PI * radius;
            //Console.WriteLine($"Circumference is {circumference} and days in a week are {DAYS_IN_WEEK}");
            //Console.ReadLine();


            //11
            //Console.WriteLine("Enter the radius:");
            //double radius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the length:");
            //double length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the width:");
            //double width = Convert.ToInt32(Console.ReadLine());
            //const double PI = 3.14;
            //double areaOfCircle = PI * radius * radius;
            //Console.WriteLine($"Area of circle is {areaOfCircle}");
            //double areaOfRectangle = length * width;
            //Console.WriteLine($"Area of rectangle is {areaOfRectangle}");
            //Console.ReadLine();


            //10
            //int num1 = 5;
            //Console.WriteLine($"Int is {num1}");
            //double num2 = 0.5;
            //    Console.WriteLine($"Double is {num2}");
            //float fnum = 62;
            //Console.WriteLine($"Float is {fnum}");
            //char letter = 'A';
            //Console.WriteLine($"Char is {letter}");
            //string word = "Hello";
            //    Console.WriteLine($"String is {word}");
            //bool my = true;
            //    Console.WriteLine($"Bool is {my}");
            //Console.ReadLine();

            //9
            //Console.WriteLine("Enter the weight");
            //double weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the height");
            //double height = double.Parse(Console.ReadLine());
            //double BMI = weight / (height * height);
            //Console.WriteLine($"The BMI is {BMI}");
            //Console.ReadLine();



            //8
            //Console.WriteLine("Enter the string");
            //String input = Console.ReadLine();
            //int characters = input.Replace(" ","").Length;
            //Console.WriteLine($"number of characters is {characters}");
            //Console.ReadLine();


            //7
            //Console.WriteLine("Enter the seconds");
            //int sec = Convert.ToInt32(Console.ReadLine());
            //int min = (sec %3600)/60;
            //int hour = sec / 3600;
            //Console.WriteLine($"In seconds: {sec}");
            //Console.WriteLine($"In minutes: {min}");
            //Console.WriteLine($"In hour: {hour}");
            //Console.ReadLine();

            //6
            //Console.WriteLine("Enter the radius");
            //double radius = Convert.ToInt32(Console.ReadLine());
            //const double PI = 3.14;
            //double area = PI * radius * radius;
            //Console.WriteLine($"Area is {area}");
            //Console.ReadLine();


            //5
            //Console.WriteLine("Enter the principal Amount");
            //double principalAmount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the rate of interest");
            //double rateOfInterest = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the years");
            //int year = Convert.ToInt32(Console.ReadLine());
            //double simpleInterest = principalAmount * rateOfInterest * year;
            //Console.WriteLine($"Simple interest is {simpleInterest}");
            //Console.ReadLine();

            //4
            //Console.WriteLine("Enter the temperature:");
            //double temp = Convert.ToInt32(Console.ReadLine());
            //double fah = 0;
            //fah = (temp * 9 / 5)+ 32;
            //Console.WriteLine($"Temperature is {fah}");
            //Console.ReadLine();


            //3
            //Console.WriteLine("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum, diff, mult, div;
            //sum = num1 + num2;
            //diff = num1 - num2;
            //mult = num1 * num2;
            //Console.WriteLine($"Sum is {sum} and difference is {diff} and multiplication is {mult}");
            //if (num2 != 0)
            //{
            //div = num1 / num2;
            //Console.WriteLine($"Division is {div}");
            //}
            //else
            //{
            //Console.WriteLine($"Division is not possible");
            //Console.ReadLine();
            //}


            //2
            // Console.WriteLine("Enter your full name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age:");
            //string age = Console.ReadLine();
            //Console.WriteLine($"Hello! {name} You are {age} years old");
            //Console.WriteLine("Enter you favourite color");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello! {name} You are {age} years old and favourite color is {color} ");
            //Console.ReadLine();

            //1
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Enter the name:");
            //string username = Console.ReadLine();
            //Console.WriteLine("Have a nice day!" +username);
            // Console.ReadLine();


        }
    }
}
