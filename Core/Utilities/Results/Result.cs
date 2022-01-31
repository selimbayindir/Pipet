using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

       
        public Result(bool success, string message):this(success) //public Result(bool success) iki paremetre gelşirse bunu buradan al dersin
        {
            //this.Success = success;
            //this.Message = message;

            Message = message;
          //  Success = success;
        }
        public Result(bool success)
        {
            //this.Success = success;
            //this.Message = message;

         //   Message = message;
            Success = success;
        }

        public bool Success { get; } // getter read only dir Constructorda set edilebilir.

        public string Message { get; }
    }
}
