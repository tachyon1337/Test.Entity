using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Test.Entity.Models;

namespace Test.Entity
{
    public class DbSampleContext : DbContext
    {
        public DbSet<SampleModel> SampleModel { get; set; }
    }
}