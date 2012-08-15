using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

using Noble.Models;

namespace Noble.Infrastructure.Data
{

    public class MongoRepository<T> : IRepository<T> where T : IModel
    {
        private readonly MongoServer _server;
        private readonly MongoDatabase _database;
        private readonly MongoCollection<T> _collection;

        public MongoRepository()
        {
            _server = MongoServer.Create(ConfigurationManager.AppSettings["MONGOHQ_URL"]);
            _database = _server.GetDatabase(ConfigurationManager.AppSettings["DatabaseName"]);

            var collectionName = GetCollectionName(typeof(T));
            _collection = _database.GetCollection<T>(collectionName);
        }

        private string GetCollectionName(Type t)
        {
            return t.Name.ToLower();
        }

        public T GetById(Guid id)
        {
            var query = Query.EQ("_id", id);
            return _collection.FindOne(query);
        }

        public void Delete(T entity) 
        {

            var query = Query.EQ("_id", ((IModel)entity).Id);            
            _collection.Remove(query);
        }

        public T Save(T entity)
        {
            _collection.Save<T>(entity);
            return entity;
        }

        public IList<T> GetAll()
        {
            return _collection.FindAll().ToList();
        }

    }
}