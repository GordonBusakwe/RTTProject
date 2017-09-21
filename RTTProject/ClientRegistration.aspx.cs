
using RTTProject.RTTServicesReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RTTProject
{
    public partial class ClientRegistration : System.Web.UI.Page
    {
       

     BusinessLogicClient objServiceClient = new BusinessLogicClient();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void btnRegisterClient_Click1(object sender, EventArgs e)
        {
            try
            {
                ClientDetails clients = new ClientDetails();
                clients.Name = txtname.Text;
                clients.Surname = txtsurname.Text;
                clients.Gender = txtgender.Text;
                clients.ResidentialAddress = txtResidentialAddress.Text;
                clients.WorkAddress = txtworkAddress.Text;
                clients.WorkNumber = txtworkNumber.Text;
                clients.CellNumber = txtCellNumber.Text;
                objServiceClient.InsertUserDetails(clients);
            }
            catch (Exception ex)
            {
                throw(ex); 
            }
        }

    }
}