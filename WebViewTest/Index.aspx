<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebViewTest.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hey!</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.9.4/css/bulma.min.css" integrity="sha512-HqxHUkJM0SYcbvxUw5P60SzdOTy/QVwA1JJrvaXJv4q7lmbDZCmZaqz01UPOaQveoxfYRv1tHozWGPMcuTBuvQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        body, html {
            width: 100%;
            min-height: 100%;
            height: 100%;
        }


        .form-cont {
            max-width: 450px;
        }

        .main-cont {
            height: 100%;
            width: 100%;
        }
    </style>
</head>
<body>
    <div class="main-cont">
        <form id="form1" runat="server" class="m-auto">
            <div class="form form-cont">

                <div class="field">
                    <label class="label">Category Name</label>
                    <div class="control">
                        <asp:TextBox CssClass="input" ID="TextBoxCategoryName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="field">
                    <label class="label">Unit price</label>
                    <div class="control">
                        <asp:TextBox CssClass="input" ID="TextBoxUnitPrice" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="field">
                    <label class="label">Product Name</label>
                    <div class="control">
                        <asp:TextBox CssClass="input" ID="TextBoxProductName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="field">
                    <div class="control">
                        <asp:Button OnClick="ButtonSubmit_Click" ID="ButtonSubmit" runat="server" Text="Submit" AutoPostBack="true" />
                    </div>
                </div>
            </div>
            <div class="box">
                <asp:GridView CssClass="table" ID="GridView1" runat="server"></asp:GridView>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
