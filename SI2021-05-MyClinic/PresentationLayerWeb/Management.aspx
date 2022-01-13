<%@ Page Title="Patient management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="PresentationLayerWeb.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Navigation" runat="server">
     <nav class="navbar navbar-expand-lg navbar-dark bg-primary sticky-top">
             <div class="container">
                <a class="navbar-brand" href="#">
                    <img src="/Content/logo.png" width="30" height="30" class="d-inline-block align-top" alt="Logo not loaded">
                    MyClinic
                  </a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                      <li class="nav-item">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/PatientPanel.aspx">Patient panel</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                          <asp:HyperLink CssClass="nav-link active" ID="HyperLink2" runat="server" NavigateUrl="~/Management.aspx">Patient Management<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:Button CssClass="nav-link" ID="Button_Logout" runat="server" Text="Log out" OnClick="Button_Logout_Click"></asp:Button>
                      </li>
                    </ul>
                </div>
            </div>
        </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container my-5">
        <div class="row">
            <div class="col-5">
                <div class="form-group row">
                    <asp:Label ID="Label_Id" runat="server" Text="Id:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Id" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Weight" runat="server" Text="Weight:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Weight" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Weight" runat="server" ErrorMessage="Weight entered incorrectly!" Text="Weight entered incorrectly!" ControlToValidate="TextBox_Weight" ValidationExpression="^[0-9]*[1-9][0-9]*$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Height" runat="server" Text="Height:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Height" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Height" runat="server" ErrorMessage="Height entered incorrectly!" Text="Height entered incorrectly!" ControlToValidate="TextBox_Height" ValidationExpression="^[0-9]*[1-9][0-9]*$"></asp:RegularExpressionValidator></small>
                </div>
            </div>
            <div class="col-1"></div>
            <div class="col-6">
                <div class="form-group row">
                    <asp:Label ID="Label_Email" runat="server" Text="E-mail:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Email" runat="server"></asp:TextBox>
                     <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ErrorMessage="E-mail entered incorrectly!" Text="E-mail entered incorrectly!" ControlToValidate="TextBox_Email" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PhoneNumber" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PhoneNumber" runat="server" ErrorMessage="Phone number entered incorrectly!" Text="Phone number entered incorrectly!" ControlToValidate="TextBox_PhoneNumber" ValidationExpression="^[0][6]\d{1}[1-9]\d{2,3}\d{3,4}$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Password" runat="server" Text="Password:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Password" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Password" runat="server" ErrorMessage="Password entered incorrectly!" Text="Password entered incorrectly!" ControlToValidate="TextBox_Password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$"></asp:RegularExpressionValidator></small>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button CssClass="btn btn-primary" OnClick="Button_UpdateSelf_Click" ID="Button_UpdateSelf" Text="Update data" runat="server" /> 
            </div>
        </div>
    </div>
</asp:Content>
