<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientPanel.aspx.cs" Inherits="PresentationLayerWeb.PatientPanel" %>
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
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink2" runat="server" NavigateUrl="~/PatientManagement.aspx">Patient management</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link active" ID="HyperLink3" runat="server" NavigateUrl="~/InsertPatient.aspx">Insert patient<span class="sr-only">(current)</span></asp:HyperLink>
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
</asp:Content>
