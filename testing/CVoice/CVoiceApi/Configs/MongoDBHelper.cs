using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVoiceApi.Configs
{
    public class MongoDBHelper<T> where T : class
    {
        public MongoCollection<T> Collection { get; private set; }

        public MongoDBHelper()
        {

            var con = new MongoClient("mongodb://localhost:27017");
            var database = con.GetDatabase("CVoice");
            Collection = database.GetCollection<T>(typeof(T).Name.ToLower()) as MongoCollection<T>;
        }
    }
}
