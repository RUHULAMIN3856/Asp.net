using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Chapter6
{
    public partial class OnlineApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 3)
            {
                lblName.Text = txtName.Text;
                if (radioMale.Checked)
                {
                    lblgender.Text = radioMale.Text;
                }
                if(radioFemale.Checked)
                {
                    lblgender.Text = radioFemale.Text;
                }

                lblEmail.Text = txtemail.Text;
                lblPhone.Text = txtPhone.Text;
              
                if (CheckSSC.Checked)
                {
                    lblSSC.Text = CheckSSC.Text;
                }
                if (ChecHSC.Checked)
                {
                    lblHSC.Text = ChecHSC.Text;
                }
                if (CheckBA.Checked)
                {
                    lblHonours.Text = CheckBA.Text;
                }
                if (CheckMasters.Checked)
                {
                    lblMasters.Text = CheckMasters.Text;
                }
                Image2.ImageUrl = Image1.ImageUrl;
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Image/");
            if (!Directory.Exists(folderPath))
            {
              
                Directory.CreateDirectory(folderPath);
            }
           
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName)); 

            Image1.ImageUrl = "~/Image/" + Path.GetFileName(FileUpload1.FileName);
        }
    }
}