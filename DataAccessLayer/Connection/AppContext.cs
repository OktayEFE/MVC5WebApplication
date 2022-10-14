using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Connection
{
    public class AppContext:DbContext
    {
        public DbSet<CountryInfo> CountryInfos { get; set; }
    }
}
