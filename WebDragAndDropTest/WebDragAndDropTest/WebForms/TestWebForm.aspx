<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
    <link rel="stylesheet" href="style.css" type="text/css" media="screen"/>
    <script type="text/javascript" src="redips-drag-min.js"></script>
    <style type="text/css">
        .redips-drag {width: 100px}
    </style>
</head>
<body onload="REDIPS.drag.init()">
<form id="HtmlForm" runat="server">
    <div id="redips-drag" style="text-align: center;">
        <label>Table</label>
        <table>
            <colgroup>
                <col width="120"/>
                <col width="120"/>
                <col width="120"/>
            </colgroup>
            <tbody>
                <tr>
                    <td><div class="redips-drag">Hello World</div></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </div>
</form>
</body>
</html>
