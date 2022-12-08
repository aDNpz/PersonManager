
namespace PersonManager.Logic.Models
{
    public class Person : ModelObject, ICloneable
    {
        public Person()
        {

        } 
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;

        public string Fullname => $"{Firstname} {Lastname}";

        public Person Clone()
        {
            return new Person
            {
                Id = Id,
                Firstname = Firstname,
                Lastname = Lastname,
            };
        }

        object ICloneable.Clone()
        {
            return new Person
            {
                Id = Id,
                Firstname = Firstname,
                Lastname = Lastname,
            };
        }
    }
}
