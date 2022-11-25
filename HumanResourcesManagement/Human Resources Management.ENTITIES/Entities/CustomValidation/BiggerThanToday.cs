using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.ENTITIES.Entities.CustomValidation
{
    public class BiggerThanToday : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;
            if (date < DateTime.Now.AddDays(-(18 * 365)))
            {
                return new ValidationResult("Tarih bugünden küçük olamaz");
            }
            else
            {
                return ValidationResult.Success;
            }
           
        }

    }
}


//DateTime tarih = (DateTime)value;
//if (tarih < DateTime.Now.AddDays(-(18 * 365)))
//{
//    return new ValidationResult("18 yaşından küçükler giremez");
//}



//return ValidationResult.Success;