using knowledgeCheck2;

Console.WriteLine("How many dogs do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Dog>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var dog = new Dog();

    Console.WriteLine("Enter the name of your dog: ");
    dog.Name = Console.ReadLine();

    Console.WriteLine("How Old is this dog? Enter Age: ");
    dog.Age = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the type of Breed: ");
    dog.DogBreed = Console.ReadLine();


    recordList.Add(dog);
}

// Print out the list of records using Console.WriteLine()
foreach (var Dog in recordList)
{
    Console.WriteLine("*****************************");
    Console.WriteLine($"Name:      {Dog.Name}");
    Console.WriteLine($"Age:       {Dog.Age}");
    Console.WriteLine($"Dog Type: {Dog.DogBreed}");
    Console.WriteLine();
}

