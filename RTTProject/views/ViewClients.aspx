<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewClients.aspx.cs" Inherits="RTTProject.views.ViewClients" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <link href="~/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
      <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    <Columns>
    <asp:BoundField DataField="Id" HeaderText="ClientId" ItemStyle-Width="150" />
    <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
    <asp:BoundField DataField="Surname" HeaderText="Surname" ItemStyle-Width="100" />
    <asp:BoundField DataField="Gender" HeaderText="Gender" ItemStyle-Width="100" />
    <asp:BoundField DataField="ResidentialAddress" HeaderText="ResidentialAddress" ItemStyle-Width="100" />
    <asp:BoundField DataField="WorkAddress" HeaderText="WorkAddress" ItemStyle-Width="100" />
    <asp:BoundField DataField="CellNumber" HeaderText="CellNumber" ItemStyle-Width="100" />        
     <asp:BoundField DataField="WorkNumber" HeaderText="WorkNumber" ItemStyle-Width="100" />
     </Columns>
    </asp:GridView>
            <asp:Button ID="btnExport" runat="server" Text="Export" OnClick="btnExport_Click" />
          <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
           <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnDelete_Click" />
          </form>
  


</body>
</html>
