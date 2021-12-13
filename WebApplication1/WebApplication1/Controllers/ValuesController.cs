﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Helper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        private IProjectTransactionValidateHelper projectTransactionValidateHelper;
        public ValuesController(IProjectTransactionValidateHelper projectTransactionValidateHelper)
        {
            this.projectTransactionValidateHelper = projectTransactionValidateHelper;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public bool Post([FromBody] IList<TransactionDetail> transactionDetails)
        {
            return projectTransactionValidateHelper.Validate(transactionDetails);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
