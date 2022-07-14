using System.Collections.Generic;

namespace Livraria.DATA.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPK(params object[] variavel);
        T Incluir(T objeto);
        T Alterar(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void Savechanges();
    }
}
