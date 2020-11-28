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

        public void colorirArestas(List<Horario> horarios){
            Horario horaioDisponivel = null;
            // percorre os 8 semestres
            for(int i = 1 ; i <= 8 ; i++){
                // filtra os vertices que sao materias por semestre
                List<Vertice> verticeMateriasPeriodo = this.vertices.FindAll(vertice => vertice.getProfessor() == null && vertice.getMateria().getPeriodo() == i);
                verticeMateriasPeriodo.ForEach(materiaPeriodo => {
                    // pra cara materia do semestre, que e um vertice, pegamos sua aresta.
                    // como o vertice de materia nao repete, só tem uma aresta
                    materiaPeriodo.getArestas().ForEach( aresta => {

                        horaioDisponivel = horarios.Find(horario => horario.emUso == false);
                        // esse loop verifica se o horario esta em conflito atraves do professor
                        do {
                            if(horaioDisponivel.emUso)
                                horaioDisponivel = horarios.Find(horario => horario.emUso == false);
                            // percorre as arestas do vertice inicial que é o professor
                            aresta.getVerticeInicial().getArestas().ForEach(aresta => {
                                if(aresta.getCor() == horaioDisponivel.id){
                                    horaioDisponivel.emUso = true;
                                }
                            });
                        } while(horaioDisponivel.emUso);

                        aresta.setCor(horaioDisponivel.id);
                        horaioDisponivel.emUso = true;
                    });
                });
                horarios.ForEach(horario => horario.emUso = false);
            }

        }


    }
}