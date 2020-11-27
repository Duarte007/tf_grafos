using tf_grafos.interfaces;

namespace tf_grafos.classes
{
    public class Aresta : IDados
    {
        //private int id;
        private Vertice verticeInicial;
        private Vertice verticeFinal;
        private int cor; //pode ser string, mas acho q com int vai ser mais de boa
        //ai precisamos só especificar 1= seg1, 2 = seg2, 3 = ter1...
        private bool emUso; //não sei se vamos precisar, mas deixei ai

        public Aresta(Vertice vI, Vertice vF)
        {
            this.verticeInicial = vI;
            this.verticeFinal = vF;
            this.emUso = false;
        }
        public int GetCor()
        {
            return cor;
        }

        public void SetCor(int cor)
        {
            this.cor = cor;
        }

        public Vertice GetVerticeInicial()
        {
            return this.verticeInicial;
        }

        public void SetVerticeInicial(Vertice v)
        {
            this.verticeInicial = v;
        }

        public Vertice GetVerticeFinal()
        {
            return this.verticeFinal;
        }

        public void SetVerticeFinal(Vertice v)
        {
            if (v != GetVerticeInicial())
                this.verticeFinal = v;
            else
                this.verticeFinal = null;
        }

        public bool GetEmUso()
        {
            return emUso;
        }

        public void SetEmUso(bool uso)
        {
            this.emUso = uso;
        }
    }
}