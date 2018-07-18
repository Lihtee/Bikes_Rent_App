﻿<%--flexberryautogenerated="false"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Zapros2.aspx.cs" Inherits="IIS.Прокат_велосипедов_2.Запрос2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../shared/MyStyles/Request.css" />
    <h1>Запросы</h1>
    <div class="main">
        <div class="requestBlock">
            <p class ="header">Какую прибыль приносит каждая из точек проката?</p>
            <div class="paramsLine">
                Интервал запроса: с 
                <ac:DatePicker ID="ctrlДатаНачала" CssClass="myDatePicker" runat="server"/> 
                по 
                <ac:DatePicker ID="ctrlДатаКонца" CssClass="myDatePicker" runat="server"/>
                <span id="btnShowReq11" >Click</span> 
            </div>
            <div id="chart_div">

            </div>
        </div>

    </div>
    <% //TODO сделать параметры и графики для запросов %>
    <%--1)	Какой тип велосипедов пользуется наибольшей популярностью, а какой наименьшей?
    2)	Какую прибыль приносит каждая из точек проката?
    3)	Сколько велосипедов было испорчено или украдено за месяц?
    4)	Сколько велосипедов было перевезено между точками на специальном автомобиле для балансировки?
    5)	Какова средняя продолжительность проката велосипеда?--%>
   
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <%--<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>--%>
    <script type="text/javascript" src="../shared/script/GoogleCharts.js"></script>
    <script type="text/javascript">

        $("#btnShowReq11").click(function () {
            drawChart(requestAndDraw());
        });
        $(document).ready(function () {
            // Load the Visualization API and the corechart package.
            google.charts.load('current', {'packages':['corechart']});

            // Set a callback to run when the Google Visualization API is loaded.
            google.charts.setOnLoadCallback(drawChart);

            drawChart(requestAndDraw());
        });
        function requestAndDraw() {
            var dateFrom = document.getElementById('<%=ctrlДатаНачала.ClientID%>').value;
            var dateTo = document.getElementById('<%=ctrlДатаКонца.ClientID%>').value;
            var result = null;
            obj = {
                from: dateFrom,
                to: dateTo
            };
            $.ajax({
                url: "Zapros2.aspx/ProfitPerPoint",
                type: "POST",
                data: JSON.stringify(obj),
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (res) {
                    var resObj = JSON.parse(res.d);
                    drawChart(resObj);
                },
                error: function (par1, par2, par3) {
                    console.log(par1.responseText + " " + par2 + " " + par3);
                }
                
            });
            

        }
        function drawChart(_resObj) {
            if (_resObj != null) {

                // Create the data table.
                var data = new google.visualization.DataTable();

                //Собрать колонки.
                _resObj.Columns.forEach(function (el) {
                    data.addColumn(el.Type, el.Name);
                });

                //Проход по строкам
                var rows = [];
                _resObj.rows.forEach(function (el) {
                    for (i = 0; i < el.length; i++) {
                        if (_resObj.Columns[i].Type == "number") {
                            el[i] = parseInt(el[i]);
                        }
                    }
                    rows.push(el);
                })
                data.addRows(rows);


                // Set chart options
                var options = {
                    'title': 'Прибыль на точках',
                    'width': 1000,
                    'height': 300
                };

                // Instantiate and draw our chart, passing in some options.
                var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
                chart.draw(data, options);
            }
      }
    </script>
</asp:Content>

