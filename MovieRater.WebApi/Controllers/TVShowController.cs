using Microsoft.AspNet.Identity;
using MovieRater.Services.TVShowServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRater.WebApi.Controllers
{
    public class TVShowController : ApiController
    {
        private TVShowServices CreateTVShowService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var tvShowService = new TVShowServices(userId);
            return tvShowService;
        }
    }
}
