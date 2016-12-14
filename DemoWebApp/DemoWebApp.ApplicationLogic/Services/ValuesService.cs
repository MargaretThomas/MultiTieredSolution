﻿using System.Collections.Generic;
using DemoWebApp.ApplicationLogic.Interfaces;
using Nest;
using System;
using DemoWebApp.Data.Models;

namespace DemoWebApp.ApplicationLogic.Services
{
    public class ValuesService : IValues
    {
        private readonly IElasticClient _elasticClient;

        public ValuesService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public int? Get(Guid id)
        {
            var response = _elasticClient.Get<ValuesModel>(id);
            return response.Source?.Value;
        }
        public string AddValue(int value)
        {
            var id = Guid.NewGuid();
            var valuesModel = new ValuesModel
            {
                Id = id,
                Value = value
            };
            _elasticClient.Index(valuesModel);
            return id.ToString();
        }
    }
}

