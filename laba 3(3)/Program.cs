using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_3_
{

    class Program
    {
        private List<Nuembers> ListNum = new List<Nuembers>();
        public void AddNum(Nuembers nuembers)
        {
            ListNum.Add(nuembers);
        }
        public List<Nuembers> GetNum()
        {
            return ListNum;
        }
        

        
    }
}
