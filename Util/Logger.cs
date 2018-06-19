using System;
using System.IO;
using System.Windows.Forms;
using KiwoomCode;

namespace StockBot.Util
{
    class Logger : SingleTon<Logger>
    {
        private ListView listView_ = null;
        private TextWriter logFile_ = null;
        private string fileName_ = "";
        private bool logActive_;

        public void close()
        {

        }
        public void setup(ListView listView)
        {

        }


        public string getFileName()
        {
            return fileName_;
        }


        void fileWrite(Logger type , string log)
        {

        }

        void printLog(Log type, string log)
        {

        }

        public void print(Logger type ,string format, params Object[] args)
        {

        }

        public void consolePrint(string format,params Object[] args)
        {

        }

    }
}
