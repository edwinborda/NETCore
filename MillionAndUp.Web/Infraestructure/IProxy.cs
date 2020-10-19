using RestSharp;
using System.Collections.Generic;

namespace MillionAndUp.Web.Infraestructure
{
    public interface IProxy<TModel> where TModel: class
    {
        IEnumerable<TModel> Get(string baseUrl, string endpoint);

        IRestResponse Post(string baseUrl, string endpoint, TModel model);

    }
}
