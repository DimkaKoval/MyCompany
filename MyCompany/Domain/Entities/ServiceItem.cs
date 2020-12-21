using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву послуги")]
        [Display(Name = "Назва послуги")]
        public override string Title { get; set; }

        [Display(Name = "Коротки опис")]
        public override string Subtitle { get; set; }

        [Display(Name = "повний опис")]
        public override string Text { get; set; }
    }
}
