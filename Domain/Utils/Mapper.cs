
using AutoMapper;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Papa.Core.Domain.Utils
{
    public static class ObjectMapper
    {
        public static T Map<S, T>(S source)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<S, T>());
            var mapper = new Mapper(config);            

            return mapper.DefaultContext.Mapper.Map<S, T>(source);

        }
        public static IEnumerable<T> Map<S, T>(IEnumerable<S> source)        
        {
            Collection<T> res = new Collection<T>();
            foreach (var itemS in source)
            {                
                var itemT = ObjectMapper.Map<S, T>(itemS);
                res.Add(itemT);
            }
            return res;
        }

    }
}
