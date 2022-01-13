<%@ Page Title="Insert patient" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertPatient.aspx.cs" Inherits="PresentationLayerWeb.InsertPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Navigation" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary sticky-top">
             <div class="container">
                <a class="navbar-brand" href="#">MyClinic</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                      <li class="nav-item">
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/DoctorPanel.aspx">Doctor panel</asp:HyperLink>
                      </li>
                      <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink2" runat="server" NavigateUrl="~/PatientManagement.aspx">Patient management</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link active" ID="HyperLink3" runat="server" NavigateUrl="~/InsertPatient.aspx">Insert patient<span class="sr-only">(current)</span></asp:HyperLink>
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
            <div class="col-5">
                <div class="form-group row">
                    <asp:Label ID="Label_FirstName" runat="server" Text="Fist name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_FirstName" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_FirstName" runat="server" ErrorMessage="First name entered incorrectly!" Text="First name entered incorrectly!" ControlToValidate="TextBox_FirstName" ValidationExpression="^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_LastName" runat="server" Text="Last name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_LastName" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_LastName" runat="server" ErrorMessage="Last name entered incorrectly!" Text="Last name entered incorrectly!" ControlToValidate="TextBox_LastName" ValidationExpression="^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PersonalNumber" runat="server" Text="Personal number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PersonalNumber" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PersonalNumber" runat="server" ErrorMessage="Personal number entered incorrectly!" Text="Personal number entered incorrectly!" ControlToValidate="TextBox_PersonalNumber" ValidationExpression="^(\d{13})?$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_HealthInsuranceNumber" runat="server" Text="Health Insurance number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_HealthInsuranceNumber" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_HealthInsuranceNumber" runat="server" ErrorMessage="Health insurance number entered incorrectly!" Text="Health insurance number entered incorrectly!" ControlToValidate="TextBox_HealthInsuranceNumber" ValidationExpression="^(\d{11})?$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PhoneNumber" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PhoneNumber" runat="server" ErrorMessage="Phone number entered incorrectly!" Text="Phone number entered incorrectly!" ControlToValidate="TextBox_PhoneNumber" ValidationExpression="^[0][6]\d{1}[1-9]\d{2,3}\d{3,4}$"></asp:RegularExpressionValidator></small>
                </div>
            </div>
            <div class="col-1"></div>
            <div class="col-6">
                <div class="form-group row">
                    <asp:Label ID="Label_DateOfbirth" runat="server" Text="Date of birth:"></asp:Label>
                    <input type="date" class="form-control" id="Input_DatePicker" runat="server"/>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PlaceOfBirth" runat="server" Text="Place of birth:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PlaceOfBirth" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PlaceOfBirth" runat="server" ErrorMessage="Place of birth entered incorrectly!" Text="Place of birth entered incorrectly!" ControlToValidate="TextBox_PlaceOfBirth" ValidationExpression="^([a-zA-Z]+\s)*[a-zA-Z]+$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Email" runat="server" Text="E-mail:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Email" runat="server"></asp:TextBox>
                     <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ErrorMessage="E-mail entered incorrectly!" Text="E-mail entered incorrectly!" ControlToValidate="TextBox_Email" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator></small>
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
        </div>
        <div class="row">
            <div class="col mt-3">
                <asp:Button CssClass="btn btn-primary" ID="Button_InsertPatient" Text="Insert new patient" OnClick="Button_InsertPatient_Click" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
