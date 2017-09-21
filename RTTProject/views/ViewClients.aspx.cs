using RTTProject.RTTServicesReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RTTProject.views
{
    public partial class ViewClients : System.Web.UI.Page
    {
        BusinessLogicClient objServiceClient = new BusinessLogicClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientDetails client = new ClientDetails();
          
            GridView1.DataSource = objServiceClient.GetClientData().ClientTable;
            GridView1.DataBind();
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            string txt = string.Empty;

            foreach (TableCell cell in GridView1.HeaderRow.Cells)
            {
                txt += cell.Text + "\t\t";
            }
            txt += "\r\n";

            foreach (GridViewRow row in GridView1.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    txt += cell.Text + "\t\t";
                }
                txt += "\r\n";
            }
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=Clientdetails.txt");
            Response.Charset = "";
            Response.ContentType = "application/text";
            Response.Output.Write(txt);
            Response.Flush();
            Response.End();
        }

        protected void btnDelete_Click(object sender,EventArgs e)
        {

            //ClientData clientdata = new ClientData();
            //clientdata = string(e.CommandArgument.ToString());
            //objServiceClient.DeleteDetails(clientdata);
            //Page_Load()
            //int Id = Convert.ToInt32(GridView1.DataKeys[e.RoxIndex].Values[0]);
            // ClientData service = new ClientData();
            //service.Delete(Id);
            // this.DataBind();

        }

       
    }
}