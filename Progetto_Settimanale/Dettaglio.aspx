<%@ Page Title="Dettaglio Articolo" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Progetto_Settimanale.Dettaglio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
           <div class="row">
               <div class="col text-center">
                   <img id="imgArticolo" runat="server" class="img-fluid" />
               </div>
               <div class="col">
                   <h2 id="lblNome" runat="server"></h2>
                   <p id="lblDescrizione" runat="server"></p>
                   <h3 id="lblPrezzo" runat="server"></h3>
                   <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al carrello" OnClick="btnAggiungiAlCarrello_Click" CssClass="btn btn-primary" />
                   <asp:Button ID="btnTornaHomePage" runat="server" Text="Torna alla Homepage" CssClass="btn btn-dark" OnClick="btnTornaHomePage_Click" />
               </div>
           </div>
    </div>
</asp:Content>
