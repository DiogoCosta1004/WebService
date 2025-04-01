using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workers_API.Models;
using Workers_API.Services.WorkerServices;

namespace Workers_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IEmployeeInterface _employeeService;
        public WorkerController(IEmployeeInterface employeeInterface)
        {
            _employeeService = employeeInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<WorkerModel>>>> GetWorker()
        {
            return Ok(await _employeeService.GetWorker()); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<WorkerModel>>> GetWorkerById(int id)
        {
            ServiceResponse<WorkerModel> serviceResponse = await _employeeService.GetWorkerById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<WorkerModel>>>> CreateWorker(WorkerModel worker)
        {
            return Ok(await _employeeService.CreateWorker(worker));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<WorkerModel>>>> UpdateWorker(WorkerModel worker)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = await _employeeService.UpdateWorker(worker);

            return Ok(serviceResponse);
        }

        [HttpPut("inactiveFunc")]
        public async Task<ActionResult<ServiceResponse<List<WorkerModel>>>> InactiveWorker(int id)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = await _employeeService.InactiveWorker(id);

            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<WorkerModel>>>> DeleteWorker(int id)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = await _employeeService.DeleteWorker(id);

            return Ok(serviceResponse);
        }
    }
}
