<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientRegistration.aspx.cs" Inherits="RTTProject.ClientRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Client Registration</title>
     <link href="~/css/bootstrap.css" rel="stylesheet" />
    <style>
        body {
           background-image:url("~/images/clientlogin.png" );
        }
        </style>

</head>
<body >
    <form id="form1" runat="server">
      <div class="col-sm-3 col-md-6 col-lg-4">
          </div>


         <div class="col-sm-3 col-md-6 col-lg-4">
               
            <table>
        <tr> 
            <td>
                <h1> Client Registration</h1>
            </td>

        </tr>

        <tr> 
            <th> <asp:Label ID="Lable1" runat="server" Text="Name"></asp:Label></th>
            <td> <asp:TextBox ID="txtname" runat="server" ></asp:TextBox></td>
        </tr>
        <tr> 
            <th><asp:Label ID="Label1" runat="server" Text="Surname"></asp:Label></th>
            <td> <asp:TextBox ID="txtsurname" runat="server" ></asp:TextBox></td>
        </tr>
        <tr> 
           <th> <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label></th>
            <td> <asp:TextBox ID="txtgender" runat="server" ></asp:TextBox></td>
        </tr>
        <tr> 
            <th><asp:Label ID="Label3" runat="server" Text="ResidentialAddress"></asp:Label></th>
            <td> <asp:TextBox ID="txtResidentialAddress" runat="server" ></asp:TextBox></td>

        </tr>
        <tr> 
           <th> <asp:Label ID="Label4" runat="server" Text="WorkAddress"></asp:Label></th>
            <td> <asp:TextBox ID="txtworkAddress" runat="server" ></asp:TextBox></td>
        </tr>
        <tr> 
           <th> <asp:Label ID="Label5" runat="server" Text="CellNumber"></asp:Label></th>
            <td class="auto-style1"> <asp:TextBox ID="CellNumber" runat="server" ></asp:TextBox></td>
        </tr>
        <tr> 
            <th><asp:Label ID="Label6" runat="server" Text="WorkNumber"></asp:Label></th>
            <td> <asp:TextBox ID="txtworkNumber" runat="server" ></asp:TextBox></td>
        </tr>
  
        <tr>
            <th> <asp:Label ID="Label7" runat="server" Text="WorkNumber"></asp:Label>

            </th>
            <td> <asp:TextBox ID="txtCellNumber" runat="server" ></asp:TextBox></td>
        </tr>
        
           <a href="views/ViewClients.aspx">View all Clients</a> 
             
                   </table>
               
              <asp:Button ID="btnRegisterClient" runat="server" Text="Register Client" OnClick="btnRegisterClient_Click1" />
                  </div>
      
    <div class="col-sm-3 col-md-6 col-lg-4">
          </div>
 
       
      
    </form>
     
</body>
</html>
