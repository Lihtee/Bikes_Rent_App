﻿<%--flexberryautogenerated="false"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Spravochniki.aspx.cs" Inherits="IIS.Прокат_велосипедов_2.Справочники" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../shared/MyStyles/Catalog.css" />
    <h1>
        Справочники
    </h1>
    <div class="main">
        <div class ="listBlock">
            <p class="listTitle">Велосипеды</p>
            <ul>
                <li><a href="SostoyanieVelosipeda/SostoyanieVelosipedaL.aspx">Состояния велосипедов</a></li>
                <li><a href="TipVelosipeda/TipVelosipedaL.aspx">Типы велосипедов</a></li>
            </ul>
        </div>
        <div class="listBlock">
            <p class="listTitle">Люди</p>
            <ul>
                <li> <a href="Klient/KlientL.aspx">Клиенты</a></li>
                <li><a href="Sotrudnik/SotrudnikL.aspx">Сотрудники</a></li>
            </ul>
        </div>
        <div class="listBlock">
            <p class="listTitle">Прокат</p>
            <ul>
                <li><a href="TochkaProkata/TochkaProkataL.aspx">Точки проката</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
