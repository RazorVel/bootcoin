<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sign-up.aspx.cs" Inherits="bootcoin.WebForm3" %>
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
                     <div id="greeting-box">
                        <h1 id ="greeting">Hello, Welcome to Bootcoin</h1>
                        <p id ="greeting-sub">To join the community, please register yourself by completing fields below...</p>
                     </div>

                  <div id="signin-group">
                      <%--Input group (email & password ) --%>
                      <%--Email--%>
                      <div class="input-container" id ="email">
                         <div class="input-group-addon">
                              <img src="images/email-icon.png" id="email-icon"/>
                          </div>
                          <div class="input-group">
                              <input type="text" class="form-control" placeholder="Email Address">
                            </div>
                        <br />

                          <%--Password--%>
                         <div class="input-container" >
                             <div class="input-group-addon">
                                  <img src="images/password-icon.png" id="password-icon"/>
                              </div>
                              <div class="input-group">
                                   <input type="password" class="form-control" placeholder="Password" id ="password">
                              </div>
                              <div class="input-group-addon">
                                   <img src="images/password-reveal.png" id ="password-eye"/>
                              </div>  
                         </div>
                          <br />
                          <%--Confirm password--%>
                           <div class="input-container" >
                             <div class="input-group-addon">
                                  <img src="images/password-icon.png" id="confirm-icon"/>
                              </div>
                              <div class="input-group">
                                   <input type="password" class="form-control" placeholder="Confirm Password" id ="confirm">
                              </div>
                              <div class="input-group-addon">
                                   <img src="images/password-reveal.png" id ="confirm-eye"/>
                              </div>  
                             </div>
                          </div>

                      <%--terms and conditions--%>  
                      <div class="center">
                          <div >
                            <input type="checkbox">
                          </div>
                          
                          <div id="termsconditions">
                              <p >I agree to bootcoin's <a  id="termsconditionslink" href="#">terms and condition</a></p>
                          </div>
                          
                        </div>

                        
                      <%--signup button--%>
                          <div class ="container">
                             <div class ="center">
                                  <button  id= "signin-button" type="button" class="btn btn-primary btn-lg">Join now</button>
                              </div>
                              <p id="register" class="center">Already have an account?<asp:LinkButton runat="server" ID="registerlink" OnClick="registerlink_Click">Log in here</asp:LinkButton></p>
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

</asp:Content>
