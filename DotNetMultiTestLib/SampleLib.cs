using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMultiTestLib
{
    public class SampleLib
    {
        private static List<string> data=new List<string>(){"Hello","World"};
        public string GetValueByIndex(int Index) {
            return data.GetRange(Index, 1).SingleOrDefault();
        }
    }
}
