﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BrokenBicycles.aspx.cs" Inherits="Bicycle_rent.BrokenBicycles" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="descTxt">
        <asp:Label CssClass="descLbl" ID="ctrlFromDateLabel" runat="server" Text="От" EnableViewState="False" />
        <ac:DatePicker ID="ctrlFromDate" runat="server"/>
        <asp:Label CssClass="descLbl" ID="ctrlUntilDateLabel" runat="server" Text="До" EnableViewState="False" />
        <ac:DatePicker ID="ctrlUntilDate" runat="server"/>
        <asp:Button runat="server" ID="btnCalcResult" Text="Рассчитать" OnClick="btnCalcResult_Click" />
        <p><asp:Label CssClass="descLbl" ID="ctrlDamagedBicyclesLabel" runat="server" Text="" EnableViewState="False" /></p>
        <p><asp:Label CssClass="descLbl" ID="ctrlStolenBicyclesLabel" runat="server" Text="" EnableViewState="False" /></p>


    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
