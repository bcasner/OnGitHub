using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ApiServer.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiServer.Controllers
{
	[Route("api/[controller]")]
	public class TrailsController : Controller
	{
		private readonly List<Trail> Trails = new List<Trail>
			{
				new Trail { TrailId = 1, Name = "Mission Bay" },
				new Trail { TrailId = 2, Name = "Memorial Loop" },
				new Trail { TrailId = 3, Name = "Katy Trail" }
			};

		// GET: api/values
		[HttpGet]
		public IEnumerable<Trail> Get()
		{
			return Trails;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public Trail Get(int id)
		{
			return Trails.ElementAt(id);
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]Trail value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]Trail value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
