using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.ENTITIES.Entities
{
    public class Company :BaseClass
    {
      //  public int ID { get; set; }
        public string CompanyName { get; set; }
        public string CorporateName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string KindOfCorporation { get; set; }
        public virtual List<Person> People { get; set; }

        [ForeignKey("Package")]
        public int PackageID { get; set; }
        public Package Package { get; set; }

    }
}
