using System.ComponentModel.DataAnnotations;

namespace Cinema.Dto.ViewModels.News
{
    public class NewsIndexVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [Display(Name = "Date created")]
        public string DateCreated { get; set; }

        [Display(Name = "Time created")]
        public string TimeCreated { get; set; }

        public IdentityMasterModel Author { get; set; }
        public MasterModel Type { get; set; }
    }
}
