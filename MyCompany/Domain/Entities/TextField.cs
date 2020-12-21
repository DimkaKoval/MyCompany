using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки")]
        public override string Title { get; set; } = "інформаційна сторінка";

        [Display(Name = "Наповнення сторінки")]
        public override string Text { get; set; } = "Текст яким наповнює адмін";
    }
}
