using System;
using Knowledge_Check_2;
using static Knowledge_Check_2.WoodSpecies;




Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Oak>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var oak = new Oak();

    Console.WriteLine("Enter the type of wood: ");

    oak.Type = Console.ReadLine();

    Console.WriteLine("Enter the Grain: ");

    oak.Grain = Console.ReadLine();

    



    recordList.Add(oak);


}

// Print out the list of records using Console.WriteLine()

foreach (Object o in oak)
{
    Console.WriteLine(o);
}