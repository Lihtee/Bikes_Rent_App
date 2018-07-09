﻿<%--flexberryautogenerated="false"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VydatVelosiped.aspx.cs" Inherits="IIS.Прокат_велосипедов_2.ВыдатьВелосипед" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <h1>Выдача велосипеда</h1>
        <div class="list">
            <ul>
                <li>
                    Номер велосипеда
                    <asp:TextBox runat="server" ID="inpNamber" ToolTip="Номер велосипеда"></asp:TextBox> 
                </li>
                <li>
                    Дата выдачи:
                    <input type="datetime" runat="server" id="inpStartDate" readonly />
                </li>
                <li>
                    Длительность
                    <input type="number" runat="server" id="inpDuration" />
                </li>
                <li>
                    Плановая стоимость
                    <input type="number" runat="server" id="inpPlannedPrice" class="descTxt"/>
                </li>
                <li>
                    Точка выдачи
                    <input type="text" runat="server" id="inpStartLocation"  class="descTxt"/>
                </li>    
            </ul>
            <asp:Button ID="btnSave" runat="server" Text="Сохранить" CssClass="btn"/>
            <asp:Button ID="btnCansel" runat="server" Text="Отмена" CssClass="btn"/>
        </div>
    </div>
    <style >
        li {
            list-style:none;
            
        }
        .list input{
            display: block;
        }
        .list{
            position:relative;
            width:28%;
        }
        .main .list .btn{
            position:relative;
            width:40%;
            display:inline-block;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
