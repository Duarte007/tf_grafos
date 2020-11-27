using System;
using System.Collections.Generic;

namespace tf_grafos.classes
{
    class Grafo
    {
        public List<Vertice> vertices = new List<Vertice>();
        public List<Aresta> arestas = new List<Aresta>();
        private int idGrafo;

        public Grafo(List<Vertice> v, List<Aresta> a)
        {
            vertices = v;
            arestas = a;
        }
        public Grafo(int id)
        {
            idGrafo = id;
        }

        public void setVertice(Vertice v)
        {
            vertices.Add(v);
        }

        public void setAresta(Aresta a)
        {
            arestas.Add(a);
        }

        public override string ToString()
        {
            String arvore = "Arvore ";
            foreach (Vertice v in vertices)
            {
                arvore += "\nVertice " + v.GetId();
            }
            return arvore;
        }

        public int GetIdGrafo()
        {
            return this.idGrafo;
        }

        public void SetIdGrafo(int id)
        {
            this.idGrafo = id;
        }


    }
}