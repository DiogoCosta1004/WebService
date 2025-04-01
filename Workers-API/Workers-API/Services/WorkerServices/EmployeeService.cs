using Microsoft.EntityFrameworkCore;
using Workers_API.DataContext;
using Workers_API.Models;

namespace Workers_API.Services.WorkerServices
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<WorkerModel>>> CreateWorker(WorkerModel workerModel)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = new ServiceResponse<List<WorkerModel>>();

            try
            {
                if (workerModel == null) 
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Informe data";
                    serviceResponse.Success = false;

                    return serviceResponse;
                }
                _context.Add(workerModel);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _context.Workers.ToList();   
            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<WorkerModel>>> DeleteWorker(int id)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = new ServiceResponse<List<WorkerModel>>();

            try
            {
                WorkerModel worker = _context.Workers.FirstOrDefault(x => x.Id == id);

                if (worker == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "User not found";
                    serviceResponse.Success = false;

                    return serviceResponse;
                }

                _context.Workers.Remove(worker);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _context.Workers.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<WorkerModel>>> GetWorker()
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = new ServiceResponse<List<WorkerModel>>();

            try
            {
                serviceResponse.Data = _context.Workers.ToList();

                if (serviceResponse.Data.Count == 0)
                {
                    serviceResponse.Message = "No exists";
                }

            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<WorkerModel>> GetWorkerById(int id)
        {
            ServiceResponse<WorkerModel> serviceResponse = new ServiceResponse<WorkerModel>();

            try
            {
                WorkerModel worker = _context.Workers.FirstOrDefault(x => x.Id == id);

                if (worker == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "User not found";
                    serviceResponse.Success = false;
                }
                serviceResponse.Data = worker;
            }
            catch (Exception ex) 
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success= false;
            }

            return serviceResponse; 
        }

        public async Task<ServiceResponse<List<WorkerModel>>> InactiveWorker(int id)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = new ServiceResponse<List<WorkerModel>>();

            try
            {
                WorkerModel worker = _context.Workers.FirstOrDefault(x => x.Id == id);

                if (worker == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "User not found";
                    serviceResponse.Success = false;
                }

                worker.Active = false;
                worker.UpdateDate = DateTime.Now.ToLocalTime();

                _context.Workers.Update(worker);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _context.Workers.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }   

        public async Task<ServiceResponse<List<WorkerModel>>> UpdateWorker(WorkerModel workerModel)
        {
            ServiceResponse<List<WorkerModel>> serviceResponse = new ServiceResponse<List<WorkerModel>>();

            try
            {
                WorkerModel worker = _context.Workers.AsNoTracking().FirstOrDefault(x => x.Id == workerModel.Id);

                if (worker == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "User not found";
                    serviceResponse.Success = false;
                }

                worker.UpdateDate = DateTime.Now.ToLocalTime();

                _context.Workers.Update(worker);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _context.Workers.ToList();
            }
            catch (Exception ex) 
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }
    }
}
