<%@ Page Title="Admin Panel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="PresentationLayerWeb.AdminPanel" %>
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
