using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Project.COMMON.Tools
{
    public static class MailSender
    {
      
        public static void Send(string receiver,string password="123456asd",string body="Deneme",string subject="Test",string sender="CineFlexYonetimm@outlook.com")
        {

            MailAddress senderEmail = new MailAddress(sender);

            MailAddress receiverEmail = new MailAddress(receiver);//burada item.Email kullanılır


            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
                //üst satırda ikinci argüman bilerek bos bırakılmıstır. Buraya normalde senderemail'in passwordunu yazarsınız. Mevcut durumuyla program calısmayacaktır. Passwordunuzu kendinize göre doldurun.
            };

            
            

            using (var mesaj = new MailMessage(senderEmail, receiverEmail)
            {
                //Object initializer
                Subject = subject,
                Body =body
            })
            {
                //using scope'u
                smtp.Send(mesaj); //Mail'i gönderdik.
            }

            

       
        }


       
    }
}