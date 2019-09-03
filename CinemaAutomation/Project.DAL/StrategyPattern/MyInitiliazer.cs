using Bogus.DataSets;
using Project.DAL.Context;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
   public class MyInitiliazer:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                AppUser ap = new AppUser();
                ap.UserName = new Internet("tr").UserName();
                ap.Password = new Internet("tr").Password();
                ap.Email = new Internet("tr").Email();

                context.AppUsers.Add(ap);
            }

            context.SaveChanges();

            for (int i = 1; i < 11; i++)
            {
                AppUserProfile apd = new AppUserProfile();
                apd.ID = i; //Birebir ilişkiden dolayı ID'leri bu şekilde verildi.
                apd.UserFirstName = new Name("tr").FirstName();
                apd.UserLastName = new Name("tr").LastName();
                apd.Address = new Address("tr").Locale;
                apd.Phone = new PhoneNumbers("tr").Locale;

                context.AppUserProfiles.Add(apd);
            }

            context.SaveChanges();

            
        }
    }
}
