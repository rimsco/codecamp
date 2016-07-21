using CVoiceApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVoiceApi.Repositories
{
    public interface IApplication
    {
        List<Application> GetAll();
        bool Create(Application obj);
        bool Edit(Application obj);
        Application GetOne(ObjectId id);
    }
}
