using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEndMVCDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key] 
        public int ProductId { get; set; }

        [Required (ErrorMessage = "Please, write down the product's name.")]
        [MaxLength(250, ErrorMessage = "{0} characters limit.")]
        [MinLength(2, ErrorMessage = "At least {0} characters are required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, write down a price for the product.")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal Price { get; set; }

        [DisplayName("Is the product avaliable?")]
        public bool IsAvaliable { get; set; }
        public int ClientId { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}
