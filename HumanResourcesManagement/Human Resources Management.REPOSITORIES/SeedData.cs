using Human_Resources_Management.ENTITIES;
using Human_Resources_Management.REPOSITORIES.Context;
using Human_Resources_Management.ENTITIES.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human_Resources_Management.ENTITIES.Entities;

namespace Human_Resources_Management.REPOSITORIES
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviseScope = app.ApplicationServices.CreateScope())
            {
                HRMDbContext context = serviseScope.ServiceProvider.GetService<HRMDbContext>();

                context.Database.Migrate();

                if (!context.Employees.Any())
                {
                    // context.Packages.AddRange(
                    //new Package()
                    //{
                    //    PackageName = "Small",
                    //    NumberOfUsers = 50,
                    //    ValidityDay = 60,
                    //    StartDate = new DateTime(1990, 11, 10),
                    //    EndDate = new DateTime(1999, 11, 10),
                    //    IsActive = true,
                    //    Price = 50000,
                    //    PriceUnit = PriceUnit.TL,
                    //    Description = "Furkanın Paketlerini alın"
                    //}
                    // );

                    // context.Companies.AddRange(
                    //new Company()
                    //{

                    //    CompanyName = "Çanakkale Spor",
                    //    CorporateName = "LTD.ŞTİ",
                    //    CompanyAddress = "Dardanel Sokak Çıkmazı",
                    //    CompanyMail = "Darnael@gma.com",
                    //    CompanyPhoneNumber = "02862125212",
                    //    TaxNumber = "2900003512",
                    //    TaxAdministration = "Barbaros",
                    //    KindOfCorporation = "Balık İşletmesi",
                    //    PackageID = 1
                    //}
                    // );

                   // context.Employees.AddRange(
                   //new Person() { FirstName = "BaaBoss", MiddleName = "Nuray", LastName = "Marhan", MaidenName = "Medusa", PhotoName = "gga.png", DepartmansEnum = DepartmansEnum.IK, Job = "Çellik kapıcı", HireDate = new DateTime(1990, 11, 10), Salary = 35000, Address = "Çanakkale Çnakkale MAhallesi Mami Soakak NO:2 Ayvacık", PersonelPhoneNumber = "5347746502", Mail = "simple.simple@hr.com", Gender = GenderEnum.Kadın, BirthDate = new DateTime(1994, 11, 27), CompanyPhoneNumber = "2125424201", CompanyID = 1,RoleEnum=RoleEnum.SirketYoneticisi}
                   // );


                }
                
                context.SaveChanges();
            }
        }
    }
}
