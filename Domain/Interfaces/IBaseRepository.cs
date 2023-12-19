﻿using Bets.Domain.Consts;
using System.Linq.Expressions;

namespace Bets.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        
        Task<IEnumerable<T>> GetAllAsync();
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);

        /*Task<T>: This indicates that the method returns a Task representing an asynchronous operation that will eventually produce 
         * a result of type T
         Expression<Func<T, bool>> criteria: This parameter represents a lambda expression that serves as a filter or criteria for searching entities of type T. It's an expression that evaluates to a boolean value, and it's commonly used in the context of querying a database. It allows you to specify conditions that the entities must meet to be considered a match.

            string[] includes = null: This parameter is an array of strings representing navigation properties to be included in the query. When querying entities from a database, including related entities can help reduce the number of subsequent database calls when accessing navigation properties*/
        Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int take, int skip);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip,
            Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take,
            Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);
        T Add(T entity);
        Task<T> AddAsync(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        T Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Attach(T entity);
        void AttachRange(IEnumerable<T> entities);
        int Count();
        int Count(Expression<Func<T, bool>> criteria);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);
    }
}