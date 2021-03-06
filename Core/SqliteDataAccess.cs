﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseStorageSystem
{
    public class SqliteDataAccess
    {
        public static List<ProductModel> LoadProducts()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("select * from Products", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveProduct(ProductModel product) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Products (Name, Description, Price, Quantity, Supplier) values (@Name, @Description, @Price, @Quantity, @Supplier)", product);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
