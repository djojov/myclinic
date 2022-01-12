<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentationLayerWeb.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" Runat="Server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary sticky-top">
             <div class="container">
                <a class="navbar-brand" href="#">MyClinic</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                      <li class="nav-item active">
                        <a class="nav-link" href="#">Login <span class="sr-only">(current)</span></a>
                      </li>
                    </ul>
                </div>
            </div>
        </nav>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container my-5 d-flex justify-content-center">
        <div id="login_Form" class="border border-primary p-5 bg-light">
          <div class="form-group">
              <asp:DropDownList ID="DropDownList_LoginType" runat="server" CssClass="custom-select">
                  <asp:ListItem Text="Select login type" Value="1" Selected="True"/>
                  <asp:ListItem Text="Admin" Value="2"/>
                  <asp:ListItem Text="Doctor" Value="3"/>
                  <asp:ListItem Text="Patient" Value="4"/>
              </asp:DropDownList>
          </div>
          <div class="form-group">
            <label for="login_email">Email address</label>
              <input type="email" class="form-control" id="login_email" runat="server" aria-describedby="emailHelp">
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
              <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ErrorMessage="E-mail entered incorrectly!" Text="E-mail entered incorrectly!" ControlToValidate="login_email" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator></small>
          </div>
          <div class="form-group">
            <label for="login_password">Password</label>
            <input type="password" class="form-control" id="login_password" runat="server" />
            <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Password" runat="server" ErrorMessage="Password entered incorrectly!" Text="Password entered incorrectly!" ControlToValidate="login_password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$"></asp:RegularExpressionValidator></small>
          </div>
           <asp:Button CssClass="btn btn-primary mt-3" ID="Button_Submit" runat="server" Text="Log in" OnClick="Button_Submit_Click" />
        </div>
    </div>

</asp:Content>
