using Human_Resources_Management.ENTITIES.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.ENTITIES.Entities
{
    // [ModelMetadataType(typeof(ManagerDataTypes))]
    public class Person : BaseClass
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public DepartmansEnum DepartmansEnum { get; set; }
        public string Job { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        [ForeignKey("Employees")]
        public int? ReportsTo { get; set; }
        public virtual Person Employees { get; set; }
        public string PersonelPhoneNumber { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public GenderEnum Gender { get; set; }
        public RoleEnum RoleEnum { get; set; }
        public decimal Salary { get; set; }
        [ForeignKey("Company")]
        public int? CompanyID { get; set; }
        public virtual Company Company { get; set; }
    }
}
