using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Section5DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test of open and close of SQL Connection Class

            var sqlConn = new SQLConnection("abc");
            sqlConn.OpenDBConnection();
            sqlConn.CloseDBConnection();

            // Test of open and close of Oracle Connection Class

            var oracleConn = new OracleConnection("123");

            oracleConn.OpenDBConnection();
            oracleConn.CloseDBConnection();

            //test of empty string passed for connection string - should throw an exception
            // comment out test to proceed with rest of test cases.
         //   var sqlConn2 = new SQLConnection("");

            //test of null string passed for connection string - should throw an exception
            // comment out test to proceed with rest of test cases.

         //   var oracleConn2 = new OracleConnection(null);

            //test to ensure can't open an already open connection - should throw an exception
            // comment out test to proceed with rest of test cases.
        //    sqlConn.OpenDBConnection();
        //    sqlConn.OpenDBConnection();

            //test to ensure cant close an already closed connection - should throw an exception

            oracleConn.CloseDBConnection();
        }
    }

    
}
