using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Project.COMMON.Tools
{
    public class MailSender
    {
      
        public static void Send(string receiver="tano7399@hotmail.com",string password="Sinemaotomasyonu",string body="Deneme",string subject="Test",string sender="cineflex@hotmail.com")
        {

            MailAddress senderEmail = new MailAddress(sender);

            MailAddress receiverEmail = new MailAddress(receiver);//burada item.Email kullanılacak.

          
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)     
        };          

            using (var mesaj = new MailMessage(senderEmail, receiverEmail)
            {
                //Object initializer
                Subject = subject,
                Body =body
            })
            {
                //using scope'u
                smtp.Send(mesaj); //Mail gönderildi.
               
            }
        }
       
    }
}