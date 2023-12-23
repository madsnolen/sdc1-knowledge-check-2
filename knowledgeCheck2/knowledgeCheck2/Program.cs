using knowledgeCheck2;
Console.WriteLine("WELCOME TO BUILDING YOUR OWN DOG PORTAL\n");
    Console.WriteLine("How many dogs do you want to add? ");
    var numberOfRecords = int.Parse(Console.ReadLine()); // taking the user input for how many they want to add within the list of dogs

    var recordList = new List<Dog>();  // list of Dog
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var dog = new Dog();

    Console.WriteLine("Enter the name of your dog: "); // asking user to input name of dog
    dog.Name = Console.ReadLine(); // recieving string - Name of the dog

    Console.WriteLine("How Old is this dog? Enter Age: "); // asking user to input age of dog
    dog.Age = int.Parse(Console.ReadLine()); // recieving int - Age of the dog

    Console.WriteLine("Enter the type of Breed: "); // asking user to input breed type (string)
    dog.DogBreed = Console.ReadLine(); // recieving string - DogBread


    recordList.Add(dog); // in the recordList in the loop for how many the user wants to input - add the Dog to the list
}

    // Print out the list of records using Console.WriteLine()
    foreach (var Dog in recordList) // using foreach loop to print out every dog. for each Dog in the recordList
    {
        Console.WriteLine("\n************DOG**************\n");
        Console.WriteLine($"Name:      {Dog.Name}");
        Console.WriteLine($"Age:       {Dog.Age}");
        Console.WriteLine($"Dog Type: {Dog.DogBreed}");
        Console.WriteLine("\n*****************************");
        Console.WriteLine();
    }
    

Console.ReadKey(); // I added this at the end so I can see my printed results and have an input to not have program shut down

