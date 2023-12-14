using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace Test_Retgo___Intan
{
    internal class DataItem
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    internal class Database
    {
        private String connectionString = "Host=localhost;Username=postgres;Password=intansari;Database=retgo_intan";

        private NpgsqlConnection con;

        public Database()
        {
            con = new NpgsqlConnection(connectionString);
        }

        public bool AuthAnggota(string username, string password)
        {
            con.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM anggota WHERE username='"+username+"' AND password='"+password+"'", con);

            using NpgsqlDataReader dataReader = cmd.ExecuteReader();

            int count = 0;
            while (dataReader.Read()) count++;

            con.Close();

            return count > 0;
        }

        public bool RegisterAnggota(string name, string username, string password)
        {
            con.Open();

            using var insertCmd = new NpgsqlCommand("INSERT INTO anggota (name, username, password, bio) VALUES ('"+name+"', '"+username+"', '"+password+"', 'Edit Your BIO here.')", con);
            insertCmd.ExecuteNonQuery();

            con.Close();

            return AuthAnggota(username, password);
        }

        public List<DataItem> SelectAll(string table_name)
        {
            con.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM " + table_name, con);

            using NpgsqlDataReader dataReader = cmd.ExecuteReader();

            List<DataItem> item = new List<DataItem>();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string nama = dataReader.GetString(1);
                string username = dataReader.GetString(2);
                //string password = dataReader.GetString(3);
                string bio = dataReader.GetString(4);

                item.Add(new DataItem() { key = "id", value = id.ToString() });
                item.Add(new DataItem() { key = "nama", value = nama });
                item.Add(new DataItem() { key = "username", value = username });
                //item.Add(new DataItem () { key="password", value=password});
                item.Add(new DataItem() { key = "bio", value = bio });
            }

            con.Close();

            return item;
        }

        public List<DataItem> Query(string sql)
        {
            con.Open();

            using var cmd = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader dataReader = cmd.ExecuteReader();

            List<DataItem> item = new List<DataItem>();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string nama = dataReader.GetString(1);
                string username = dataReader.GetString(2);
                //string password = dataReader.GetString(3);
                string bio = dataReader.GetString(4);

                item.Add(new DataItem() { key = "id", value = id.ToString() });
                item.Add(new DataItem() { key = "nama", value = nama });
                item.Add(new DataItem() { key = "username", value = username });
                //item.Add(new DataItem () { key="password", value=password});
                item.Add(new DataItem() { key = "bio", value = bio });
            }

            con.Close();

            return item;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}