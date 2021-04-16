<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="Esercitazione_Ereditarietà_e_Polimorfismo.Input" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div id="Forma" runat="server">
       <h1 style="color:darkred;font-family:'Times New Roman', Times, serif;">Calcolo dell'area e del perimetro</h1>
        <fieldset style="border: 2px solid darkred; padding: 15px; margin: 20px;">
            <legend class="style1" style="width: unset; caption-side: initial; font-family: Verdana; font-size: 12px; color: darkred;">Dati</legend>
            <table>
                <tr>
                    <td class="style2" style="font-size: 12px; padding: 5px 15px 5px; font-family: Verdana;">
                        <strong>Inserisci Lato:</strong></td>       
                    <td>
                        <asp:TextBox ID="LatoInserimento" BorderColor="darkred" BorderWidth="1px" Height="18px" Width="150px" maxlenght="16" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2" style="font-size: 12px; padding: 5px 15px 5px; font-family: Verdana">
                        <strong>Inserisci Altezza:</strong></td>
                    <td>
                        <asp:TextBox ID="AltezzaInserimento" BorderColor="darkred" BorderWidth="1px" Height="18px" Width="150px" runat="server" TextMode="Number" ></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td class="style2" style="font-size: 12px; padding: 5px 15px 5px; font-family: Verdana">
                        <strong>Inserisci Raggio:</strong></td>
                    <td>
                        <asp:TextBox ID="RaggioInserimento"  BorderColor="darkred" BorderWidth="1px" Height="18px" Width="150px" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr><td><asp:Label runat="server" ID="lbl_Triangolo" ></asp:Label></td></tr>
               
                <tr><td> <asp:Label runat="server" ID="lbl_Cerchio" ></asp:Label></td></tr>
         
            <tr><td> <asp:Label runat="server" ID="lbl_Rettangolo" ></asp:Label></td></tr>
     
           <tr><td>  <asp:Label runat="server" ID="lbl_Quadrato" ></asp:Label></td></tr>
      
</table>
            
            <br />
            <br />
              <asp:Button runat="server" ID="BtnRettangolo" OnClick="BtnRettangolo_Click" text="RETTANGOLO"  Style="width: 120px; background-color: darkred; font-size: 12px; color: white; font-weight: 800 " />
                <asp:Button runat="server" ID="BtnCerchio" OnClick="BtnCerchio_Click" text="CERCHIO" Style="width: 120px; background-color: darkred; font-size: 12px; color: white; font-weight: 800 " />
                <asp:Button runat="server" ID="BtnTriangolo" OnClick="BtnTriangolo_Click" Text="TRIANGOLO" Style="width: 120px; background-color: darkred; font-size: 12px; color: white; font-weight: 800 " />
                <asp:Button runat="server" ID="BtnQuadrato" OnClick="BtnQuadrato_Click" Text="QUADRATO" Style="width: 120px; background-color: darkred; font-size: 12px; color: white; font-weight: 800 " />

            
           
           
           </fieldset>


       </div>
     <asp:RequiredFieldValidator ID="RaggioInserimentoValidator" runat="server"
            ControlToValidate="RaggioInserimento" ErrorMessage="Inserisci Raggio" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="LatoInserimentoValidator" runat="server"
            ControlToValidate="LatoInserimento" ErrorMessage="Inserisci Lato" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="AltezzaInserimentoValidator" runat="server"
            ControlToValidate="AltezzaInserimento" ErrorMessage="Inserisci Altezza"
            ForeColor="Red"></asp:RequiredFieldValidator>
</asp:Content>
