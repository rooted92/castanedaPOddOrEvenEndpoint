//Pedro Castaneda
//10-25-2022
//Odd Or Even - Endpoint
//Create a controller and endpoint where a function if the users number input is odd or even.
//Peer Review by; 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPOddOrEvenEndpoint.Controllers
{
    [Route("[controller]")]
    public class OddOrEvenController : Controller
    {
        [HttpGet]
        [Route("OddEven/{number}")]
        public string OddEven(string number)
        {
            int isNumber = 0;
            bool isValid = Int32.TryParse(number, out isNumber);
            string result = $"{isNumber} is odd";
            if(!isValid)
            {
                result = "Invalid Entry";
            }
            else if(isNumber % 2 == 0)
            {
                result = $"{isNumber} is even";
            }
            return result;
        } 
    }
}