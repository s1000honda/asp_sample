<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DisplayImages._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
 <script type="text/javascript" language="javascript">
     function setsrc(img_filename) {
         document.getElementById("embed1").src = 'viewer.ashx?FileName=' + img_filename;
     }
 </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <embed id="embed1" runat="server">Image</embed>
    </div>
    </form>
</body>
</html>
