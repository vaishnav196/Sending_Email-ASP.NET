using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Email_Integration
{
    public partial class SendingMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           MailMessage mail = new MailMessage();
           mail.From = new MailAddress("vaish00721@gmail.com");
            mail.To.Add(ListBox1.Text);
            mail.Subject=TextBox2.Text;
            mail.Body=TextBox3.Text;


            if (FileUpload1.HasFile)
            {
                 //for multiple attachment
                foreach (HttpPostedFile uploadedFile in FileUpload1.PostedFiles)
                {
                    Attachment attachment = new Attachment(uploadedFile.InputStream, uploadedFile.FileName);
                    mail.Attachments.Add(attachment);

                    //Attachment attachment = new Attachment(uploadedFile.InputStream, System.IO.Path.GetFileName(uploadedFile.);
                    //mail.Attachments.Add(attachment);
                }
               

               
            }

          
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Credentials = new NetworkCredential("", "");
          
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);

            Response.Write("<script>alert('Email Send Succesfully !!!')</script>");


        }
    }
}