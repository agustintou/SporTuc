﻿using SporTucMobile.Interfaces;
using SporTucMobile.iOS.Implementations;
using SQLite;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Config))]
namespace SporTucMobile.iOS.Implementations
{
    public class Config : IConfig
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var sqlDbFileName = "SporTuc2018.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentsPath, sqlDbFileName);

            var connection = new SQLiteAsyncConnection(path);

            return connection;
        }
    }
}