using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntegraBrasil.Model.Responses
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? ReturnData { get; set; }
        public ExpandoObject? ReturnError { get; set; }
    }
}
