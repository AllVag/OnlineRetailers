<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Phone.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="css/login.css" />
    <script type="text/javascript" src="js/jquery-1.8.0.min.js"></script>
</head>
<body class="login_bj">
    <div class="zhuce_body">
        <div class="logo"><%--<a href="#"><img src="images/logo.png" width="114" height="54" border="0"></a>--%></div>
        <div class="zhuce_kong login_kuang">
            <div class="zc">
                <div class="bj_bai">
                    <h3>登录</h3>
                    <form action="#" method="get" runat="server">
                        <%--<input name="" type="text" class="kuang_txt" placeholder="手机号">
                <input name="" type="text" class="kuang_txt" placeholder="密码">--%>
                        <asp:TextBox ID="txtAccount" runat="server" class="kuang_txt" placeholder="手机号"></asp:TextBox>
                        <asp:TextBox ID="txtPwd" runat="server" class="kuang_txt" placeholder="密码" TextMode="Password"></asp:TextBox>
                        <div>
                            <a href="#">忘记密码？</a><input name="" type="checkbox" value="" checked><span>记住我</span>
                        </div>
                        <%--<input name="登录" type="button" class="btn_zhuce" value="登录">--%>
                        <asp:Button ID="Button1" runat="server" Text="登录" class="btn_zhuce" OnClick="btnLogin_Click" />
                        <a href="register.aspx">
                            <input name="注册" type="button" class="btn_zhuce" value="注册" onclick=""></a>

                    </form>
                </div>
            </div>
            <%--<P>Diyhe.com&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;欢迎您定制盒子模型</P>--%>
        </div>

    </div>
</body>
</html>
