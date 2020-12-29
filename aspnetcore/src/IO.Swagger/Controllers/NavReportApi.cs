/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.7
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
    public class NavReportApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/NavReport/Filters")]
        [ValidateModelState]
        [SwaggerOperation("NavReportFiltersGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult NavReportFiltersGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Context));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : \"\",\n  \"success\" : true,\n  \"message\" : \"message\"\n}";
            
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
        [Route("/NavReport/List")]
        [ValidateModelState]
        [SwaggerOperation("NavReportListPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult NavReportListPost([FromBody]NavParameters body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Context));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : \"\",\n  \"success\" : true,\n  \"message\" : \"message\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Context>(exampleJson)
                        : default(Context);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
