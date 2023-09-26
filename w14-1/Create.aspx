<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="w14_1.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="Content/StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container  d-flex justify-content-evenly w-100  ">
     <div ID="dipendente" class="border border-dark w-50 rounded-5 p-5 d-flex flex-column text-center my-auto " >
           
            <h2>Inserisci nuovo dipendente</h2>
            <h5>Inserisci nome </h5>  
             <asp:TextBox ID="Nome" runat="server"  CssClass="rounded-2 border border-secondary w-75 mx-auto"></asp:TextBox>
             <h5>Inserisci cognome</h5>  
             <asp:TextBox ID="Cognome" runat="server" CssClass="rounded-2 border border-secondary  w-75 mx-auto"></asp:TextBox>
             <h5>Inserisci l'indirizzo</h5>  
             <asp:TextBox ID="Indirizzo" runat="server" CssClass="rounded-2 border border-secondary  w-75 mx-auto"></asp:TextBox>
             <h5>Inserisci il codice fiscale</h5>  
             <asp:TextBox ID="CodiceFiscale" runat="server"  CssClass="rounded-2 border border-secondary  w-75 mx-auto"></asp:TextBox>
            
         <div>
 <h5>Sei sposato?</h5> 
         <asp:CheckBox ID="IsSposato" runat="server" Text="si" />
         <asp:CheckBox ID="CheckBox1" runat="server" Text="no" />
         </div>
        
            <h5>Inserisci il numero figli a carico</h5>  
 <asp:TextBox ID="NfigliCarico" runat="server"  CssClass="rounded-2 border border-secondary   w-75 mx-auto"></asp:TextBox> 
          <h5>Inserisci mansione</h5>  
 <asp:TextBox ID="Mansione" runat="server"  CssClass="rounded-2 border border-secondary  w-75 mx-auto"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Aggiungi"  CssClass="btn btn-primary" Onclick="Button1_Click"/>
              <asp:Button ID="Modifica" runat="server" Text="Modifica" Visible="false"  CssClass="btn btn-danger mt-2" Onclick="Modifica_Click"/>
         <asp:Label ID="Label1" runat="server" Visible="false" Text=""></asp:Label>
        
            <div>
            </div>
        </div>

         <div id="pagamenti" class="border border-dark w-50 rounded-5 p-5 ms-5 me-3 d-flex flex-column text-center my-auto ">
     
            <h2>Inserisci nuovo pagamento</h2>
            <h5>Inserisci la data del pagamento</h5>  
             <asp:TextBox TextMode="Date" ID="data" runat="server" CssClass="rounded-2  border border-secondary  w-75 mx-auto" ></asp:TextBox>
             <h5>Inserisci importo</h5>  
             <asp:TextBox TextMode="Number" ID="importo" CssClass="rounded-2 border border-secondary  w-75 mx-auto"  runat="server"></asp:TextBox>
             
             <div>
 <h5>Stipendio o acconti?</h5> 
         <asp:CheckBox ID="stipendio" runat="server" Text="Stipendio" />
         <asp:CheckBox ID="acconto" runat="server" Text="Acconto" />
             </div>
            
          <h5>Inserici il numero identificativo Dipendente</h5>  
          <asp:TextBox TextMode="Number"  ID="idDipendente" runat="server" CssClass="rounded-2  border border-secondary  w-75 mx-auto"></asp:TextBox>
             <br />
             <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Aggiungi" Onclick="Button2_Click"/>

               <asp:Label ID="Label2" Visible="false" runat="server" Text="Label"></asp:Label>
      
            <div>
            </div>
        </div>
         
</div>
</asp:Content>
