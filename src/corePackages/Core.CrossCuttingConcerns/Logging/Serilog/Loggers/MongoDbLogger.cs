using Core.CrossCuttingConcerns.Logging.Serilog.ConfigurationModels;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Loggers
{
    public class MongoDbLogger : LoggerServiceBase
    {
        private IConfiguration _configuration;
        public MongoDbLogger(IConfiguration configuration)
        {
            _configuration = configuration;

            var logConfig = configuration.GetSection("SeriLogConfigurations:MongoDbConfiguration")
                .Get<MongoDbConfiguration>();

            Logger = new LoggerConfiguration()
                .WriteTo.MongoDB(logConfig.ConnectionString, collectionName: logConfig.Collection)
                .CreateLogger();
        }
    }
}
