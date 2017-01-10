<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input id="postnummer" type="search" ng-model="postnr" ng-change="drag();" />
    <Button ng-click="drag();" onclick="return false;">test</Button>

    <ul>
        <li  ng-repeat="product in products.d">
            id: {{product._id}}
            nr: {{product._postnr}}
            navn: {{product._bynavn}}
        </li>
    </ul>
    <asp:Literal ID="litResult" runat="server" />
</asp:Content>

