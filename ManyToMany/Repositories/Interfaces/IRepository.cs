﻿using ManyToMany.Models.Common;
using System.Linq.Expressions;

namespace ManyToMany.Repositories.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync(params string[] includes);
    Task<T?> GetSingleAsync(Expression<Func<T, bool>> predicate, params string[] includes);
    Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate);
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<int> SaveChangesAsync();
}
