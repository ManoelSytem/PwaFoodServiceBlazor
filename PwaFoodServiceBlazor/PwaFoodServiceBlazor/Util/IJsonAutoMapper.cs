using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaFoodServiceBlazor.Util
{
    public interface IJsonAutoMapper
    {
        public T ConvertAutoMapperJson<T>(object obj);
        public List<T> ConvertAutoMapperListJson<T>(IEnumerable<object> obj);
        public List<T> ConvertAutoMapperListJsonString<T>(string Jsonvalor);
    }
}
