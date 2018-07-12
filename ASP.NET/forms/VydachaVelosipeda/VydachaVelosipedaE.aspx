﻿<%--flexberryautogenerated="false"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="VydachaVelosipedaE.aspx.cs" Inherits="IIS.Прокат_велосипедов_2.ВыдачаВелосипедаE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Выдача велосипеда</h2>
        <div class="<%= Constants.FormToolbarCssClass  + " " +  Constants.EditFormToolbarCssClass + " " + Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn"  AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
            <span id ="spanSave" >Click</span>
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаНачалаLabel" runat="server" Text="Дата начала" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаНачала" runat="server"/>
</div>
<ac:DatePickerValidator ID="ctrlДатаНачалаDatePickerValidator" runat="server" ControlToValidate="ctrlДатаНачала" 
                        ErrorMessage="Введена некорректная дата: Дата начала." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПлановаяДлительностьLabel" runat="server" Text="Плановая длительность" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlПлановаяДлительность" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПлановаяСтоимостьLabel" runat="server" Text="Плановая стоимость" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlПлановаяСтоимость" runat="server">
</ac:DecimalTextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlТочкаВыдачиLabel" runat="server" Text="Точка выдачи" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlТочкаВыдачи" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlТочкаВыдачиRequiredFieldValidator" runat="server" ControlToValidate="ctrlТочкаВыдачи"
                            ErrorMessage="Не указано: ТочкаВыдачи" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlВелосипедLabel" runat="server" Text="Велосипед" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlВелосипед" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlВелосипедRequiredFieldValidator" runat="server" ControlToValidate="ctrlВелосипед"
                            ErrorMessage="Не указано: Велосипед" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКлиентLabel" runat="server" Text="Клиент" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlКлиент" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" LookUpFormURL="~/forms/Klient/KlientL.aspx" />

<asp:RequiredFieldValidator ID="ctrlКлиентRequiredFieldValidator" runat="server" ControlToValidate="ctrlКлиент"
                            ErrorMessage="Не указано: Клиент" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПрокатчикLabel" runat="server" Text="Прокатчик" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlПрокатчик" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlПрокатчикRequiredFieldValidator" runat="server" ControlToValidate="ctrlПрокатчик"
                            ErrorMessage="Не указано: Прокатчик" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
    
    
        
        

</asp:Content>
<asp:Content runat="server" ID="content2" ContentPlaceHolderID="ContentPlaceHolder0">
<script type="text/javascript">
    $("#spanSave").click(function () {
        var obj = {
            startDate: $("#<%= ctrlДатаНачала.ClientID %>").val(),
            plannedDuration: $("#<%= ctrlПлановаяДлительность.ClientID %>").val(),
            plannedPrice: $("#<%= ctrlПлановаяСтоимость.ClientID %>").val(),
            startPoint: $("#<%= ctrlТочкаВыдачи.ClientID %>").val(),
            vel: $("#<%= ctrlВелосипед.ClientID %>").val(),
            klient: $("#<%= ctrlКлиент.ClientID %>").val(),
            employee: $("#<%= ctrlПрокатчик.ClientID %>").val(),

        }
        var response;
        $.ajax({
            <%--url: "<%= ResolveUrl("~/forms/VydachaVelosipeda/VydachaVelosipeda.aspx/MySaveObject")%>",--%>
            url:"VydachaVelosipedaE.aspx/MySaveObject",
            type: "POST",
            data: JSON.stringify(obj),
            contentType: 'application/json; charset=utf-8',
            //dataType: 'json',
            //TODO отреагировать на результат запроса
            success: function (result) {
                response = result.d;
                if (response == '1') {
                    $.ics.dialog.confirm({
                        message: 'Выдать еще один велосипед?',
                        title: 'Оформление еще одной выдачи',
                        callback: function (res) {
                            if (res) {
                                // При нажатии OK.
                                window.location.href = "/forms/VydachaVelosipeda/VydachaVelosipedaE.aspx";
                            } else {
                                // При нажатии Cancel
                                window.location.href = "/Default.aspx";
                            }
                        }
                    });
                } else {
                    $.ics.dialog.confirm({
                        message: 'Ошибка при создании проката. Скорее всего, не заполнены некоторые поля',
                        title: 'Ошибка',
                        callback: function (res) {

                        }
                    });
                }
            },
            //TODO: В случае ошибка 401 можно выводить уведомление
            error: function () {
                alert("Some error")
            },
            

        });

        });
    </script>
    </asp:Content>