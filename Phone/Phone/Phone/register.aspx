<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Phone.zhuce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="css/login.css">
    <script type="text/javascript" src="js/jquery.min.js"></script>
</head>
<body class="login_bj">
    <div class="zhuce_body">
        <div class="logo"><%--a href="#"><img src="images/logo.png" width="114" height="54" border="0"></a>--%></div>
        <div class="zhuce_kong">
            <div class="zc">
                <div class="bj_bai">
                    <h3>欢迎注册</h3>
                    <form action="#" method="get" runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" type="tel" class="kuang_txt phone" placeholder="手机号" required="123"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" type="email" class="kuang_txt email" placeholder="邮箱" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" type="password" class="kuang_txt possword" placeholder="密码" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" type="password" class="kuang_txt possword" placeholder="再次输入密码" required=""></asp:TextBox>
                        <asp:TextBox ID="txtCode" runat="server" type="text" class="kuang_txt yanzm" placeholder="验证码" required=""></asp:TextBox>
                        <div>
                            <div class="hui_kuang">
                                <img id="imgVerify" src="VerifyCode.aspx" alt="看不清？点击更换" onclick="this.src=this.src+'?'" style="cursor: pointer;" />
                            </div>
                            <div class="shuaxin">
                                <img src="images/zc_25.jpg" width="13" height="14" onclick="imgVerify.src=imgVerify.src+'?'">
                            </div>
                        </div>
                        <div>
                            <input name="" type="checkbox" value=""><span>已阅读并同意<a href="#" target="_self"><span class="lan">《XXXXX使用协议》</span></a></span>
                        </div>
                        <asp:Button ID="btnLogin" runat="server" Text="注册" OnClick="Unnamed1_Click" class="btn_zhuce" value="注册" />

                    </form>
                </div>
            </div>
            <%--<P>Diyhe.com&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;欢迎您定制盒子模型</P>--%>
        </div>
    </div>
</body>
</html>
