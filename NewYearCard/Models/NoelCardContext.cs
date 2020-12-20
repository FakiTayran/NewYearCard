using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewYearCard.Models
{
    public class NoelCardContext :DbContext
    {
        public NoelCardContext() : base ("name=NoelCardDbContext")
        {

        }

        public DbSet<Card> Cards { get; set; }
    }
}