using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.AgentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Models;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class AgentViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAgentRepository _agentRepository;

        public AgentViewComponent(IMapper mapper,
                                  IAgentRepository agentRepository)
        {
            _mapper = mapper;
            _agentRepository = agentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var agent = _agentRepository.GetAgents();

            var model = _mapper.Map<IEnumerable<Agent>, IEnumerable<AgentViewModel>>(agent);

            return View(model);
        }
    }
}
