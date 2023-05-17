namespace FeelingWeb.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAllAsync<T>(string url);
    }
}
