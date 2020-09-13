using HazzleApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HazzleApi.Repository
{
    public interface IExampleRepository<TEntity>
    {
        Task<ExampleModel> FirstAsync(Func<ExampleModel, bool> predicate);
        Task<ExampleModel> FirstOrDefaultAsync(Func<ExampleModel, bool> predicate);

        /// <summary>
        /// Get all queries
        /// </summary>
        /// <returns>IEnumerable queries</returns>
        IEnumerable<ExampleModel> GetAll();

        /// <summary>
        /// Find queries by predicate
        /// </summary>
        /// <param name="predicate">search predicate (LINQ)</param>
        /// <returns>IEnumerable queries</returns>
        IEnumerable<ExampleModel> FindBy(Func<ExampleModel, bool> predicate);

        /// <summary>
        /// Find entity by keys
        /// </summary>
        /// <param name="keys">search key</param>
        /// <returns>T entity</returns>
        Task<ExampleModel> FindAsync(params object[] keys);

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(ExampleModel entity);

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Added entity id</returns>
        int Add(ExampleModel entity);

        /// <summary>
        /// Remove entity from database
        /// </summary>
        /// <param name="entity"></param>
        void Delete(ExampleModel entity);

        /// <summary>
        /// Remove entity from database
        /// </summary>
        /// <param name="keys">entity keys</param>
        void Delete(int id);

        /// <summary>
        /// Edit entity
        /// </summary>
        /// <param name="entity"></param>
        ExampleModel Update(ExampleModel entity);

        /// <summary>
        /// Edit entity
        /// </summary>
        /// <param name="entity"></param>
        Task<int> UpdateAsync(ExampleModel entity);

        /// <summary>
        /// Persists all updates to the data source.
        /// </summary>
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
