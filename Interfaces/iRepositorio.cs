using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    // o termo T indica o um tipo generico a ser recebido pela interface.
    public interface iRepositorio<T>
    {
         // Implementa CRUD.
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}