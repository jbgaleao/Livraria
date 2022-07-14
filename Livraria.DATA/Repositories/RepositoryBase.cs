﻿using Livraria.DATA.Data;
using Livraria.DATA.Interfaces;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        protected readonly LivrariaContext _contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _contexto = new LivrariaContext();
        }

        public T Alterar(T objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            object obj = SelecionarPK(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void Savechanges()
        {
            _contexto.SaveChanges();
        }

        public T SelecionarPK(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}
