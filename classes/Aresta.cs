using tf_grafos.interfaces;

namespace tf_grafos.classes
{
    public class Aresta : IDados
    {
        //private int id;
        private Vertice verticeInicial;
        private Vertice verticeFinal;
        private Horario horario;
        private int cor; 
        private bool emUso;

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