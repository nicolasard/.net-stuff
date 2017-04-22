using RestClientExample.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace RestClientExample
{
    class gitHubRestClient :RestClient 
    {
        public List<repo> getAllRepos()
        {
            //List<Repo> serializer = new DataContractJsonSerializer(typeof(List<Repo>));
            var serializer = new DataContractJsonSerializer(typeof(List<repo>));

            return serializer;
        }
    }
}
