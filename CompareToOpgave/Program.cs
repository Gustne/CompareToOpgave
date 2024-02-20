


using Models;

Person[] people = new Person[4];

// Tilføj personer til arrayet
people[0] = new Person { Id = 1, Name = "Alice", Age = 30 };
people[1] = new Person { Id = 2, Name = "Bob", Age = 15 };
people[2] = new Person { Id = 3, Name = "Charlie", Age = 35 };
people[3] = new Person { Id = 4, Name = "Diana", Age = 32 };



foreach (Person p in people)
{
    Console.WriteLine(p);
}


Array.Sort(people);


Console.WriteLine(  );
foreach (Person p in people)
{
    Console.WriteLine(p);
}
