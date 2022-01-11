<%@ Page Title="Doctor Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoctorManagement.aspx.cs" Inherits="PresentationLayerWeb.DoctorManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container my-5">
        <div class="row">
            <div class="col">
                <asp:GridView ID="GridView_DoctorList" CssClass="table table-sm table-bordered text-center" Font-Size="12px" runat="server">
                    <HeaderStyle CssClass="bg-primary text-white"/>
                    <Columns>
                        <asp:TemplateField headertext="Edit doctor">
                            <ItemTemplate>
                                <asp:Button ID="Button_SelectDoctor" CssClass="btn btn-primary" text="Select" runat="server" OnClick="Button_SelectDoctor_Click" CommandName="SelectDoctor"/>
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
                    <asp:Label ID="Label_Status" runat="server" Text="Status:"></asp:Label>
                    <asp:DropDownList ID="DropDownList_Status" runat="server" CssClass="custom-select">
                        <asp:ListItem Text="Active" Value="True"/>
                        <asp:ListItem Text="Inactive" Value="False"/>
                    </asp:DropDownList>
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
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_PersonalNumber" runat="server" ErrorMessage="Personal number entered incorrectly!" Text="Personal number entered incorrectly!" ControlToValidate="TextBox_PersonalNumber" ValidationExpression="^(\d{13})?$"></asp:RegularExpressionValidator></small>
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
                    <asp:Label ID="Label_DateEmployed" runat="server" Text="Date employed:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_DateEmployed" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Specialization" runat="server" Text="Specialization:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Specialization" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Specialization" runat="server" ErrorMessage="Specialization entered incorrectly!" Text="Specialization entered incorrectly!" ControlToValidate="TextBox_Specialization" ValidationExpression="^([a-zA-Z]+\s)*[a-zA-Z]+$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Department" runat="server" Text="Department:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Department" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Department" runat="server" ErrorMessage="Department entered incorrectly!" Text="Department entered incorrectly!" ControlToValidate="TextBox_Department" ValidationExpression="^([a-zA-Z]+\s)*[a-zA-Z]+$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Email" runat="server" Text="E-mail:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Email" runat="server"></asp:TextBox>
                     <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ErrorMessage="E-mail entered incorrectly!" Text="E-mail entered incorrectly!" ControlToValidate="TextBox_Email" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator></small>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label_Password" runat="server" Text="Password:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="TextBox_Password" runat="server"></asp:TextBox>
                    <small class="form-text text-danger"><asp:RegularExpressionValidator ID="RegularExpressionValidator_Password" runat="server" ErrorMessage="Password entered incorrectly!" Text="Password entered incorrectly!" ControlToValidate="TextBox_Password" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$"></asp:RegularExpressionValidator></small>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col mt-3">
                <asp:Button CssClass="btn btn-primary" OnClick="Button_UpdateDoctor_Click" ID="Button_UpdateDoctor" Text="Update doctor" runat="server" /> <span> or </span> <asp:Button CssClass="btn btn-primary" ID="Button_InsertDoctor" Text="Insert new doctor" OnClick="Button_InsertDoctor_Click" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
