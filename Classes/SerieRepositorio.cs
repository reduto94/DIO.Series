using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    /*
    // A classe SerieRepositorio, é uma implementacao da interface iRepositorio_
    // _que informa o objeto generico <T> como sendo a classe Serie.
    // Uma interface obriga a implementação de todos os metodos contidos na interface.
    // O VS Code/VStudio oferece implementacao automatica dos metodos da interface ao_
    // _ser implementada. Neste caso ocorrera a substituicao do objeto generico T, pela_
    // _classe informada. List<T> Lista(); ira ficar List<Serie> Lista()
    */
    public class SerieRepositorio : iRepositorio<Serie>
    {
        // Lista q contem todas as series no repositorio
        private List<Serie> listaSerie = new List<Serie>();

        // A implementacao da interface define os metodos presentes na_
        // _interface iRepositorio
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;

        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            // Para objetivos de controle. Neste metodo poderia ser acionada uma classe_
            // _de alerta, com evio de e-mail ou mensagens push.

        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);

        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;

        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];

        }
    }
}