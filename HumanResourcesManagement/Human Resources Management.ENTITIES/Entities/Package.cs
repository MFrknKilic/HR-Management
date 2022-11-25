using Human_Resources_Management.ENTITIES.Entities.CustomValidation;
using Human_Resources_Management.ENTITIES.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.ENTITIES.Entities
{
    public class Package : BaseClass 
    {
        public string PackageName { get; set; }
        public int NumberOfUsers { get; set; }
        public int ValidityDay { get; set; }
        [DataType(DataType.Date)]
        [BiggerThanToday]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [BiggerThanToday]
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public PriceUnit PriceUnit { get; set; }
        public string Description { get; set; }
        public virtual List<Company> Company { get; set; }

        
    }
}
