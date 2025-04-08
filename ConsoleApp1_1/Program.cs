// See https://aka.ms/new-console-template for more information
string str_new = "Welcome! What is your name?";
Console.WriteLine(str_new);
string name = Console.ReadLine();
string str_old = "How long do you want to stay here?";
Console.WriteLine("Ok,"+name+". "+str_old);
int number= Convert.ToInt32(Console.ReadLine());

if(number == 0)
{
    Console.WriteLine("Thanks. I don't want stay here and I will go home tonight.");
}
else
{
    Console.WriteLine("I want to stay here for "+number+" days.");
}
