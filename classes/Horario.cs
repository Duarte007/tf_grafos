using System;

namespace tf_grafos.classes
{
    public class Horario
    {
        public int id;
        public String diaSemana;
        public TimeSpan horario;
        public Boolean emUso;
        public Horario(int id, int diaSemana, TimeSpan horario){
            this.id = id;
            this.diaSemana = this.getDayOfWeek(diaSemana);
            this.horario = horario;
            this.emUso = false;
        }

        private String getDayOfWeek(int diaSemana){
            switch(diaSemana){
                case 1:
                    return "Segunda";
                case 2:
                    return "Terca";
                case 3:
                    return "Quarta";
                case 4:
                    return "Quinta";
                case 5:
                    return "Sexta";
                case 6:
                    return "Sabado";
            }
            return "";
        }

        public Boolean getUso(){
            return emUso;
        }

        public void setUso(Boolean estado){
            this.emUso = estado;
        }
    }
}