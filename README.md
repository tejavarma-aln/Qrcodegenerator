# Qrcodegenerator

*********Qr Code Generator for Tally************


**GET STARTED**

1) Download all the files to the tally application folder

2) Register the Dll (Qrcodegenerator.dll) with the below Steps

3) load the txt file (Qrcode.txt) in Tally as normal TDL

4) Goto f11->Addon Features-> Enable Qr Code : Yes

5) Click on the  Button(Generate Qr Code) in sales voucher to Generate Qr Code and print the invoice


**Steps to Register DL**


1)Copy file (Qrcodegenerator.dll) to C:\Windows\System32

2)Open Cmd in administrator Mode (Elavated mode)

      64bit machine

3)CD C:\Windows\Microsoft.NET\Framework64\v4.0.30319 ;; change directory

     32bit machine

3)CD C:\Windows\Microsoft.NET\Framework64\v4.0.30319 ;; change directory

4)Type regasm Qrcodegenerator.dll /codebase  ;; Full path to Qrcodegenerator.dll

5)you will get success message after it registered


**Requirements**

1).Net Framework Version 4.x.x
  
 You can Download from here : https://dotnet.microsoft.com/download/dotnet-framework/net40


**Qrcode will be displayed at top left of the invoice**

Thanks..
