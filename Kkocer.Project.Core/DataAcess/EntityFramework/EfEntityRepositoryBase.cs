﻿using Kkocer.Project.Core.DataAcess;
using Kkocer.Project.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace Kkocer.Project.Core.DataAccess.EntityFramework

{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new()

        where TContext : DbContext, new()

    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);

                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);

                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}