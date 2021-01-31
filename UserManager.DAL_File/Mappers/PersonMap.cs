using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");

            Id(x => x.Id).Column("PersonId").GeneratedBy.Native();

            Map(x => x.FirstName).Length(20).Not.Nullable();
            Map(x => x.LastName).Length(20).Not.Nullable();
            Map(x => x.Password).Length(50).Not.Nullable();
            Map(x => x.Email).Length(50).Not.Nullable();
            Map(x => x.Verified).Not.Nullable();

            DiscriminateSubClassesOnColumn("Type");
        }
    }
}
