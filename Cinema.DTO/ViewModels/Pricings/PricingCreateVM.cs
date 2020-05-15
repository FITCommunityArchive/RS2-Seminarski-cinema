using System.ComponentModel.DataAnnotations;

namespace Cinema.Dto.ViewModels.Pricings
{
    public class PricingCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:#,##0.00}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
    }
}
