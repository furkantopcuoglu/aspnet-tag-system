using System.Data.SqlClient;
public class sql
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection(@"Data Source=8.8.8.8; Initial Catalog=tagsystem; Integrated Security=SSPI");

            baglan.Open();
            return baglan;
        }
    }
