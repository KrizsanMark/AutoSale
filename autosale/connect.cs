﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosale
{
    public class connect
    {
        public MySqlConnection Connection;
        private string Host;
        private string Database;
        private string User;
        private string Password;
        private string ConnectionString;

        public connect()
        {
            Host = "127.0.0.1";
            Database = "auto";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";
            Connection = new MySqlConnection(ConnectionString);

        }

    }
}
