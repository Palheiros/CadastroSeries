using System;
using System.Collections.Generic;

namespace CadastroSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
        void Exclui(int id);
        void Atualizar(int id, T objeto);
        int ProximoId();
    }
}
