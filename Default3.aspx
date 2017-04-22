<%@ Page Title="Catalog of Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AromaStock.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
     <div>
           <%-- <%
                foreach (AromaStock.Models.Product prod in GetProducts())
                {
                    Response.Write(String.Format(@"
                        <div class='item'>
                            <h3>{0}</h3>
                            {1}
                            <h4>{2:c}</h4>
                        </div>",
                        prod.ProductName, prod.ProductInfo, prod.ProductPrice));
                }
            %>--%>
        </div> 

</asp:Content>
