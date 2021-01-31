using ClubManager.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.DAL_File.Mappers
{
    public class PlayerMap : SubclassMap<Player>
    {
        public PlayerMap()
        {
            Map(x => x.Age);
            References(x => x.Team).Cascade.All();
            HasMany(x => x.Transactions).AsBag().Table("TransactionOfPlayer");

            DiscriminatorValue("Player");
        }
    }
}
