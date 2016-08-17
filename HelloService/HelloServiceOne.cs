using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    class HelloServiceOne:IHelloService
    {

        public string GetMessage(string name)
        {
            return name + " resides in Bengaluru !!";
        }
    }
}
