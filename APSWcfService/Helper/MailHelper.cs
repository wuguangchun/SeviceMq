using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace APSWcfService.Helper
{

    public class MailHelper
    {
        public void SendMail(string content, string title, string address)
        {
            MailAddress from = new MailAddress("aps@kutesmart.com", "APS项目汇报邮件-酷特智能"); //邮件的发件人

            MailMessage mail = new MailMessage();

            //设置邮件的标题
            mail.Subject = title;

            //设置邮件的发件人
            //Pass:如果不想显示自己的邮箱地址，这里可以填符合mail格式的任意名称，真正发mail的用户不在这里设定，这个仅仅只做显示用
            mail.From = from;

            //设置邮件的收件人 
            /*  这里这样写是因为可能发给多个联系人，每个地址用 ; 号隔开
              一般从地址簿中直接选择联系人的时候格式都会是 ：用户名1 < mail1 >; 用户名2 < mail 2>; 
              因此就有了下面一段逻辑不太好的代码
              如果永远都只需要发给一个收件人那么就简单了 mail.To.Add("收件人mail");
            */

            mail.To.Add(new MailAddress(address, "APS"));

            //设置邮件的内容
            mail.Body = content;
            //设置邮件的格式
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            //设置邮件的发送级别
            mail.Priority = MailPriority.Normal;

            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

            SmtpClient client = new SmtpClient();
            //设置用于 SMTP 事务的主机的名称，填IP地址也可以了
            client.Host = "smtp.kutesmart.com";
            //设置用于 SMTP 事务的端口，默认的是 25
            //client.Port = 25;
            client.UseDefaultCredentials = false;
            //这里才是真正的邮箱登陆名和密码，比如我的邮箱地址是 hbgx@hotmail， 我的用户名为 hbgx ，我的密码是 xgbh
            client.Credentials = new System.Net.NetworkCredential("aps@kutesmart.com", "redcollar@123");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //都定义完了，正式发送了，很是简单吧！
            try
            {
                client.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}