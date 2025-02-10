
int bill = 0;    
    
Console.WriteLine("Welcome to Python Pizza Deliveries!");
while (true)
{
    Console.WriteLine("What size pizza do you want? press capital S, M or L: ");
    string PizzaSize = Console.ReadLine();
    if (PizzaSize == "S")
    {
        Console.WriteLine("You choose " + PizzaSize + " size");
        bill = 8;
        break;
    }

    if (PizzaSize == "M")
    {
        Console.WriteLine("You choose " + PizzaSize + " size");
        bill = 12;
        break;
    }

    if (PizzaSize == "L")
    {
        Console.WriteLine("You choose " + PizzaSize + " size");
        bill = 16;
        break;
    }
    else
    {
        Console.WriteLine("Wrong input, please retry");
        continue;
    }
}
Console.WriteLine("At the moment you are spending " + bill + " $");

while (true)
{
    Console.WriteLine("Do you want pepperoni added to your pizza? Press Y or N: ");
    string Pepperoni = Console.ReadLine();
    
    if (Pepperoni == "Y")
    {
        Console.WriteLine("Ok pepperoni were added to your pizza..");
        bill +=2;
        break;
    }
    if (Pepperoni == "N")
    {
        Console.WriteLine("Ok we are skipping pepperoni..");
        break;
    }
    else
    {
        Console.WriteLine("Wrong input, please retry");
        continue;
    }
}
Console.WriteLine("At the moment you are spending " + bill + " $");
while (true)
{
    Console.WriteLine("Do you want extra cheese added to your pizza? Press Y or N: ");
    string Cheese = Console.ReadLine();
    
    if (Cheese == "Y")
    {
        Console.WriteLine("Ok extra cheese for your pizza..");
        bill +=1;
        break;
    }
    if (Cheese == "N")
    {
        Console.WriteLine("Ok no extra cheese..");
        break;
    }
    else
    {
        Console.WriteLine("Wrong input, please retry");
        continue;
    }
}
Console.WriteLine("Ok, the total bill for your pizza is : " + bill + " $");



// elif size == "M":
    // bill = (int(15))
    // break
    // elif size == "L":
    // bill = (int(25))
    // break
    // else : print ("Wrong input, please retry ..")
    // continue
    

// #Start
//
// print("Welcome to Python Pizza Deliveries!")
//
// #Define bill
//
// bill = 0
//
// #get the size
// while True:
// size = input("What size pizza do you want? press capital S, M or L: ")
// if size == "S":
// bill =(int(11))
// break
// elif size == "M":
// bill = (int(15))
// break
// elif size == "L":
// bill = (int(25))
// break
// else : print ("Wrong input, please retry ..")
// continue
//
// #pepperoni option
//
// while True:
// pepperoni = input("Do you want pepperoni on your pizza? Y or N: ")
// if pepperoni == "N":
// bill = bill
// break
// elif pepperoni == "Y":
// bill += 2
// break
// else: print ("Wrong input, please retry .. we need to know if you want pepperoni on pizza NOW !")
// continue
//
// #extra cheese
//
// while True:
// cheese = input("Do you want extra cheese on your pizza? Y or N: ")
// if cheese == "N":
// bill = bill
// break
// elif cheese == "Y":
// bill += 1
// break
// else: print ("Wrong input, please retry .. we need to know if you want EXTRA cheese on pizza RIGHT NOW !")
// continue
//
// #Total
//
// print(f"Your total bill is {bill} $ , NOW GTFO of HERE !")