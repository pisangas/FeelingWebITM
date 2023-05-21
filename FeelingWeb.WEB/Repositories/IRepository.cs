﻿namespace FeelingWeb.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAllAsync<T>(string url);
        Task<HttpResponseWrapper<T>> GetAllUsersAsync<T>(string url);
        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> PutAsync<T, TResponse>(string url, T model);
    }
}
