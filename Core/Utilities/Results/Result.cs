using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        // Asagidakiler readonlydir sadece constructor icerisinde set edilebilirler
        public bool Success { get; }
        public string Message { get; }
    }
}
