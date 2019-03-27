using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class IntMap<T> : Dictionary<T,int>
    {
        public new int this[T key]
        {
            get
            {
                if (ContainsKey(key)) return base[key];
                return 0;
            }
            set
            {
                if (ContainsKey(key)) base[key] = value;
                else Add(key,value);
            }
        }
    }
}
