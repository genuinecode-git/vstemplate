﻿
namespace ApplicationTemplate.Domain.Interfaces.Base;

public interface IRepository<T> where T : class
{
    IQueryable<T> GetAll();

    T FirstOrDefault(Expression<Func<T, bool>> predicate);

    T FirstOrDefaultWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

    void Add(T entity);

    void Update(T entity);

    void Remove(T entity);
}
