/*
 * Onyx Domain API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.6
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
    public class ActionsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/Actions/ChangeSchedule")]
        [ValidateModelState]
        [SwaggerOperation("ActionsChangeSchedulePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsChangeSchedulePost([FromBody]ScheduleParameters body)
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
        [Route("/Actions/DataToIntegrate")]
        [ValidateModelState]
        [SwaggerOperation("ActionsDataToIntegratePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsDataToIntegratePost([FromBody]IntegrationRequest body)
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
        [Route("/Actions/GetActivityOptions")]
        [ValidateModelState]
        [SwaggerOperation("ActionsGetActivityOptionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsGetActivityOptionsGet()
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
        [Route("/Actions/GetFileUploadOptions")]
        [ValidateModelState]
        [SwaggerOperation("ActionsGetFileUploadOptionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsGetFileUploadOptionsGet()
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
        [Route("/Actions/GetReportActivityOptions")]
        [ValidateModelState]
        [SwaggerOperation("ActionsGetReportActivityOptionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsGetReportActivityOptionsGet()
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
        [Route("/Actions/RequestActivity")]
        [ValidateModelState]
        [SwaggerOperation("ActionsRequestActivityPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsRequestActivityPost([FromBody]ActivityRequest body)
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
        [Route("/Actions/RequestPerformanceReport")]
        [ValidateModelState]
        [SwaggerOperation("ActionsRequestPerformanceReportPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsRequestPerformanceReportPost([FromBody]PeriodParameter body)
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
        [Route("/Actions/SaveResearchWorksheet")]
        [ValidateModelState]
        [SwaggerOperation("ActionsSaveResearchWorksheetPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Result), description: "Success")]
        public virtual IActionResult ActionsSaveResearchWorksheetPost([FromBody]ResearchWorksheetParameterParameter body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Result));
            string exampleJson = null;
            exampleJson = "{\n  \"success\" : true,\n  \"message\" : \"message\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Result>(exampleJson)
                        : default(Result);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/Actions/ScheduledActions")]
        [ValidateModelState]
        [SwaggerOperation("ActionsScheduledActionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsScheduledActionsGet()
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
        [Route("/Actions/UpdatePosition")]
        [ValidateModelState]
        [SwaggerOperation("ActionsUpdatePositionPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsUpdatePositionPost([FromBody]PeriodParameter body)
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
        [Route("/Actions/ValidateTicker")]
        [ValidateModelState]
        [SwaggerOperation("ActionsValidateTickerPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Context), description: "Success")]
        public virtual IActionResult ActionsValidateTickerPost([FromBody]TickerData body)
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
