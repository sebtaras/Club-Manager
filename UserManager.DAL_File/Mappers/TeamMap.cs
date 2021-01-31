using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    class TeamMap : ClassMap<Team>
    {
        public TeamMap()
        {
            Table("Team");

            Id(x => x.Id).Column("TeamId").GeneratedBy.Native();

            Map(x => x.Name).Length(20).Not.Nullable();
            Map(x => x.LowerAge).Not.Nullable();
            Map(x => x.UpperAge).Not.Nullable();
            HasMany(x => x.Players);
            HasManyToMany(x => x.Trainers).AsBag().ParentKeyColumn("TeamId").ChildKeyColumn("PersonId").Table("TrainerOfTeam");
            HasMany(x => x.Trainings);
        }
    }
}
