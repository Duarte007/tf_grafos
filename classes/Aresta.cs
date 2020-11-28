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

        public Aresta(Horario horario)
        {
            this.horario = horario;
            this.emUso = false;
        }
        public int getCor()
        {
            return cor;
        }

        public void setCor(int cor)
        {
            this.cor = cor;
        }

        public Vertice getVerticeInicial()
        {
            return this.verticeInicial;
        }

        public void setVerticeInicial(Vertice v)
        {
            this.verticeInicial = v;
        }

        public Vertice getVerticeFinal()
        {
            return this.verticeFinal;
        }

        public void setVerticeFinal(Vertice v)
        {
            if (v != getVerticeInicial())
                this.verticeFinal = v;
            else
                this.verticeFinal = null;
        }

        public bool getEmUso()
        {
            return emUso;
        }

        public void setEmUso(bool uso)
        {
            this.emUso = uso;
        }
    }
}