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
    public class PortfolioReportApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/PortfolioReport/Download")]
        [ValidateModelState]
        [SwaggerOperation("PortfolioReportDownloadPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(HttpResponseMessage), description: "Success")]
        public virtual IActionResult PortfolioReportDownloadPost([FromBody]Parameters body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(HttpResponseMessage));
            string exampleJson = null;
            exampleJson = "{\n  \"requestMessage\" : {\n    \"headers\" : [ null, null ],\n    \"method\" : {\n      \"method\" : \"method\"\n    },\n    \"options\" : {\n      \"key\" : \"\"\n    },\n    \"requestUri\" : \"http://example.com/aeiou\",\n    \"versionPolicy\" : 9,\n    \"properties\" : {\n      \"key\" : \"\"\n    }\n  },\n  \"headers\" : [ null, null ],\n  \"reasonPhrase\" : \"reasonPhrase\",\n  \"trailingHeaders\" : [ null, null ],\n  \"isSuccessStatusCode\" : true,\n  \"version\" : {\n    \"major\" : 0,\n    \"minor\" : 6,\n    \"build\" : 1,\n    \"majorRevision\" : 5,\n    \"minorRevision\" : 2,\n    \"revision\" : 5\n  },\n  \"content\" : {\n    \"headers\" : [ {\n      \"value\" : [ \"value\", \"value\" ],\n      \"key\" : \"key\"\n    }, {\n      \"value\" : [ \"value\", \"value\" ],\n      \"key\" : \"key\"\n    } ]\n  },\n  \"statusCode\" : 7\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<HttpResponseMessage>(exampleJson)
                        : default(HttpResponseMessage);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/PortfolioReport/List")]
        [ValidateModelState]
        [SwaggerOperation("PortfolioReportListPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult PortfolioReportListPost([FromBody]Parameters body)
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
