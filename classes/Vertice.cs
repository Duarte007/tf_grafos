using System.Collections.Generic;
using tf_grafos.interfaces;

namespace tf_grafos.classes
{
    public class Vertice : IDados
    {
        private int id;
        public List<Aresta> arestas = new List<Aresta>();
        private Materia materia;
        private Professor professor;

        //private int cor;
        //private Vertice pai;
        //public List<Vertice> filhos = new List<Vertice>();
        //private int descoberta;
        //private int termino;

        public Vertice(int id, Materia materia)
        {
            this.id = id;
            this.materia = materia;
        }

        public Vertice(int id, Professor professor)
        {
            this.id = id;
            this.professor = professor;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public List<Aresta> getArestas()
        {
            return this.arestas;
        }

        public void setAresta(Aresta a)
        {
            arestas.Add(a);
        }

        public Professor getProfessor()
        {
            return this.professor;
        }

        public Materia getMateria()
        {
            return this.materia;
        }

        /// <summary>
        /// 0 = branco, 1 = cinza 2 = preto
        /// </summary>
        /// <returns></returns>
        //public int GetCor()
        //{
        //    return this.cor;
        //}

        //public void SetCor(int cor)
        //{
        //    if (cor == 0 || cor == 1 || cor == 2)
        //        this.cor = cor;
        //    else
        //        cor = 0;
        //}

        //public Vertice GetPai()
        //{
        //    return this.pai;
        //}

        //public void SetPai(Vertice v)
        //{
        //    this.pai = v;
        //}

        //public List<Vertice> GetFilhos()
        //{
        //    return this.filhos;
        //}

        //public void SetFilhos(List<Vertice> v)
        //{
        //    this.filhos = v;
        //}

        //public int GetDescoberta()
        //{
        //    return this.descoberta;
        //}

        //public void SetDescoberta(int u)
        //{
        //    this.descoberta = u;
        //}

        //public int GetTermino()
        //{
        //    return this.termino;
        //}

        //public void SetTermino(int u)
        //{
        //    this.termino = u;
        //}

    }
}