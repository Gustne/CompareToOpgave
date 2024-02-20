namespace Models
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"id: {this.Id}, Name: {this.Name}, Age: {this.Age}";
        }

    }
}