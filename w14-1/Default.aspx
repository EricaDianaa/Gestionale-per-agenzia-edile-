<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="w14_1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <div class="container">
        <h2 class="text-center text-light"> Dipendenti</h2>
     <asp:GridView ID="GridView1" CssClass="table table-bordered border border-dark mt-5  p-4 bg-secondary   " AutoGenerateColumns="false" runat="server" ItemType="w14_1.Dipendente">
   
              <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Numero identificativo dipendente </strong>
             </HeaderTemplate>
             <ItemTemplate>
                 <%#Item.IdDipendenti %>
             </ItemTemplate>
         </asp:TemplateField>
       
     </Columns>
         <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Nome </strong>
             </HeaderTemplate>
             <ItemTemplate>
                 <%#Item.Nome %>
             </ItemTemplate>
         </asp:TemplateField>
       
     </Columns>
           <Columns>
      <asp:TemplateField>
          <HeaderTemplate>
              <strong>Cognome </strong>
          </HeaderTemplate>
          <ItemTemplate>
              <%#Item.Cognome %>
          </ItemTemplate>
      </asp:TemplateField>
  </Columns>
           <Columns>
      <asp:TemplateField>
          <HeaderTemplate>
              <strong>Indirizzo </strong>
          </HeaderTemplate>
          <ItemTemplate>
              <%#Item.Indirizzo %>
          </ItemTemplate>
      </asp:TemplateField>
  </Columns>
           <Columns>
      <asp:TemplateField>
          <HeaderTemplate>
              <strong>Codice Fiscale </strong>
          </HeaderTemplate>
          <ItemTemplate>
              <%#Item.CodiceFiscale  %>
          </ItemTemplate>
      </asp:TemplateField>
  </Columns>
     <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Sposato</strong>
             </HeaderTemplate>
             <ItemTemplate>
                 <%#Item.IsSposato %>
             </ItemTemplate>
         </asp:TemplateField>
     </Columns>
     <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Numero di figli a carico</strong>
             </HeaderTemplate>
             <ItemTemplate>
                 <%#Item.NFigliCarico %>
             </ItemTemplate>
         </asp:TemplateField>
     </Columns>
     <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Mansione</strong>
             </HeaderTemplate>
             <ItemTemplate>
                 <%#Item.Mansione %>
             </ItemTemplate>
         </asp:TemplateField>
     </Columns>
     <Columns>
         <asp:TemplateField>
             <HeaderTemplate>
                 <strong>Dettagli pagamenti</strong>
             </HeaderTemplate>
             <ItemTemplate >
            <a href="Dettagli.aspx?Id=<%#Item.IdDipendenti %>" class="btn btn-primary d-flex justify-content-center">Dettagli</a>
             </ItemTemplate>
         </asp:TemplateField>
     </Columns>
 </asp:GridView>
</div>
  

  



</asp:Content>

