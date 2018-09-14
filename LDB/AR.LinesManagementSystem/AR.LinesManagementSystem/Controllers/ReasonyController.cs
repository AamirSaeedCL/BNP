using AR.LinesManagementSystem.Models;
using AR.LinesManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Controllers
{
    [Route("api/[controller]")]
    public class ReasonController : ApplicationController
    {
        private IUnitOfWork _IUow;
        readonly ILogger<ReasonController> _log;
        private const string entityName = "reason";
        public ReasonController(IUnitOfWork IUow, ILogger<ReasonController> log) : base(IUow, log)
        {
            _IUow = IUow;
            _log = log;
        }

        // GET api/Reason
        [HttpGet]
        public async Task<IActionResult> GetReasons()
        {
            try
            {
                var rows = await _IUow.reasonRepository.GetReasons();
                if (!rows.Any())
                {
                    return NotFound();
                }
                return Ok(rows);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading {entityName} - {ex.Message.ToString()}");
                return BadRequest();
            }

        }

        // GET api/Reason/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReason(int id)
        {
            try
            {
                var row = await _IUow.reasonRepository.GetReason(id);
                if (row == null)
                {
                    return NotFound();
                }
                return Ok(row);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading {entityName} for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // POST api/Reason
        [HttpPost]
        public async Task<IActionResult> SaveReason([FromBody]Reason fromBody)
        {
            try
            {
                if (fromBody == null)
                {
                    return BadRequest();
                }
                ModelState.Clear();
                TryValidateModel(fromBody);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (await _IUow.reasonRepository.DuplicateEntryAsync(fromBody.Name, fromBody.Id))
                {
                    return BadRequest("Invalid entry! The {entityName} name already exist.");
                }

                await _IUow.reasonRepository.AddAsync(fromBody);
                return Ok(fromBody);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during creation of new {entityName} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // PUT api/Reason/5
        [HttpPut]
        public async Task<IActionResult> UpdateReason([FromBody]Reason fromBody)
        {
            try
            {
                if (fromBody == null)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var row = await _IUow.reasonRepository.GetByIdAsync(fromBody.Id);
                if (row == null)
                {
                    return BadRequest();
                }
                return Ok(await _IUow.reasonRepository.UpdateAsync(fromBody));
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during updating {entityName} for Id = {fromBody.Id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // DELETE api/Reason/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReason(int id)
        {
            try
            {
                var row = await _IUow.reasonRepository.GetByIdAsync(id);
                if (row == null)
                {
                    return BadRequest();
                }
                await _IUow.reasonRepository.DeleteAsync(row);
                return Ok(id);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during deleting {entityName} for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }
    }
}
