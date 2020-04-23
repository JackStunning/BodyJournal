using BodyJournalAPI.Contracts;
using BodyJournalAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using BodyJournalAPI.Entities;

namespace BodyJournalAPI.Repository
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected BodyJournalContext BodyJournalContext { get; set; }

    public RepositoryBase(BodyJournalContext bodyJournalContext)
    {
      this.BodyJournalContext = bodyJournalContext;
    }

    public IQueryable<T> FindAll()
    {
      return this.BodyJournalContext.Set<T>().AsNoTracking();
    }
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => this.BodyJournalContext.Set<T>().Where(expression).AsNoTracking();

    public void Create(T entity)
    {
      this.BodyJournalContext.Set<T>().Add(entity);
    }
    public void Update(T entity)
    {
      this.BodyJournalContext.Set<T>().Update(entity);
    }
    public void Delete(T entity)
    {
      this.BodyJournalContext.Set<T>().Remove(entity);
    }
  }
}