﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using xhdbneService.DataObjects;
using xhdbneService.Models;

namespace xhdbneService.Controllers
{
    public class JourneyController : TableController<Journey>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            DataContext context = new DataContext();
			DomainManager = new EntityDomainManager<Journey>(context, Request, Services);
        }

        // GET tables/Journey
		public IQueryable<Journey> GetAllJourneys()
        {
            return Query();
        }

        // GET tables/Journey/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public SingleResult<Journey> GetJourney(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Journey/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task<Journey> PatchJourney(string id, Delta<Journey> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Journey
		public async Task<IHttpActionResult> PostJourney(Journey item)
        {
			Journey current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Journey/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteJourney(string id)
        {
            return DeleteAsync(id);
        }
    }
}