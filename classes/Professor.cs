using System;

namespace tf_grafos.classes
{
    public class Professor
    {
        private int id;
        private String nome;

        public Professor(int id, String nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int getId()
        {
            return this.id;
        }

        public String getNome()
        {
            return this.nome;
        }
    }
}