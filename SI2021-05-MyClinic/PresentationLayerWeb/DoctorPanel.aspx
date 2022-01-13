<%@ Page Title="Doctor panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoctorPanel.aspx.cs" Inherits="PresentationLayerWeb.DoctorPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Navigation" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary sticky-top">
             <div class="container">
                <a class="navbar-brand" href="#">MyClinic</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                      <li class="nav-item active">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/DoctorPanel.aspx">Doctor panel<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                      <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink2" runat="server" NavigateUrl="~/PatientManagement.aspx">Patient management</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink3" runat="server" NavigateUrl="~/InsertPatient.aspx">Insert patient</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink4" runat="server" NavigateUrl="~/Login.aspx">Log out</asp:HyperLink>
                      </li>
                    </ul>
                </div>
            </div>
        </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
    <asp:Label ID="Label_PersonalNumber" runat="server" Text="Personal number:"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox_PersonalNumber" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
                    <div class="form-group row">
    <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone number:"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox_PhoneNumber" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            </div>
                </div>
            <div class="col">
                <div class="formmain card bg-light p-5">
                    <div class="form-group row">
                        <asp:Label ID="Label_DateEmpolyed" runat="server" Text="Date employed:"></asp:Label>
        <asp:TextBox ID="TextBox_DateEmployed" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group row">
                         <asp:Label ID="Label_Specialization" runat="server" Text="Specialization:"></asp:Label>
        <asp:TextBox ID="TextBox_Specialization" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group row">
                         <asp:Label ID="Label_Department" runat="server" Text="Department:"></asp:Label>
        <asp:TextBox ID="TextBox_Department" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group row">
                         <asp:Label ID="Label_Email" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBox_Email" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button CssClass="btn btn-primary mt-5" Text="Patient Management" ID="Button_PatientManagement" runat="server" OnClick="Button_PatientManagement_Click"/>
            </div>
        </div>
        </div>
</asp:Content>
