using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Reflection;
using BLL.Repositories;

namespace TestData
{
    class Program
    {
        class ABC
        {
            public ABC(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            List<ABC> abcs = new List<ABC>();
            abcs.Add(new ABC(1, 2));
            abcs.Add(new ABC(1, 3));
            abcs.Add(new ABC(1, 7));
            abcs.Add(new ABC(1, 2));
            abcs.Add(new ABC(1, 9));
            abcs.Add(new ABC(1, 4));
            abcs.Add(new ABC(1, 1));
            var u = abcs.OrderBy(a => a.y);

            foreach (var a in u)
                Console.WriteLine(a.y);
        }
    }
}
