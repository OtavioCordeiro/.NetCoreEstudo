using Microsoft.Extensions.Configuration;
using OdeToFood.Services.Interfaces;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {


        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IConfiguration _configuration;

        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }

    }
}
