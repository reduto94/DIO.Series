using DIO.Series.Enum;
using System;

namespace DIO.Series.Classes
{
    public class Serie: EntidadeBase
    {
        // Esta classe Serie herda a partir da classe base EntidadeBase.
        // Esta classe Serie pode ser instanciar objetos a partir desta.

        // enum. Genero da serie: acao; drama; comedia; etc
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            //
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        } //Serie()

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano;
            retorno += "Excluido: " + this.Excluido;
            return retorno;

        } //ToString()

        public string retornaTitulo()
        {
            //
            return this.Titulo;

        } //retornaTitulo()
        public int retornaId()
        {
            //
            return this.Id;

        } //retornaId()
        public bool retornaExcluido()
        {
            //
            return this.Excluido;
        } //retornaExcluido()
        public void Excluir(){
            this.Excluido = true;

        } //Excluir()

    }
}