using System;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Clustering.Objects;

namespace Clustering.Normalizers
{
    public class AreaNormalizer : INormalizer
    {
        private float _width, _height;
        private double maxX, maxY, minX, minY;
        public AreaNormalizer(float Width, float Height)
        {
            _width = Width;
            _height = Height;
        }
        public CleanObject Normalize(RawObject obj, CleanSet newSet)
        {
            var data = obj.ObjData;

            if (minX < 0)
            {
                data[0] += Math.Abs(minX);
            }

            data[0] = (data[0] * _width) / maxX;
            if (minY < 0)
            {
                data[1] += Math.Abs(minY);
            }

            data[1] = (data[1] * _height) / maxY ;
            var o = new CleanObject();
            o.ObjData = data;
            o.CleanSet = newSet;
            return o;
        }


        public CleanSet Normalize(RawSet data)
        {

            if (data.RawObjects.Count > 0)
            {
                var obj = data.RawObjects[0];
                maxX = minX = obj.ObjData[0];
                maxY = minY = obj.ObjData[1];
                foreach (var objc in data.RawObjects)
                {
                    maxX = Math.Max(maxX, objc.ObjData[0]);
                    maxY = Math.Max(maxY, objc.ObjData[1]);
                    minX = Math.Min(minX, objc.ObjData[0]);
                    minY = Math.Min(minY, objc.ObjData[1]);
                }

                if (minX < 0) maxX -= minX;
                if (minY < 0) maxY -= minY;
            }

            CleanSet clean = new CleanSet();
            foreach (var rawObj in data.RawObjects)
            {
                clean.CleanObjects.Add(Normalize(rawObj, clean));
            }

            clean.Name = "Нормализованные " + data.SourceName;
            return clean;

        }

    }
}