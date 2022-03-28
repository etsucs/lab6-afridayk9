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

ShowCharacter("Portsmouth", 4);
CalculateRetail(10.00 , 50);
Celsius(96.00);
IsPrime(7);

static void ShowCharacter(string input, int letter)
{
    Console.WriteLine(input[letter - 1]);
}

static void CalculateRetail(double wholeSale, double markUp)
{
    double percentage = (wholeSale * (markUp / 100));
    Console.WriteLine(wholeSale + percentage);
}

static void Celsius(double f)
{
    double Fahrenheit = (5.00/9.00 * (f - 32.00));
    Console.WriteLine(Fahrenheit);
}

static void IsPrime(int n)
{
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
    Console.Write($"{n} is not a prime number. ");
 
 
} 
