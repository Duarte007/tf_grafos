using System;

namespace tf_grafos.classes
{
    public class Materia
    {
        private int id;
        private String nome;
        private int periodo;
        private int horario;
        private Professor professor;


        public Materia(int id, String nome, int periodo, Professor professor)
        {
            this.id = id;
            this.nome = nome;
            this.periodo = periodo;
            this.professor = professor;
        }

        public int getId()
        {
            return this.id;
        }

        public String getNome()
        {
            return this.nome;
        }

        public int getPeriodo()
        {
            return this.periodo;
        }

        public int getHorario()
        {
            return this.horario;
        }

        public void setHorario(int horario)
        {
            this.horario = horario;
        }

        public Professor getProfessor()
        {
            return this.professor;
        }

        public void setProfessor(Professor professor)
        {
            this.professor = professor;
        }
    }
}