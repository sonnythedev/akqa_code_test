using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using PatientScheduleBackend.Models;
using PatientScheduleBackend.Services;

namespace PatientScheduleBackend.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ScheduleController : ApiController
    {

        [HttpGet]
        [Route("api/providers")]
        public IEnumerable<Provider> GetProviders()
        {
            return GenerateProviders.generateProviders();

        }

        [HttpGet]
        [Route("api/schedule/{providerId}")]
        public Schedule GetScheduleForProvider(int providerId)
        {
            return GenerateSchedule.generateSchedule(providerId);

        }
    }
}
