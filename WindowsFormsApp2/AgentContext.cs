using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AgentContext: DbContext
    {
        public AgentContext() : base("DbConnectionString") { }

        public DbSet<Agent> Agents { get; set; }


    }
}
