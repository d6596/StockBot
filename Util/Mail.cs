using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Util
{
    class Mail
    {
        SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
        string fromMailAddr_ = "구글계정";
        string passwd = "Goole_password";
        string toMailADdr_;
        string subject_;
        string body_;
        string attacheFile_ = "";

        public Mail()
        {

        }

        public void setToMailAddr(string str)
        {

        }
        public void setSubject(string str)
        {

        }

        public void setBody(string str)
        {

        }

        public void setAttachFile(string str)
        {

        }
        public void send()
        {

        }

    }
}
