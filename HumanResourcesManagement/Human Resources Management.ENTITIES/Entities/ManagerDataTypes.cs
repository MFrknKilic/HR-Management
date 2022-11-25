using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.ENTITIES
{
    public class ManagerDataTypes
    {

        //[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "3 ila 50 Karakter arası")]
        //[RegularExpression("[A-Z]" + "[a-z]", ErrorMessage = "Sadece Harf girişi yapınız")]

        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "3 ila 50 Karakter arası")]
        //[RegularExpression("[A-Z]" + "[a-z]", ErrorMessage = "Sadece Harf girişi yapınız")]

        //public string LastName { get; set; }

        //[StringLength(50, MinimumLength = 3, ErrorMessage = "3 ila 50 Karakter arası")]
        //[RegularExpression("[A-Z]" + "[a-z]", ErrorMessage = "Sadece Harf girişi yapınız")]

        //public string MiddleName { get; set; }

        //[StringLength(50, MinimumLength = 3, ErrorMessage = "3 ila 50 Karakter arası")]
        //[RegularExpression("[A-Z]" + "[a-z]", ErrorMessage = "Sadece Harf girişi yapınız")]
        //public string MaidenName { get; set; }


        //[StringLength(50, MinimumLength = 3, ErrorMessage = "3 ila 50 Karakter arası")]
        //[RegularExpression("[A-Z]" + "[a-z]", ErrorMessage = "Sadece Harf girişi yapınız")]

        //public string Job { get; set; }

        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "10 ila 250 Karakter arası")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Mail adresi boş bırakılamaz")]
        //[DataType(DataType.EmailAddress)]
        //[MaxLength(50)]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Mail Formatını Doğru Giriniz")]
        //public string Mail { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{11})$", ErrorMessage = "Telefon Numarasını Doğru Formatta Giremediniz:((")]
        public string PersonelPhoneNumber { get; set; }


        [Required(ErrorMessage = "Lütfen Fotoğraf Seçiniz")]
        public string Photo { get; set; }
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{11})$", ErrorMessage = "Telefon Numarasını Doğru Formatta Giremediniz:((")]
        //public string CompanyPhoneNumber { get; set; }

        //[Range(5000, 120000, ErrorMessage = "Yasal bir aralıkta maaş bilgisini giriniz")]
        //[RegularExpression(@"^\(?([0-9]{7})$", ErrorMessage = "Sadece rakam girişi yapınız")]
        //public decimal Salary { get; set; }

    }
}
