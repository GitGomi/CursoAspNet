
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System.Data.Entity;
using System.Collections.Generic;

namespace PracticaTres.Models
{
    public class Opera
    {
        public int OperaID { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Titulo")]
        public string Title { get; set; }

        [CheckValidYear]
        public int Year { get; set; }

        [Required]
        public string Composer { get; set; }

    }

    public class CheckValidYear : ValidationAttribute {

        public CheckValidYear() {
            ErrorMessage = "Dato Incorrecto";
        }

        public override bool IsValid(object value)
        {
            int year = (int) value;
            if (year < 1598) {
                return false;
            } else {
                return true;
            }
        }
    }
}