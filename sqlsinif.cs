using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace YemekTarifleri
{
    public class sqlsinif
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=TAMER;Initial Catalog=PBYemekTarifleri;Integrated Security=True;Pooling=False");
            baglan.Open();
            return baglan;
        }
    }
}