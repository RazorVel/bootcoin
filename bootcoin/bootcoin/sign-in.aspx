<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sign-in.aspx.cs" Inherits="bootcoin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container-fluid">
         <div class="row">

             <%--Left Page--%>
             <div class="col-lg-7 min-vh-100" id ="left-page">
                  <div class="container">
                      <div class="row">
                          <%--Bootcoin logo and slogan--%>
                          <div id="logo">
                             <img src="images/bootcoin_logo.png" id ="logo-image" />
                              <h1 id ="title">Bootcoin</h1>
                               <p id ="subtitle">Collect bootcoin and get exclusive perks</p>
                           </div>
                      <div>
                          <img src="images/image-signin.png" id ="signin-image"/>
                       </div>
                               
                   </div>
               </div>
            </div>  

             <%--Right Page--%>
            <div class="col-lg-5 min-vh-100" id ="signin-page">
                 <div class="row">
                      <%--Bootcoin header greeting--%>
                     <br />
                     <div id="greeting-box">
                        <h1 id ="greeting">Hello, Welcome back to Bootcoin</h1>
                        <p id ="greeting-sub">Before we get started, please sign in using your email address and password...</p>
                     </div>
                    

                     <%--Input group (email & password ) --%>
                      <%--Email--%>
                  
                  <div id="signin-group">
                      <div class="input-container" id ="email">
                         <div class="input-group-addon">
                              <img src="images/email-icon.png" id="email-icon"/>
                          </div>
                          <div class="input-group">
                              <asp:TextBox ID="emailTxt" runat="server" cssclass="form-control" placeholder="Email Address" ></asp:TextBox> 
                            </div>
                          <span id="errorLabelEmail" runat="server" style=" color:red"></span>

                        <br />
                          <%--Password--%>
                         <div class="input-container" >
                             <div class="input-group-addon">
                                  <img src="images/password-icon.png" id="password-icon"/>
                              </div>
                              <div class="input-group">
                                   <asp:TextBox ID="password" TextMode="Password" runat="server" cssclass="form-control" placeholder="Password"></asp:TextBox>
                              </div>
                              <div class="input-group-addon">
                                   <img src="images/password-reveal.png" id ="password-eye"/>
                              </div>  
                             <span id="errorLabelConfirm"  runat="server" style=" color:red"></span>
                         </div>
                          <br />
                          <%--signup button--%>
                          <div class ="container">
                             <div class ="center">
                                   <asp:LinkButton runat="server" ID="signin_button" cssclass="btn btn-primary btn-lg" OnClick="signin_button_Click" OnClientClick="return ButtonAlert">Let's Go</asp:LinkButton>
                              </div>
                              <p id="register" class="center">Dont have an account? <asp:LinkButton runat="server" OnClick="registerlink_Click" cssclass="loginregister"> Register here</asp:LinkButton></p>
                           </div>
                           <%--facebook and google login--%>
                           <div class="center">
                               <a href ="#">
                                   <img src="images/facebook.png" id ="facebook"/>
                               </a>
                               <a href="#">
                                   <img src="images/google.png" id="google" />
                               </a>
                                
                                
                            </div> 
                           </div>
                      </div>
                    </div>
                 </div>
           </div>
      </div>

    <script type="text/javascript">
        let email_acc = false;
        let confirm_acc = false;
        var errorLabelEmail = document.getElementById('<%=errorLabelEmail.ClientID %>');
        var errorLabelConfirm = document.getElementById('<%=errorLabelConfirm.ClientID %>');
        document.getElementById('<%=signin_button.ClientID %>').addEventListener("click", prevenButtonClick, false);

        function prevenButtonClick(event) {
          //  alert("Your Password or Email is not valid");
           // event.preventDefault();

        }

        function show(id) {
            var pass = document.getElementById(id);
            pass.setAttribute('type', 'text');

        }

        function hide(id) {
            var pass = document.getElementById(id);
            pass.setAttribute('type', 'password');
        }

        var pwShown = 0;

        document.getElementById("password-eye").addEventListener("click", function () {
            if (pwShown == 0) {
                pwShown = 1;
                show('<%=password.ClientID %>');
            } else {
                pwShown = 0;
                hide('<%=password.ClientID %>');
            }
        }, false);

         
         function ValidateEmail(){
            var email = document.getElementById('<%=emailTxt.ClientID %>').value;
            if (email == '' || email == undefined || email == null) {
                errorLabelEmail.innerHTML = "Email can not be empty";
                email_acc = false;
            }
            
            else {
                errorLabelEmail.innerHTML = ''
                email_acc = true;
             }
             if (email_acc == true && confirm_acc == true) {
                 document.getElementById('<%=signin_button.ClientID %>').removeEventListener("click", prevenButtonClick);
               }
            else {
                document.getElementById('<%=signin_button.ClientID %>').addEventListener("click", prevenButtonClick);

             }
 
        }

        


        function ValidateConfirmation() {
            var password = document.getElementById('<%=password.ClientID %>').value;
           
            
            if (password == "" || password == undefined || password == null) {
                errorLabelConfirm.innerHTML = "Passwords can not be empty";
                confirm_acc = false;
            }
            
            else {
                errorLabelConfirm.innerHTML = "";
                confirm_acc = true;
            }
            if (email_acc == true && confirm_acc == true) {
                document.getElementById('<%=signin_button.ClientID %>').removeEventListener("click", prevenButtonClick);
               }
            else {
                 document.getElementById('<%=signin_button.ClientID %>').addEventListener("click", prevenButtonClick);

             }

           
        }
        

       
    </script>
</asp:Content>
