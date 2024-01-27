using System.ComponentModel.DataAnnotations;

namespace webAPI2
{
    public class MEmployee
    {
        [Key]
        public int EmpId {get; set;}
        public string? Name {get; set;}
        public string? Email {get; set;}
        public string? Phone {get; set;}
        public string? CPF {get; set;}
        public DateOnly? birthDate {get; set;}
    }
}