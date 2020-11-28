using System;

namespace tf_grafos.classes
{
    public class Horario
    {
        int id;
        DayOfWeek diaSemana;
        TimeSpan horario;
        public Horario(int id, int diaSemana, TimeSpan horario){
            this.id = id;
            this.diaSemana = this.getDayOfWeek(diaSemana);
            this.horario = horario;
        }

        private DayOfWeek getDayOfWeek(int diaSemana){
            switch(diaSemana){
                case 1:
                    return DayOfWeek.Monday;
                case 2:
                    return DayOfWeek.Tuesday;
                case 3:
                    return DayOfWeek.Wednesday;
                case 4:
                    return DayOfWeek.Thursday;
                case 5:
                    return DayOfWeek.Friday;
                case 6:
                    return DayOfWeek.Saturday;
            }
            return DayOfWeek.Monday;
        }
    }
}