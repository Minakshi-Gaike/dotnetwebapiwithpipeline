using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using JenkinCICD.Model;

namespace JenkinCICD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/state")]

        public List<State>  GetStates()
            {
                List<State> lst = new List<State>();
                
                    lst.Add(new State() { StateId = 1, StateName = "Maharashtra" });
                    lst.Add(new State() { StateId = 2, StateName = "Gujrat" });
                    lst.Add(new State() { StateId = 3, StateName = " Panjab" });
                    lst.Add(new State() { StateId = 4, StateName = "Goa" });
                    lst.Add(new State() { StateId = 5, StateName = "Kerala" });
                    return lst;
            }

            
        
    }
}
