Console.WriteLine("Enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):");
char userGender = Char.Parse(Console.ReadLine());

string greeting = "";

if(userGender == 'f')
{
    greeting = "Ms.";
} 

else if (userGender == 'm')
{
    greeting = "Mr.";
}

else 
{
    greeting = "";
}


Console.WriteLine($"Hello, {greeting} {lastName}!");

Console.WriteLine("Enter your year of birth:");

int usersYB = Int32.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;

int userAge = currentYear - usersYB;

//Console.WriteLine($"Current year: {currentYear}");

//int userAge = Int32.Parse(Console.ReadLine());


if (userAge >= 13)
{
    Console.WriteLine($"You are {userAge} - old enough to have an account");
}
else
{
    Console.WriteLine($"You are {userAge} - too young to have an account");
}