
using System.Collections.Generic;

namespace WEBAPI_ASP.NET_CORE
{
    public class Candidate
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string LinkedinProfile { get; set; }

        public IList<string>? Skills { get; set; }

        public IList<string>? Languages { get; set; }

        public IList<string>? Experiences { get; set; }

        public IList<string>? CompanyDeny { get; set; }

        public IList<string>? JobsDeny { get; set; }

    }
   
} 
