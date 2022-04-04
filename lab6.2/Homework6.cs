/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab 6
 * 	Project name: Methods
 *--------------------------------------------------------------------
 * Author’s name and email:	 Anthony Friday				
 *          Course-Section: 1250-001
 *           Creation Date:	 3/23/2022		
 * -------------------------------------------------------------------
 */

ShowCharacter("", 0);
Console.WriteLine();
CalculateRetail(0, 0);
Console.WriteLine();
Console.WriteLine("The conversion of farhenheit to celsius from 80 to 100 degrees is: ");
for(int i = 80; i <= 100; i++)
{
    Console.Write(Celsius(i) );
}
Console.WriteLine();
IsPrime(0);

static void ShowCharacter(string input, int letter)
{
    Console.Write("Enter your hometown: ");
    input = Console.ReadLine();
    Console.Write("Enter the number position of the letter you want: ");
    letter = Convert.ToInt32(Console.ReadLine());
    var spot = (input[letter - 1]);
    Console.WriteLine($"The letter {spot} is in the number {letter} spot in {input}. ");
}

static void CalculateRetail(double wholeSale, double markUp)
{
    Console.Write("Enter the wholesale price: ");
    wholeSale = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the mark up percentage: ");
    markUp = Convert.ToDouble(Console.ReadLine());
    double percentage = (wholeSale * (markUp / 100));
    double retail = (wholeSale + percentage);
    Console.WriteLine($"With a whole sale price of {wholeSale.ToString("C")} and a mark up precentage of {markUp}%, the retail price is {retail.ToString("C")}. ");
}

static double Celsius(double f)
{
    double fahrenheit = (5.00/9.00 * (f - 32.00));
    return(Math.Round(fahrenheit, 2));
}

static void IsPrime(int n)
{
   Console.Write("Enter a whole number: "); 
 n = Convert.ToInt32(Console.ReadLine());
 int x = 0;
 for(int i = 1; i <= n; i++)
 {
     if (n % i == 0)
     {
         x++;
     }
 }
 if (x == 2)
 {
      Console.Write($"{n} is a prime number. ");
 }  
 else if(x != 2)   
   {
    Console.Write($"{n} is not a prime number. ");
   } 
}