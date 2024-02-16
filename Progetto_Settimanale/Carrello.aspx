<%@ Page Title="Il tuo carrello" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Progetto_Settimanale.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Carrello</h2>
        <asp:Repeater ID="rptCarrello" runat="server">
            <ItemTemplate>
                <div class="row mb-4">
                    <div class="col-md-8"><%# Eval("Nome") %></div>
                    <div class="col-md-2">€<%# Eval("Prezzo") %></div>
                    <div class="col-md-2 text-end">
                        <asp:Button ID="btnRimuovi" runat="server" CssClass="btn btn-danger" CommandArgument='<%#Eval("Id") %>' Text="Rimuovi" OnCommand="btnRimuovi_Command" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="d-flex justify-content-between">
            <div>

            <asp:Button ID="btnTornaHomePage" runat="server" Text="Torna alla HomePage" CssClass="btn btn-primary" OnClick="btnTornaHomePage_Click" />
        <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Svuota carrello" CssClass="btn btn-warning" OnClick="btnSvuotaCarrello_Click" />
            </div>
        <asp:Label ID="lblTotale" runat="server" Text="Label" CssClass="fw-bold fs-1"></asp:Label>
        </div>
    </div>
</asp:Content>
