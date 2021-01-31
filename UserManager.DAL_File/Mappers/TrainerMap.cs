using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class TrainerMap : SubclassMap<Trainer>
    {
        public TrainerMap()
        {
            HasManyToMany(x => x.Teams).AsBag().ChildKeyColumn("TeamId").ParentKeyColumn("PersonId").Table("TrainerOfTeam");

            DiscriminatorValue("Trainer");
        }
    }
}
