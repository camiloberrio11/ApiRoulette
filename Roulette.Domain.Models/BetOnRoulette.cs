using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Domain.Models
{
    public class BetOnRoulette
    {
        public int Idbet { get; set; }
        public bool IsRed { get; set; }
        public bool IsBlack { get; set; }
        public int BetNumber { get; set; }
        public int Money { get; set; }
        public int Idroulette {get; set;}
        public string UserId { get; set; }
    }
}
