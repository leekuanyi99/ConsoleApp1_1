// See https://aka.ms/new-console-template for more information
string str_new = "Welcome!";
string str_old = "How many days do you want to stay?";
Console.WriteLine(str_new + str_old);
int number= Convert.ToInt32(Console.ReadLine());

if(number == 0)
{
    Console.WriteLine("Thanks. I don't want stay here overnight.");
}
else
{
    Console.WriteLine("I want to stay for "+number+" days.");
}
