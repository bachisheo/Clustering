using System;
using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.DataBase
{
    public interface IDBLoader
    {
        public void AddSet(CleanSet set);
        public CleanSet GetSetByName(String name);
        public CleanSet GetSetById(int id);
        public RawSet GetRawSetByName(String name);

        public void ClearAllEntry();

    }
}