using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AgentRepository
{
    public class AgentRepository : IAgentRepository
    {
        private readonly JotexDbContext _context;

        public AgentRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Include("Settings")
                                  .Where(d => d.Status)
                                  .OrderBy(d => d.OrderBy)
                                  .ToList();
        }
    }
}
