using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCFirstTesting
{
    public class SqlDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("The information about using [SqlDAL]");
        }
    }
    public class OracleDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("The information about using [OracleDAL]");
        }
    }

    public class DBManager
    {
        IDAL _dal;
        public DBManager(IDAL dal)
        {
            _dal = dal;
        }
        public void Add(string commandText)
        {
            _dal.Insert(commandText);
        }
    }
}
