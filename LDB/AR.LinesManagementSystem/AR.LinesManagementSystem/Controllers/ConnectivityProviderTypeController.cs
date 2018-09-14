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
    public class ConnectivityProviderTypeController : ApplicationController
    {
        private IUnitOfWork _IUow;
        readonly ILogger<ConnectivityProviderTypeController> _log;
        public ConnectivityProviderTypeController(IUnitOfWork IUow, ILogger<ConnectivityProviderTypeController> log) : base(IUow, log)
        {
            _IUow = IUow;
            _log = log;
        }

        // GET api/ConnectivityType
        [HttpGet]
        public async Task<IActionResult> GetConnectivityProviderTypes()
        {
            try
            {
                var rows = await _IUow.connectivityProviderTypeRepository.GetConnectivityProviderTypes();
                if (!rows.Any())
                {
                    return NotFound();
                }
                return Ok(rows);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading connectivity provider types - {ex.Message.ToString()}");
                return BadRequest();
            }

        }

        // GET api/ConnectivityType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConnectivityType(int id)
        {
            try
            {
                var row = await _IUow.connectivityProviderTypeRepository.GetConnectivityProviderType(id);
                if (row == null)
                {
                    return NotFound();
                }
                return Ok(row);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading connectivity provider type for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // POST api/ConnectivityType
        [HttpPost]
        public async Task<IActionResult> SaveConnectivityType([FromBody]ConnectivityProviderType connType)
        {
            try
            {
                if (connType == null)
                {
                    return BadRequest();
                }
                ModelState.Clear();
                TryValidateModel(connType);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (await _IUow.connectivityProviderTypeRepository.DuplicateEntryAsync(connType.Name, connType.Id))
                {
                    return BadRequest("Invalid entry! The connectivity Type name already exist.");
                }

                await _IUow.connectivityProviderTypeRepository.AddAsync(connType);
                return Ok(connType);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during creation of new connectivity Type - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // PUT api/ConnectivityType/5
        [HttpPut]
        public async Task<IActionResult> UpdateConnectivityType([FromBody]ConnectivityProviderType connType)
        {
            try
            {
                if (connType == null)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var row = await _IUow.connectivityProviderTypeRepository.GetByIdAsync(connType.Id);
                if (row == null)
                {
                    return BadRequest();
                }
                return Ok(await _IUow.connectivityProviderTypeRepository.UpdateAsync(connType));
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during updating connectivity Type for Id = {connType.Id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // DELETE api/ConnectivityType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConnectivityType(int id)
        {
            try
            {
                var row = await _IUow.connectivityProviderTypeRepository.GetByIdAsync(id);
                if (row == null)
                {
                    return BadRequest();
                }
                await _IUow.connectivityProviderTypeRepository.DeleteAsync(row);
                return Ok(id);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during deleting connectivity Type for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }
    }
}
