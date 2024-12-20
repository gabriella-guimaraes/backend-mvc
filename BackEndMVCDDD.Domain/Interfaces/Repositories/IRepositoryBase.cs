﻿
using System.Collections.Generic;

namespace BackEndMVCDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class // Genérico com trataiva de classe
    {
        //Chamadas genéricas/ CRUD padrão
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
