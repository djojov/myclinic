<%@ Page Title="Admin Panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="PresentationLayerWeb.AdminPanel" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" Runat="Server">
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
                      <li class="nav-item active">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/AdminPanel.aspx">Admin panel<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                      <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink2" runat="server" NavigateUrl="~/DoctorManagement.aspx">Doctor management</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink3" runat="server" NavigateUrl="~/InsertDoctor.aspx">Insert doctor</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:Button CssClass="nav-link" ID="Button_Logout" runat="server" Text="Log out" OnClick="Button_Logout_Click"></asp:Button>
                      </li>
                    </ul>
                </div>
            </div>
        </nav>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container my-5">
        <div class="row">
            <div class="col">
                <div class="formmain card bg-light p-5">
                 <div class="form-group row">
        <asp:Label ID="Label_FirstName" runat="server" Text="Fist name:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="TextBox_FirstName" runat="server" ReadOnly="True"></asp:TextBox>
    </div>
        <div class="form-group row">
    <asp:Label ID="Label_LastName" runat="server" Text="Last name:"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox_LastName" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
        <div class="form-group row">
    <asp:Label ID="Label_Email" runat="server" Text="E-mail:"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox_Email" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            </div>
                </div>
            <div class="col">
                <div class="formmain card bg-light p-5">
                    <div class="form-group row">
                        <asp:Label ID="Label_PatientNumber" runat="server" Text="Current number of patients:"></asp:Label>
        <asp:TextBox ID="TextBox_PatientNumber" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group row">
                         <asp:Label ID="Label_DoctorNumber" runat="server" Text="Current number of doctors:"></asp:Label>
        <asp:TextBox ID="TextBox_DoctorNumber" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button CssClass="btn btn-primary mt-5" Text="Doctor Management" ID="Button_DoctorManagement" runat="server" OnClick="Button_DoctorManagement_Click"/>
            </div>
        </div>
        </div>
    
</asp:Content>
