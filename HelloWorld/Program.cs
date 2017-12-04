using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.APIService;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldService sayHello = new HelloWorldService();
            sayHello.Message();
        }
    }
}
