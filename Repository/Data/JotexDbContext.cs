using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }
    }
}
