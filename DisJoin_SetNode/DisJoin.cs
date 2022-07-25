using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisJoin_SetNode
{
    public class DisJoin<T>
    {
        public T Value { get; set; }
        public int Rank { get; set; }
        public DisJoin<T> Parent { get; set; }
        public DisJoin()
        {

        }

        public DisJoin(T value)
        {
            Value = value;
            Rank = 0;
        }

        public DisJoin(T value, int rank)
        {
            Value = value;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Value}"; 
        }
    }
}
