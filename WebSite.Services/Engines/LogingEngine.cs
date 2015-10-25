using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.Services.Infrastructure;

namespace WebSite.Services.Engines
{
    public class LogingEngine
    {
        private readonly ILoging _logger;

        public LogingEngine(ILoging logger)
        {
            this._logger = logger;
        }

        public string Log(string message)
        {
            _logger.Open();
            _logger.Log(message);
            _logger.Close(_logger.LogFileName);
            return message;
        }
    }
}