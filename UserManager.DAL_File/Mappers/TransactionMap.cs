using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class TransactionMap : ClassMap<Transaction>
    {
        public TransactionMap()
        {
            Table("Transactions");

            Id(x => x.Id).Column("TransactionId").GeneratedBy.Native();

            Map(x => x.Amount).Not.Nullable();
            Map(x => x.Year).Not.Nullable();
            Map(x => x.Month).Not.Nullable();
            Map(x => x.Paid).Not.Nullable();
            References(x => x.Player).ForeignKey("PersonId").Cascade.All();
        }
    }
}
