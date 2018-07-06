using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_GestoreSicurezza
{
    class Log
    {

        List<Entry> entryLog;

        public Log(List<Entry> entryLog)
        {
            this.entryLog = entryLog ?? throw new ArgumentNullException(nameof(entryLog));
        }

        internal List<Entry> EntryLog { get => entryLog; set => entryLog = value; }
    }
}
