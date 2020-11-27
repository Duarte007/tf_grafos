using System.Collections.Generic;
using tf_grafos.interfaces;

namespace tf_grafos.classes
{
    public class Vertice : IDados
    {
        private int id;
        public List<Aresta> arestas = new List<Aresta>();
        private int per�odo; //0 ao 8 e per�odos iguais n�o podem ter cores de arestas iguais. 0 s�o os prof 
        //somente os professores ter�o mais de uma aresta. Elas n�o podem ter cores repetidas, mas professores diferentes ter�o cores de arestas iguais

        //private int cor;
        //private Vertice pai;
        //public List<Vertice> filhos = new List<Vertice>();
        //private int descoberta;
        //private int termino;

        public Vertice(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public List<Aresta> GetArestas()
        {
            return this.arestas;
        }

        public void SetArestas(Aresta a)
        {
            arestas.Add(a);
        }

        public int getPeriodo()
        {
            return this.per�odo;
        }

        public void setPeriodo(int periodo)
        {
            this.per�odo = periodo;
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

        public Aresta GetMenorArestaDisponivel()
        {
            Aresta menorAresta = null;
            int menorPeso = System.Int32.MaxValue;
            foreach (Aresta aresta in arestas)
            {
                if (aresta.GetPeso() < menorPeso && !aresta.GetEmUso())
                {
                    menorPeso = aresta.GetPeso();
                    menorAresta = aresta;
                }
                else if (aresta.GetPeso() == menorPeso && !aresta.GetEmUso())
                {
                    if (((aresta.GetVerticeInicial().GetId() + aresta.GetVerticeFinal().GetId())
                        < (menorAresta.GetVerticeInicial().GetId() + menorAresta.GetVerticeFinal().GetId())))
                    {
                        menorPeso = aresta.GetPeso();
                        menorAresta = aresta;
                    }
                    else if (((aresta.GetVerticeInicial().GetId() + aresta.GetVerticeFinal().GetId())
                        == (menorAresta.GetVerticeInicial().GetId() + menorAresta.GetVerticeFinal().GetId())))
                    {
                        if (aresta.GetVerticeFinal().GetId() < menorAresta.GetVerticeFinal().GetId())
                        {
                            menorPeso = aresta.GetPeso();
                            menorAresta = aresta;
                        }
                    }
                }
            }

            return menorAresta;
        }

    }
}