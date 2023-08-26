using System.ComponentModel.DataAnnotations;

namespace TemelMvcProje.Entitys
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

    }
}
