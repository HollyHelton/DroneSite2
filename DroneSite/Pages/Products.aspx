<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="DroneSite.Pages.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <div>
        <h3>Products</h3>
    </div>
    <div>
        <asp:ListView id="product_list" runat="server">
            <ItemTemplate>
                <ul>
                    <li id="drone_list1"></li>
                    <li id="drone_list2"><p id="drone_desc"></p></li>
                    <li id="drone_list3"><image id="drone_image"></image></li>
                    <li id="drone_list4"></li>
                    <li id="drone_list5"></li>
                    <li id="drone_list6">
                        <table>
                            <tr>
                                <th>Dimensions</th>
                                <th>Weight</th>
                                <th>Battery Life</th>
                                <th>Range</th>
                            </tr>
                            <tr>
                                <td id="drone_dimensions"></td>
                                <td id="drone_weight"></td>
                                <td id="drone_battery"></td>
                                <td id="drone_range"></td>
                            </tr>
                        </table>
                    </li>
                </ul>
            </ItemTemplate>
        </asp:ListView>
    </div>
</body>
</html>
