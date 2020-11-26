/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class BrokersApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/Brokers/Delete")]
        [ValidateModelState]
        [SwaggerOperation("BrokersDeletePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult BrokersDeletePost([FromBody]IdOnly body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Context));
            string exampleJson = null;
            exampleJson = "{ }";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Context>(exampleJson)
                        : default(Context);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/Brokers/List")]
        [ValidateModelState]
        [SwaggerOperation("BrokersListGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult BrokersListGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Context));
            string exampleJson = null;
            exampleJson = "{ }";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Context>(exampleJson)
                        : default(Context);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/Brokers/Save")]
        [ValidateModelState]
        [SwaggerOperation("BrokersSavePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult BrokersSavePost([FromBody]BrokerData body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Context));
            string exampleJson = null;
            exampleJson = "{ }";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Context>(exampleJson)
                        : default(Context);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
