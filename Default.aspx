<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
   
    
     <div>
            <%
                
                String.Format(@"Hello!");
                
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
            %>
        </div> 


</asp:Content>
