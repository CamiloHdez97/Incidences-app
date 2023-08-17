using System;
using System.Collection.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplication.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity {

    private readonly ApiIncidenciasContext _contex;

    public GenericRepository(ApiIncidenciasContext contex){
        _context = contex;
    }

    public virtual void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>.AddRange(entities);
    }

    public virtual IEnumerable<T> Find(Expressions<Func<T, bool>> expressions)
    {
        return _context.Set<T>().where(expressions);
    }

    public virtual async Tasks<T> GetByAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}