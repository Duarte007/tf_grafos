using System;
using System.IO;
using System.Collections.Generic;
using tf_grafos.classes;

namespace tf_grafos
{
    class Program
    {

        static List<Materia> materias = new List<Materia>();
        static List<Professor> professores = new List<Professor>();
        static List<Vertice> vertices = new List<Vertice>();
        static List<Aresta> arestas = new List<Aresta>();
        static void Main(string[] args)
        {
            carregaArquivoGrade();
        }

        static void carregaArquivoGrade() {
            string arquivo = @Directory.GetCurrentDirectory() + "\\grade.txt";
            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        String nomeMateria, nomeProfessor;
                        int periodo, count = 0;
                        Professor professor = null, professorFiltrado = null;
                        Materia materia = null;
                        Random randNum = new Random();
                        // Lê linha por linha
                        while ((linha = sr.ReadLine()) != null)
                        {
                            count++;
                            var dados = linha.Split(';');
                            nomeMateria = dados[0].Trim();
                            nomeProfessor = dados[1].Trim();
                            periodo = int.Parse(dados[2]);

                            professorFiltrado = professores.Find(professor => professor.getNome() == nomeProfessor);
                            if(professorFiltrado == null){
                                professor = new Professor(count, nomeProfessor);
                                professores.Add(professor);
                                vertices.Add(new Vertice(randNum.Next(), professor));
                            }

                            materia = new Materia(count, nomeMateria, periodo, professor);
                            materias.Add(materia);
                            vertices.Add(new Vertice(randNum.Next(), materia));

                            Console.WriteLine(linha);
                        }
                    }
                    Console.Write("yo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("O arquivo " + arquivo + " não foi localizado!");
            }
        }
    
        static void carregaArquivoHorarios() {
            string arquivo = @Directory.GetCurrentDirectory() + "\\horarios.min.txt";
            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        String[] aux;
                        int id, diaSemana;
                        TimeSpan auxTime;
                        Horario horario;
                        // Lê linha por linha
                        while ((linha = sr.ReadLine()) != null)
                        {
                            var dados = linha.Split(';');
                            id = int.Parse(dados[0]);
                            diaSemana = int.Parse(dados[1]);
                            aux = dados[2].Split(':');
                            auxTime = new TimeSpan(int.Parse(aux[0]), int.Parse(aux[1]), int.Parse(aux[2]));
                            horario = new Horario(id, diaSemana, auxTime);
                            // arestas.Add(new Aresta(id, diaSemana, horario));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("O arquivo " + arquivo + " não foi localizado!");
            }
        }
    }
}
