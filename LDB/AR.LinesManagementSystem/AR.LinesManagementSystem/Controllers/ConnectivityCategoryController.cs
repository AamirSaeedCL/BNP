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
    public class ConnectivityCategoryController : ApplicationController
    {
        private IUnitOfWork _IUow;
        readonly ILogger<ConnectivityCategoryController> _log;
        public ConnectivityCategoryController(IUnitOfWork IUow, ILogger<ConnectivityCategoryController> log) : base(IUow, log)
        {
            _IUow = IUow;
            _log = log;
        }

        // GET api/ConnectivityCategory
        [HttpGet]
        public async Task<IActionResult> GetConnectivityCategories()
        {
            try
            {
                var rows = await _IUow.connectivityCategoryRepository.GetConnectivityCategories();
                if (!rows.Any())
                {
                    return NotFound();
                }
                return Ok(rows);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading connectivity categories - {ex.Message.ToString()}");
                return BadRequest();
            }

        }

        // GET api/ConnectivityCategory/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConnectivityCategory(int id)
        {
            try
            {
                var row = await _IUow.connectivityCategoryRepository.GetConnectivityCategory(id);
                if (row == null)
                {
                    return NotFound();
                }
                return Ok(row);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during reading connectivity category for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // POST api/ConnectivityCategory
        [HttpPost]
        public async Task<IActionResult> SaveConnectivityCategory([FromBody]ConnectivityCategory connCategory)
        {
            try
            {
                if (connCategory == null)
                {
                    return BadRequest();
                }
                ModelState.Clear();
                TryValidateModel(connCategory);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                if (await _IUow.connectivityCategoryRepository.DuplicateEntryAsync(connCategory.Name, connCategory.Id))
                {
                    return BadRequest("Invalid entry! The connectivity category name already exist.");
                }

                await _IUow.connectivityCategoryRepository.AddAsync(connCategory);
                return Ok(connCategory);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during creation of new connectivity category - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // PUT api/ConnectivityCategory/5
        [HttpPut]
        public async Task<IActionResult> UpdateConnectivityCategory([FromBody]ConnectivityCategory connCategory)
        {
            try
            {
                if (connCategory == null)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var row = await _IUow.connectivityCategoryRepository.GetByIdAsync(connCategory.Id);
                if (row == null)
                {
                    return BadRequest();
                }
                return Ok(await _IUow.connectivityCategoryRepository.UpdateAsync(connCategory));
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during updating connectivity category for Id = {connCategory.Id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }

        // DELETE api/ConnectivityCategory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConnectivityCategory(int id)
        {
            try
            {
                var row = await _IUow.connectivityCategoryRepository.GetByIdAsync(id);
                if (row == null)
                {
                    return BadRequest();
                }
                await _IUow.connectivityCategoryRepository.DeleteAsync(row);
                return Ok(id);
            }
            catch (Exception ex)
            {
                _log.LogError($"Error happening during deleting connectivity category for Id = {id} - {ex.Message.ToString()}");
                return BadRequest();
            }
        }
    }
}
