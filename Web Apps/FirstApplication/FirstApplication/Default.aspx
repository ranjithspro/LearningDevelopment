<%@ Page Language="C#" Inherits="FirstApplication.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
<title>Default</title>
		

</head>
<body>
		<script type='text/javascript'>
    function OnClick() {
			alert('Hi');
    }
        </script>
		
		  <input type="button" name="GoogleButton" value="Go To Google" onclick="OnClick();"/>
		  <p> </p>
		
	<!--<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
			<br>
      
	</form>-->
		</body>
</html>
