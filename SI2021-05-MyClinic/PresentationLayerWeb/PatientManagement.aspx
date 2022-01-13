<%@ Page Title="Patient management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientManagement.aspx.cs" Inherits="PresentationLayerWeb.PatientManagement" %>
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
                          <asp:HyperLink CssClass="nav-link" ID="HyperLink1" runat="server" NavigateUrl="~/DoctorPanel.aspx">Doctor panel</asp:HyperLink>
                      </li>
                      <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link active" ID="HyperLink2" runat="server" NavigateUrl="~/PatientManagement.aspx">Patient management<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink3" runat="server" NavigateUrl="~/InsertPatient.aspx">Insert patient</asp:HyperLink>
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
                <asp:GridView ID="GridView_PatientList" CssClass="table table-sm table-bordered text-center" Font-Size="12px" runat="server">
                    <HeaderStyle CssClass="bg-primary text-white"/>
                    <Columns>
                        <asp:TemplateField headertext="Edit patient">
                            <ItemTemplate>
                                <asp:Button ID="Button_SelectPatient" CssClass="btn btn-primary" text="Select" runat="server" OnClick="Button_SelectPatient_Click" CommandName="SelectPatient"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-5">
                <div class="form-group row">
                    <asp:Label ID="Label_Id" runat="server" Text="Id:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Id" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
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
                    <asp:TextBox CssClass="form-control" ID="TextBox_PersonalNumber" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_HealthInsuranceNumber" runat="server" Text="Health Insurance number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_HealthInsuranceNumber" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_DateOfbirth" runat="server" Text="Date of birth:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_DateOfBirth" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PlaceOfBirth" runat="server" Text="Place of birth:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PlaceOfBirth" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone number:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PhoneNumber" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PhoneNumber" runat="server" ErrorMessage="Phone number entered incorrectly!" Text="Phone number entered incorrectly!" ControlToValidate="TextBox_PhoneNumber" ValidationExpression="^[0][6]\d{1}[1-9]\d{2,3}\d{3,4}$"></asp:RegularExpressionValidator></small>
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
                <div class="row">
                    <div class="col mt-3">
                        <asp:Button CssClass="btn btn-primary" OnClick="Button_UpdatePatient_Click" ID="Button_UpdatePatient" Text="Update patient" runat="server" />  <span> or </span> <asp:Button CssClass="btn btn-primary" ID="Button_InsertPatient" Text="Insert new patient" OnClick="Button_InsertPatient_Click" runat="server" />
                    </div>
                </div>
            </div>
            <div class="col-1"></div>
            <div class="col-6">
                <div class="form-group row">
                    <asp:Label ID="Label_PFirstName" runat="server" Text="Fist name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PFirstName" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_PLastName" runat="server" Text="Last name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_PLastName" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                 <div class="form-group row">
                    <asp:Label ID="Label_PDiagnosis" runat="server" Text="Diagnosis:"></asp:Label>
                     <textarea id="TextArea_PDiagnosis" class="form-control" rows="3" runat="server"></textarea>
                </div>
                <div class="row">
                    <div class="col my-3">
                    <asp:Button CssClass="btn btn-primary" OnClick="Button_InsertPatientReport_Click" ID="Button_InsertPatientReport" Text="Insert report" runat="server" /> <span> or </span> <asp:Button CssClass="btn btn-primary" ID="Button_ViewReports" Text="View patient reports" OnClick="Button_ViewReports_Click" runat="server" />
                    </div>
                </div>
                <div class="form-group row">
                    <asp:TextBox runat="server" CssClass="form-control" Rows="8" ID="TextBox_ViewReports" ReadOnly="True" TextMode="MultiLine" Visible="false" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
