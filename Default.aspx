<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Her under henter jeg noget data ud fra en database ved hjælp af Angular</h2>
    <p>skriv et dansk postnummer mellem 8000 og 8250 i feltet</p>
    <asp:textbox ID="postnummer" runat="server" type="search" ng-model="postnr" ng-change="drag();"/>
    <asp:Button runat="server" Text="Hent" ng-click="drag();" OnClientClick="return false;" />
    <ul ng-repeat="product in products">
        <li ng-repeat="product2 in product">
            id: {{product2._id}}
            nr: {{product2._postnr}}
            navn: {{product2._bynavn}}
        </li>
    </ul>
    <h2>Her under henter jeg noget data ud fra en database ved hælp af c#</h2>
    <asp:Literal ID="litResult" runat="server" />
</asp:Content>

