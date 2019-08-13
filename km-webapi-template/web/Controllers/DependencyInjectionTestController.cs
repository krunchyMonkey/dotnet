using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KrunchyMonkeyTemplateWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependencyInjectionTestController : ControllerBase
    {
        private readonly IDepencyInjectionTestSdk _depencyInjectionTestSdk;

        public DependencyInjectionTestController(IDepencyInjectionTestSdk depencyInjectionTestSdk)
        {
            _depencyInjectionTestSdk = depencyInjectionTestSdk;
        }

        [HttpGet("Singleton")]
        public ActionResult<int> FetchSingletonValue()
        {
            return _depencyInjectionTestSdk.SingletonValue;
        }

        [HttpGet("Scoped")]
        public ActionResult<int> FetchScopedValue()
        {
            return _depencyInjectionTestSdk.ScopedValue;
        }

        [HttpGet("Transient")]
        public ActionResult<int> FetchTransientValue()
        {
            return _depencyInjectionTestSdk.TransientValue;
        }
    }
}