﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace test
{
    class AdoNet
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connexionString;
        private DataTable dtCat;
        private DataTable dtbooks;
        private DataSet ds;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnexionString { get => connexionString; }
       // public DataTable Dt { get => dt; set => dt = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public DataTable DtCat { get => dtCat; set => dtCat = value; }
        public DataTable Dtbooks { get => dtbooks; set => dtbooks = value; }

        public AdoNet()
        {
            connexionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
            connection = new SqlConnection(connexionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            

        }
       
    }
}
