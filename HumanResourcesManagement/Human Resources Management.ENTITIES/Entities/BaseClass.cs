using Human_Resources_Management.ENTITIES.Entities;
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

namespace Human_Resources_Management.ENTITIES
{
   
    public class BaseClass
    {
        public int ID { get; set; }
      
        public string PhotoName { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
       
    }
}
