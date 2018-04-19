using _DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataAccessLayer
{
    public class CrowdNetDBContext : DbContext
    {
        public DbSet<WootModel> wootModels { get; set; }
    }
}
