/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework 7
 * 	Project name: Methods Continued
 *--------------------------------------------------------------------
 * Author’s name and email:	 Anthony Friday
 *          Course-Section: CSCI 1250-001
 *           Creation Date:	 4/2/2022	
 * -------------------------------------------------------------------
 */
CountSheep(0);
XO("xoxo");
XO("xooxx");
XO("abbabba");
XO("xccx");


static void CountSheep(int s)
{
    int totalSheep = 0;
    Console.Write("How many sheep do you want to count? ");
    s = Convert.ToInt32(Console.ReadLine());
    
    for(int i = 1; i <= s; i++)
    {
        totalSheep += s/s;
        Console.WriteLine($"{totalSheep} sheep...");
    }
}    

static void XO(string entry)
{
    string[] x = entry.Split("x");
    string[] o = entry.Split("o");

    if(x.Length == o.Length)
    {
        Console.WriteLine("True");
    }
    else if(x.Length != o.Length)
    {
        Console.WriteLine("False");
    }
    
}