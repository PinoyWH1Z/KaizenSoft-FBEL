# KaizenSoft-FBEL
## Facebook Easy Login<p>


With this Dynamic Link Library (DLL) that I created, 
you can easily add a facebook login/auth in your application/software.
This is more-like a class by which helps you configure your software to
adopt the way "Facebook" uses to log-in their users.<p>
<p>
<p>
### _How to use?:_

Simply add "**KaizenSoft - FBEL.dll**" as your project reference and use the guides/examples below to make it functional<p>
https://github.com/kaizenlouie/KaizenSoft-FBEL/releases/download/1.0/KaizenSoft.-.FBEL.dll
<p><p><p>
### _Example usage in C#:_

`KaizenSoftFBEL.KaizenSoftFBEL fbLogin = new KaizenSoftFBEL.KaizenSoftFBEL();`<p>
            `if (fbLogin.Enter(textBox1.Text, textBox2.Text))`<p>
            `{ MessageBox.Show("Login Successful"); }`<p>
            `else`<p>
            `{ MessageBox.Show("Login Error."); }`<p><p><p>
            
            
            
### _Example usage in VB.NET:_       

` Dim fbLogin As New KaizenSoftFBEL.KaizenSoftFBEL()`<p>
        `If fbLogin.Enter(TextBox1.Text, TextBox2.Text) Then`<p>
            `MessageBox.Show("Login successful.")`<p>
        `Else`<p>
            `MessageBox.Show("Login error.")`<p>
        `End If`<p>
