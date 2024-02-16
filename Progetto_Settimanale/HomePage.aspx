<%@ Page Title="HomePage" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Progetto_Settimanale.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .fixed-height-image {
        height: 200px;
        object-fit: cover;
        width: 100%;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="text-center">

        </div>
        <asp:Button ID="btnCarrello" runat="server" Text="Carrello" CssClass="btn btn-dark mb-4" OnClick="btnCarrello_Click" />
        <div class="row">
    

        <asp:Repeater ID="rptArticoli" runat="server">
            <ItemTemplate>
                <div class="col-md-4 mb-4">

                <div class="card" style="width: 18rem;">
                    <img src="<%# Eval("ImmagineUrl") %>" alt="image" class="fixed-height-image img-fluid"/>
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nome") %></h5>
                        <p class="card-text"><%#Eval("Descrizione") %></p>
                        <p class=" badge bg-secondary d-block w-50 py-2"><%#Eval("Prezzo") %> EUR</p>
                        <a href="Dettaglio.aspx?id=<%# Eval("Id") %>" class="btn btn-primary">Visualizza articolo</a>
                    </div>
                </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>
    </div>

</asp:Content>
