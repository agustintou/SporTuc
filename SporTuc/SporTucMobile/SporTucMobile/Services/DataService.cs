﻿using SporTucMobile.Data;
using System.Collections.Generic;
using System.Linq;

namespace SporTucMobile.Services
{
    public class DataService
    {
        public T DeleteAllAndInsert<T>(T model) where T : class
        {
            try
            {
                using (var da = new DataAccess())
                {
                    var oldRecords = da.Get<T>(false);
                    foreach (var oldRecord in oldRecords)
                    {
                        da.Delete(oldRecord);
                    }

                    da.Insert(model);

                    return model;
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
                return model;
            }
        }

        public T InsertOrUpdate<T>(T model) where T : class
        {
            try
            {
                using (var da = new DataAccess())
                {
                    var oldRecord = da.Find<T>(model.GetHashCode(), false);
                    if(oldRecord != null)
                    {
                        da.Update(model);
                    }
                    else
                    {
                        da.Insert(model);
                    }

                    return model;
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
                return model;
            }
        }

        public T Insert<T>(T model)
        {
            using (var da = new DataAccess())
            {
                da.Insert(model);
                return model;
            }
        }

        public T Find<T>(int pk, bool WithChildren) where T : class
        {
            using (var da = new DataAccess())
            {
                return da.Find<T>(pk, WithChildren);
            }
        }

        public T First<T>(bool WithChildren) where T : class
        {
            using (var da = new DataAccess())
            {
                return da.Get<T>(WithChildren).FirstOrDefault();
            }
        }

        public List<T> Get<T>(bool WithChildren) where T : class
        {
            using (var da = new DataAccess())
            {
                return da.Get<T>(WithChildren).ToList();
            }
        }

        public void Update<T>(T model)
        {
            using (var da = new DataAccess())
            {
                da.Update(model);
            }
        }

        public void Delete<T>(T model)
        {
            using (var da = new DataAccess())
            {
                da.Delete(model);
            }
        }

        public void Save<T>(List<T> list) where T : class
        {
            using (var da = new DataAccess())
            {
                foreach (var record in list)
                {
                    InsertOrUpdate(record);
                }
            }
        }
    }
}
