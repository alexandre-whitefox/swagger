/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.11
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
    public class GicsSectorsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/GicsSectors/Delete")]
        [ValidateModelState]
        [SwaggerOperation("GicsSectorsDeletePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult GicsSectorsDeletePost([FromBody]IdOnly body)
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
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/GicsSectors/List")]
        [ValidateModelState]
        [SwaggerOperation("GicsSectorsListGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult GicsSectorsListGet()
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
        [Route("/GicsSectors/Save")]
        [ValidateModelState]
        [SwaggerOperation("GicsSectorsSavePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult GicsSectorsSavePost([FromBody]IdName body)
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
