using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.AgentRepository
{
    public interface IAgentRepository
    {
        IEnumerable<Agent> GetAgents();
    }
}
