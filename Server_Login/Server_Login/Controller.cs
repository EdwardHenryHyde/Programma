using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Login
{
    class Controller
    {

        private StreamWriter _scrittoreLog;
        private DbConnection _connessioneDB;

        public Controller(StreamWriter scrittoreLog, DbConnection connessioneDB)
        {
            _scrittoreLog = scrittoreLog ?? throw new ArgumentNullException(nameof(scrittoreLog));
            _connessioneDB = connessioneDB ?? throw new ArgumentNullException(nameof(connessioneDB));
        }

        public StreamWriter ScrittoreLog { get => _scrittoreLog; set => _scrittoreLog = value; }
        public DbConnection ConnessioneDB { get => _connessioneDB; set => _connessioneDB = value; }

    }
}
