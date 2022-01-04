using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clustering.Migrations;
using Clustering.Objects;

namespace Clustering.DataBase
{
    public class SQLiteLoader : IDBLoader
    {
        private ClusteringContext _context;

        public SQLiteLoader()
        {
            _context = new ClusteringContext();
        }

        public CleanSet GetSetByName(string name)
        {
            return _context.CleanSets.FirstOrDefault((s) => s.Name == name);
        }

        public CleanSet GetSetById(int id)
        {
            return _context.CleanSets.FirstOrDefault((s) => s.CleanSetId == id);

        }

        public RawSet GetRawSetByName(String name)
        {
            return _context.RawSets.FirstOrDefault((s) => s.SourceName == name);
        }

     

        public void ClearAllEntry()
        {
            _context.ClearAllTable();
            _context.SaveChanges();
        }
        public void AddSet(CleanSet set)
        {
            _context.CleanSets.Add(set);
            _context.SaveChanges();
        } 
        public void AddSet(RawSet set)
        {
            _context.RawSets.Add(set);
            _context.SaveChanges();
        }

        public void Update(CleanSet set)
        {
            _context.CleanSets.Update(set);
        }

    }
}