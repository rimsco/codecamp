using CVoiceApi.Models.Entities;
using CVoiceApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using CVoiceApi.Configs;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Builders;

namespace CVoiceApi.Implements
{
    public class UowApplication: IApplication
    {
        private readonly MongoDBHelper<Application> _mob = new MongoDBHelper<Application>();

        public List<Application> GetAll()
        {
            var query = _mob.Collection.FindAllAs<Application>().ToList();
            return query;
        }

        public bool Create(Application objInput)
        {
            try
            {
                _mob.Collection.Save(objInput);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool Edit(Application objInput)
        {
            try
            {
                var iqr = Query<Application>.EQ(p => p.Id, objInput.Id);
                var operation = Update<Application>.Replace(objInput);
                _mob.Collection.Update(iqr, operation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public Application GetOne(ObjectId id)
        {
            var iqr = _mob.Collection.FindOneById(id);
            return iqr;
        }


    }
}
