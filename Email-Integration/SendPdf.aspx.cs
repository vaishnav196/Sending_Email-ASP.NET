using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Email_Integration
{
    public partial class SendPdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get data from text fields
            string email = TextBox1.Text;
            string id = TextBox2.Text;
            string name = TextBox3.Text;
            string salary = TextBox4.Text;

            try
            {
                // Generate PDF
                using (MemoryStream ms = new MemoryStream())
                { 
                    //Document class is FormatException generating pdf 
                    Document document = new Document(PageSize.A4);
                    PdfWriter.GetInstance(document, ms);
                    document.Open();

                    document.Add(new Paragraph("Employee Details"));
                    document.Add(new Paragraph($"Email: {email}"));
                    document.Add(new Paragraph($"ID: {id}"));
                    document.Add(new Paragraph($"Name: {name}"));
                    document.Add(new Paragraph($"Salary: {salary}"));

                    document.Close();

                    // Send Email with PDF attachment
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("vaish00721@gmail.com");
                        mail.To.Add(email);
                      //  mail.Subject = "Employee Details";
                       // mail.Body = "Please find the attached PDF with employee details.";

                        // Attach PDF to email
                        Attachment attachment = new Attachment(new MemoryStream(ms.ToArray()), "EmployeeDetails.pdf");
                        mail.Attachments.Add(attachment);

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                        {
                            smtp.Credentials = new NetworkCredential("vaish00721@gmail.com", "kzuvycbbvbrdempp");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.Send(mail);
                        }
                    }
                }

                // Show success message
                Response.Write("<script>alert('Email sent successfully!')</script>");
            }
            catch (Exception ex)
            {
                // Show error message
                Response.Write($"<script>alert('Error sending email: {ex.Message}')</script>");
            }
        }
    }
}