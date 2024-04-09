namespace Rating_ASP.Models
{
    public class PersonsStorage
    {
        public static List<Person> Persons { get; set; } = new List<Person>
        {
             new Person("Андрей Андреев Андреевич", 21, "по безмозглию", 1000),
             new Person("Андрей Андреев Андреевич", 21, "по безмозглию", 1000),
             new Person("Андрей Андреев Андреевич", 21, "по безмозглию", 1000),
             new Person("Андрей Андреев Андреевич", 21, "по безмозглию", 1000),
             new Person("Андрей Андреев Андреевич", 21, "по безмозглию", 1000),
        };
    }
}
