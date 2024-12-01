using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEndMVCDDD.MVC.ViewModels
{
    public class Client
    {
        //Representação de Client
        // ViewModels não devem ter comportamentos, apenas representações
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Please, write down the name on the field.")]
        [MaxLength(150, ErrorMessage = "{0} characters limit.")]
        [MinLength(2, ErrorMessage = "At least {0} characters are required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, write down the last name on the field.")]
        [MaxLength(150, ErrorMessage = "{0} characters limit.")]
        [MinLength(2, ErrorMessage = "At least {0} characters are required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please, write down the E-mail")]
        [MaxLength(100, ErrorMessage = "{0} characters limit.")]
        [EmailAddress(ErrorMessage = "Write down a valid E-mail.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime SubscriptionDate { get; set; }
        public bool IsActive { get; set; }
        //public virtual IEnumerable<Product> Products { get; set; }
    }
}
