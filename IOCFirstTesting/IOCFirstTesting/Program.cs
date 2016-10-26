using Autofac;
using Autofac.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCFirstTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DBManager>();
            builder.RegisterType<OracleDAL>().As<IDAL>();
            using (var container = builder.Build())
            {
                var manager = container.Resolve<DBManager>();
                manager.Add("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')");
            }



            Console.ReadLine();
        }
    }
}
