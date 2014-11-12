﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HolidayMailerCSCD350
{
    class Database
    {
        private String connectionString;
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private String str;

        public Database(String connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new SQLiteConnection(this.connectionString);
            this.str = "";

            connection.Open();
        }

        //SQL INJECTION PREVENTION DOES NOT WORK - @X must truly be storing a value, not statements
        public void insert(string into, string values)
        {
            str = "INSERT INTO " + into + " VALUES @values";
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("@values", values);
            command.ExecuteNonQuery();
        }

        public void select(string from, string values)
        {
            str = "SELECT " + from + " FROM @values";
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("@values", values);
        }

        public void select(string from, string values, string where)
        {
            str = "SELECT " + from + " FROM @values WHERE @where";
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("@values", values);
        }

        public void close()
        {
            connection.Close();
        }

    }
}
