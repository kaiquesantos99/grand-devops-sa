using GrandDevOpsSanAndreas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandDevOpsSanAndreas.DataAccess
{
    internal class QuestoesDAO
    {
        // ATRIBUTOS
        private Database db;




        // MÉTODOS
        public QuestoesDAO() // MÉTODO CONSTRUTOR
        {
            db = new Database();
        }




        public List<Questoes> ReadQuestions()
        {
            List<Questoes> lista = new List<Questoes>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM questions";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Questoes questao = new Questoes
                    {
                        Id = reader.GetInt32("id"),
                        Tipo = reader.GetString("tipo"),
                        Question = reader.GetString("question"),
                        Option1 = reader.GetString("option1"),
                        Option2 = reader.GetString("option2"),
                        Option3 = reader.GetString("option3"),
                        Option4 = reader.GetString("option4")
                    };
                    lista.Add(questao);
                }
            }
            return lista;
        }

        public Questoes SearchQuestion(string busca)
        {
            
            if (busca.Length == 0)
            {
                return new Questoes();
            }
            else
            {
                List<Questoes> lista = new List<Questoes>();
                using (MySqlConnection conn = db.GetConnection())
                {


                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM questions WHERE question LIKE @busca";


                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    Questoes question = new Questoes
                                    {
                                        Question = reader.GetString("question"),
                                        Option1 = reader.GetString("option1")
                                    };
                                    lista.Add(question);
                                }
                                return lista[0];
                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Questão não encontrada!");
                        return new Questoes();
                    }
                }
            }

            
            

            

            
        }

    }
}
