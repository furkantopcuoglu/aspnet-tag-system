using System.Data;
using System.Data.SqlClient;
      sql bgl = new sql();
      protected void taggonder_Click(object sender, EventArgs e)
        {
          // Gelen keliemleri küçük harfe çeviriyor
            tag.Text = tag.Text.ToLower();
          // Gelen kelime dizisini her biz dizi elemanını , ile ayrıldığını belirtiyorum
            string[] tags = tag.Text.Split(',');
            foreach (var t in tags)
            {
               
                SqlCommand newtag = new SqlCommand("insert into tag(tagname) values(@1)", bgl.baglanti());
                newtag.Parameters.AddWithValue("@1", t);
                newtag.ExecuteNonQuery();
    
             }
        }
        
                     
