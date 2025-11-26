using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Database
{
    internal class DbContext
    {
        public string? connStr;

        public DbContext()
        {
            Env.Load();
            connStr = Environment.GetEnvironmentVariable("CONN_STR");

            if (string.IsNullOrEmpty(connStr))
                MessageBox.Show("Koneksi DB tidak ditemukan! Pastikan file .env ada dan variabel CONN_STR benar.");
        }
    }
}
