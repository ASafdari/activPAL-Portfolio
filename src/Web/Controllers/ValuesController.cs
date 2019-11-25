using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Messaging.Values.Queries;

namespace Portfolio.Web.Controllers
{
    public class ValuesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var dto = await Mediator.Send(new GetDtoValueQuery(id));

            return Ok(dto);
        }
    }
}