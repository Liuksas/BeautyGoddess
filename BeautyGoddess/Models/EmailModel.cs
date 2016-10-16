using System.ComponentModel.DataAnnotations;
using BeautyGoddess.Utilities;

namespace BeautyGoddess.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = Constants.FieldRequireMessage)]
        public string Name { get; set; }

        [Required(ErrorMessage = Constants.FieldRequireMessage)]
        [EmailAddress(ErrorMessage = Constants.ValidEmailMessage)]
        public string Email { get; set; }

        [Required(ErrorMessage = Constants.FieldRequireMessage)]
        public string Phone { get; set; }

        [Required(ErrorMessage = Constants.FieldRequireMessage)]
        public string Message { get; set; }
    }
}