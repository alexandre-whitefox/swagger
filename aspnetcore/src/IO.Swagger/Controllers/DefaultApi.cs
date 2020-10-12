/*
 * Onyx Integrations
 *
 * Onyx APIs for integrations
 *
 * OpenAPI spec version: 1.0.0
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
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">data descripted and sent for processing</response>
        [HttpPost]
        [Route("/bloomberg/decrypt")]
        [ValidateModelState]
        [SwaggerOperation("BloombergDecryptPost")]
        public virtual IActionResult BloombergDecryptPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">data processed</response>
        [HttpPost]
        [Route("/bloomberg/process")]
        [ValidateModelState]
        [SwaggerOperation("BloombergProcessPost")]
        public virtual IActionResult BloombergProcessPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">notifications activated</response>
        [HttpPost]
        [Route("/email/build")]
        [ValidateModelState]
        [SwaggerOperation("EmailBuildPost")]
        public virtual IActionResult EmailBuildPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">notifications activated</response>
        [HttpPost]
        [Route("/email")]
        [ValidateModelState]
        [SwaggerOperation("EmailPost")]
        public virtual IActionResult EmailPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">file generated</response>
        [HttpPost]
        [Route("/file/generate")]
        [ValidateModelState]
        [SwaggerOperation("FileGeneratePost")]
        public virtual IActionResult FileGeneratePost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">file saved</response>
        [HttpPost]
        [Route("/file/save")]
        [ValidateModelState]
        [SwaggerOperation("FileSavePost")]
        public virtual IActionResult FileSavePost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">log recorded</response>
        [HttpPost]
        [Route("/log")]
        [ValidateModelState]
        [SwaggerOperation("LogPost")]
        public virtual IActionResult LogPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">report saved and sent</response>
        [HttpPost]
        [Route("/report")]
        [ValidateModelState]
        [SwaggerOperation("ReportPost")]
        public virtual IActionResult ReportPost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">task executed</response>
        [HttpPost]
        [Route("/task/execute")]
        [ValidateModelState]
        [SwaggerOperation("TaskExecutePost")]
        public virtual IActionResult TaskExecutePost([FromBody]Envelope body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">task executed</response>
        [HttpPost]
        [Route("/timer/tick")]
        [ValidateModelState]
        [SwaggerOperation("TimerTickPost")]
        public virtual IActionResult TimerTickPost()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
