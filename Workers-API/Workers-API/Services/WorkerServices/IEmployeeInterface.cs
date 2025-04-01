using Workers_API.Models;

namespace Workers_API.Services.WorkerServices
{
    public interface IEmployeeInterface
    {
        Task<ServiceResponse<List<WorkerModel>>> GetWorker();
        Task<ServiceResponse<List<WorkerModel>>> CreateWorker(WorkerModel workerModel);
        Task<ServiceResponse<WorkerModel>> GetWorkerById(int id);
        Task<ServiceResponse<List<WorkerModel>>> UpdateWorker(WorkerModel workerModel);
        Task<ServiceResponse<List<WorkerModel>>> DeleteWorker(int id);
        Task<ServiceResponse<List<WorkerModel>>> InactiveWorker(int id);
    }
}
