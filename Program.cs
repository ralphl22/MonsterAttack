// Puts this as the title of the program in the console until the user inputs something and the program ends 

Console.Title = "Monster Attack";

// Declares variables for the monster's HP and AP and initializes a pre-set value 

double monsterHealthPoint = 20;
double monsterArmorPoint = 15;

// Shows what the starting HP and AP are for the monster


Console.WriteLine($"A monster appears with {monsterHealthPoint} HP and {monsterArmorPoint} AP!");
Console.WriteLine("For how much HP do you want to damage the monster?"); // Input any number you want, including decimals


// Converts any number that you input from a string into a double so that it can also accept decimal numbers


string damagePointtext = Console.ReadLine();
double damagePointNumber = Convert.ToDouble(damagePointtext);

// The damage that you do subtracts from the monster's HP and AP

double currentMonsterHealthPoint = monsterHealthPoint - damagePointNumber;
double currentMonsterArmorPoint = monsterArmorPoint - damagePointNumber;

// Current monster's HP and AP is displayed, and a beep is used as user feedback

Console.WriteLine($"You strike the monster with your sword. It has {currentMonsterHealthPoint} HP and {currentMonsterArmorPoint} AP!");
Console.Beep(400, 1000);

// If the monster's HP and AP are both <=0 then it is dead

if (currentMonsterHealthPoint <= 0 && currentMonsterArmorPoint <= 0)
    Console.WriteLine("The monster is dead! Good job!");

// Otherwise the user can try again until the monster is dead. Requires program to be rerurn. 

else
    Console.WriteLine("The monster isn't dead yet! Try again!");