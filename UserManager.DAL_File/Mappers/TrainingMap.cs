using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class TrainingMap : ClassMap<Training>
    {
        public TrainingMap()
        {
            Table("Training");

            Id(x => x.Id).Column("TrainingId").GeneratedBy.Native();

            Map(x => x.StartTime).Not.Nullable();
            Map(x => x.EndTime).Not.Nullable();
            References(x => x.Team).Cascade.All();
            References(x => x.Trainer).Cascade.All();
        }
    }
}
