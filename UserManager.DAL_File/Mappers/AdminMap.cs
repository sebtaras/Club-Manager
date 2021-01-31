using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class AdminMap : SubclassMap<Admin>
    {
        public AdminMap()
        {
            DiscriminatorValue("Admin");
        }
    }
}
