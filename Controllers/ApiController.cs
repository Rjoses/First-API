using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WEBAPI_ASP.NET_CORE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Candidate")]
        public Candidate Candidete()
        {
            var candidate = new Candidate()
            {
                Id = "132548",

                Name = "Jõao",

                Email = "Jõao@gmail.com",

                Phone = "3546-8741",

                LinkedinProfile = "Jõao-José",

                Skills = new List<string>()
                {
                    "Node",
                    "Java",
                    "React"
                },

                Languages = new List<string>()
                {
                    "Português",
                    "Espanhol",
                    "Inglês",
                },

                Experiences = new List<string>()
                {
                    "5 anos Front end enginner jr. - TrendFly ",
                },

                CompanyDeny = new List<string>()
                {
                    "Nenhuma",
                },

                JobsDeny = new List<string>()
                {
                    "Apenas o que estiver fora da minha área de conhecimento"
                },
            };

            return candidate;
        }        
    }
}

