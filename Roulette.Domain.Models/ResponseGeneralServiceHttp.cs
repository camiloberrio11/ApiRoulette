using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Domain.Models
{
    public class ResponseGeneralServiceHttp
    {
        public object Errors { get; set; }
        public object Result { get; set; }
        public bool IsSuccess { get; set; }
    }
}
