<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientManagement.aspx.cs" Inherits="PresentationLayerWeb.PatientManagement" %>
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
                        <asp:HyperLink CssClass="nav-link active" ID="HyperLink2" runat="server" NavigateUrl="~/PatientManagement.aspx">Patient management<span class="sr-only">(current)</span></asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink3" runat="server" NavigateUrl="~/InsertPatient.aspx">Insert patient</asp:HyperLink>
                      </li>
                        <li class="nav-item">
                        <asp:HyperLink CssClass="nav-link" ID="HyperLink5" runat="server" NavigateUrl="~/InsertReport.aspx">Insert report</asp:HyperLink>
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

</asp:Content>
