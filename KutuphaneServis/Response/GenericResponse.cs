using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneServis.Response
{
   public class GenericResponse<T>: Response
    {
        public T Data { get; set; }
        public GenericResponse(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
            Data = data;
        }
        public static GenericResponse<T> Success(T data, string message = "")
        {
            return new GenericResponse<T>(data, true, message );
        }
        public static GenericResponse<T> Error(string message = "")
        {
            return new GenericResponse<T>(default(T) ,false, message);
        }


    }
}
