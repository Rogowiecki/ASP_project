using System.ComponentModel.DataAnnotations;

namespace Rating_ASP.Models
{
    public class Person
    {

        public string FIO { get; set; }
        public int Age { get; set; }
        public string InsuranceType { get; set; }
        public decimal MounthPayment { get; set; }
        public bool IsAlive { get; set; }

        public Person(string fIO, int age, string insuranceType, decimal mounthPayment)
        {
            FIO = fIO;
            Age = age;
            InsuranceType = insuranceType;
            MounthPayment = mounthPayment;
        }
    }
}
