using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishProject.DataAccess
{
    public class DbService
    {
        public List<EnglishPrase> GetListEnglishPhrases()
        {
            var listEnglishPhrases = new List<EnglishPrase>();
            using (SqlConnection sqlConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["EnglishProject"].ConnectionString))
            {
                var query = new SqlCommand("SELECT * FROM test");
                sqlConnect.Open();
                using (var reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listEnglishPhrases.Add
                            (
                                new EnglishPrase()
                                {
                                    Id = Convert.ToInt32(reader[0]),
                                    Phrase = Convert.ToString(reader[1])
                                }
                            );
                    }
                }
            }

            return listEnglishPhrases;
        }
    }
}
