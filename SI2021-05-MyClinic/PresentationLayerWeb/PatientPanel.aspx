<%@ Page Title="Patient panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientPanel.aspx.cs" Inherits="PresentationLayerWeb.PatientPanel"%>
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
                      <li class="nav-item active">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/PatientPanel.aspx">Patient panel<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                        <li class="nav-item">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink2" runat="server" NavigateUrl="~/Management.aspx">Patient Management</asp:HyperLink>
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
            <div class="col">
                <div class="formmain card bg-light p-5">
                    <div class="form-group row">
                    <asp:Label ID="Label_Id" runat="server" Text="Id:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Id" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                    <div class="form-group row">
                    <asp:Label ID="Label_FirstName" runat="server" Text="Fist name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_FirstName" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_LastName" runat="server" Text="Last name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_LastName" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PersonalNumber" runat="server" Text="Personal number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PersonalNumber" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_HealthInsuranceNumber" runat="server" Text="Health Insurance number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_HealthInsuranceNumber" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PhoneNumber" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                </div>
            </div>
            <div class="col">
                <div class="formmain card bg-light p-5">
                    <div class="form-group row">
                    <asp:Label ID="Label_DateOfbirth" runat="server" Text="Date of birth:"></asp:Label>
                    <asp:TextBox ID="TextBox_DateOfBirth" runat="server" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PlaceOfBirth" runat="server" Text="Place of birth:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PlaceOfBirth" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Email" runat="server" Text="E-mail:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Email" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Weight" runat="server" Text="Weight:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Weight" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Height" runat="server" Text="Height:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Height" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="row">
                    <div class="col">
                        <asp:Button CssClass="btn btn-primary mt-5" Text="Calculate BMI" ID="Button_CalculateBMI" runat="server" OnClick="Button_CalculateBMI_Click"/>
                    </div>
                </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button CssClass="btn btn-primary" OnClick="Button_UpdateSelf_Click" ID="Button_UpdateSelf" Text="Profile Management" runat="server" /> 
            </div>
        </div>
        <div class="row mt-5">
            <div class="col">
                <asp:Button CssClass="btn btn-primary" OnClick="Button_ShowReports_Click" ID="Button_ShowReports" Text="Show my reports" runat="server" /> 
            </div>
        </div>
        <div class="row mt-3">
            <div class="col">
                <asp:TextBox runat="server" CssClass="form-control" Rows="8" ID="TextBox_ViewReports" ReadOnly="True" TextMode="MultiLine" Visible="false" />
            </div>
        </div>
    </div>
</asp:Content>
