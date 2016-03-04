<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Target._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="font-style: italic; text-decoration: underline blink">ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div>
        <asp:ListView ID="ListViewTestTarget" runat="server" DataSourceID="SqlDataSourceListView" DataKeyNames="Id" InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="削除" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="編集" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' Font-Italic="true" Font-Bold="true" />
                    </td>
                    <td>
                        <asp:Label ID="LabelLabel" runat="server" Text='<%# Eval("Label") %>' />
                    </td>
                    <td onmouseover="ShowMsgBox('a')">
                        <asp:TextBox ID="TextBoxLabel" runat="server" Text='<%# Eval("TextBox") %>' />
                    </td>
                    <td>
                        <asp:Button ID="ButtonLabel" runat="server" Text='<%# Eval("Button") %>' />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButtonLabel" runat="server" Text='<%# Eval("LinkButton") %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxLabel" runat="server" Checked='<%# Eval("CheckBox") %>' Enabled="True" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButtonLabel" runat="server"  Checked='<%# Eval("RadioButton") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="キャンセル" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LabelTextBox" runat="server" Text='<%# Bind("Label") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxTextBox" runat="server" Text='<%# Bind("TextBox") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ButtonTextBox" runat="server" Text='<%# Bind("Button") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LinkButtonTextBox" runat="server" Text='<%# Bind("LinkButton") %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCheckBox" runat="server" Checked='<%# Bind("CheckBox") %>' />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButtonCheckBox" runat="server" Checked='<%# Bind("RadioButton") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>データは返されませんでした。</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="挿入" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="クリア" />
                    </td>
                    <td>
                        <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LabelTextBox" runat="server" Text='<%# Bind("Label") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxTextBox" runat="server" Text='<%# Bind("TextBox") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ButtonTextBox" runat="server" Text='<%# Bind("Button") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LinkButtonTextBox" runat="server" Text='<%# Bind("LinkButton") %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCheckBox" runat="server" Checked='<%# Bind("CheckBox") %>' />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButtonCheckBox" runat="server" Checked='<%# Bind("RadioButton") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="削除" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="編集" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LabelLabel" runat="server" Text='<%# Eval("Label") %>' />
                    </td>
                    <td onmouseover="ShowMsgBox('i')">
                        <asp:TextBox ID="TextBoxLabel" runat="server" Text='<%# Eval("TextBox") %>' />
                    </td>
                    <td>
                        <asp:Button ID="ButtonLabel" runat="server" Text='<%# Eval("Button") %>' />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButtonLabel" runat="server" Text='<%# Eval("LinkButton") %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxLabel" runat="server" Checked='<%# Eval("CheckBox") %>' Enabled="True" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButtonLabel" runat="server" Checked='<%# Eval("RadioButton") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server"></th>
                                    <th runat="server">Id</th>
                                    <th runat="server">Label</th>
                                    <th runat="server">TextBox</th>
                                    <th runat="server">Button</th>
                                    <th runat="server">LinkButton</th>
                                    <th runat="server">CheckBox</th>
                                    <th runat="server">RadioButton</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="削除" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="編集" />
                    </td>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LabelLabel" runat="server" Text='<%# Eval("Label") %>' />
                    </td>
                    <td onmouseover="ShowMsgBox('s')">
                        <asp:TextBox ID="TextBoxLabel" runat="server" Text='<%# Eval("TextBox") %>' />
                    </td>
                    <td>
                        <asp:Button ID="ButtonLabel" runat="server" Text='<%# Eval("Button") %>' />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButtonLabel" runat="server" Text='<%# Eval("LinkButton") %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxLabel" runat="server" Checked='<%# Eval("CheckBox") %>' Enabled="True" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButtonLabel" runat="server" Checked='<%# Eval("RadioButton") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSourceListView" runat="server" ConnectionString="Data Source=BINNSURFACE4\SQLEXPRESS;Initial Catalog=ListViewTestData;User ID=sa;Password=codeer" DeleteCommand="DELETE FROM [Table_Data] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Table_Data] ([Id], [Label], [TextBox], [Button], [LinkButton], [CheckBox], [RadioButton]) VALUES (@Id, @Label, @TextBox, @Button, @LinkButton, @CheckBox, @RadioButton)" SelectCommand="SELECT [Id], [Label], [TextBox], [Button], [LinkButton], [CheckBox], [RadioButton] FROM [Table_Data]" UpdateCommand="UPDATE [Table_Data] SET [Label] = @Label, [TextBox] = @TextBox, [Button] = @Button, [LinkButton] = @LinkButton, [CheckBox] = @CheckBox, [RadioButton] = @RadioButton WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Label" Type="String" />
                <asp:Parameter Name="TextBox" Type="String" />
                <asp:Parameter Name="Button" Type="String" />
                <asp:Parameter Name="LinkButton" Type="String" />
                <asp:Parameter Name="CheckBox" Type="Boolean" />
                <asp:Parameter Name="RadioButton" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Label" Type="String" />
                <asp:Parameter Name="TextBox" Type="String" />
                <asp:Parameter Name="Button" Type="String" />
                <asp:Parameter Name="LinkButton" Type="String" />
                <asp:Parameter Name="CheckBox" Type="Boolean" />
                <asp:Parameter Name="RadioButton" Type="Boolean" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <input id="button1" type="button" value="Debug" onclick="AddColmns()" />
        <script type="text/javascript">

            function ShowMsgBox(parameters) {
            }
            function AddColmns(data)
            {

                //var grid = $find("MainContent_ListViewTestTarget");

                var listview = $("MainContent_ListViewTestTarget_itemPlaceholderContainer");

                var trs = $("#MainContent_ListViewTestTarget_itemPlaceholderContainer").find("tr");


                alert(trs);
                alert(trs[0]);
                alert(trs[0].get_element());

                //var script = $"var {WebElement.VarName}=$('{subItem.Parent.Parent.Id} + _itemPlaceholderContainer')[{subItem.Index}].get_element();";

            }
        </script>

    </div>
</asp:Content>
