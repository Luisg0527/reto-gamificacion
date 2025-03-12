using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;


namespace Reto.Model
{
    public class DataBaseContext{
        public string ConnectionString { get; set; }
        public DataBaseContext(){
            ConnectionString = "Server=127.0.0.1;Port=3306;Database=dbTest3;Uid=root;password=Paolo2004;";
        }

        private MySqlConnection GetConnection(){
            return new MySqlConnection(ConnectionString);
        }

        public MetricasDash getMetricas(){
            MetricasDash metricas = new MetricasDash(0,0,0,0,0);
            using(MySqlConnection connection = GetConnection()){
                connection.Open();
                string query = "Select * from metricas where idmetricas = 1";

                using (MySqlCommand cmd = new MySqlCommand (query,connection)){
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            metricas = new MetricasDash(

                                reader.GetInt32("idMetricas"),
                                reader.GetFloat("ingresos"),
                                reader.GetFloat("ganancias"),
                                reader.GetInt32("ordenes"),
                                reader.GetInt32("visitas")
                            );
                        }
                    }

                }
            }
            return metricas;
            
        }

        public float getNeta(){
            float gananciasNeta = 0;
            
            return gananciasNeta;
        }

        public int getOrdenes(){
            int ordenes =0;

            return ordenes;
        }

        public int getVisitas(){
            int visitas = 0;

            return visitas;
        }



    }
}