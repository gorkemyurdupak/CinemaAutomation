using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);

            Ignore(x => x.ConfirmPassword);

            Property(x => x.UserComment).HasMaxLength(350).IsOptional();
        }
    }
}
