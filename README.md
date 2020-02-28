# Qrcodegenerator
*********Qr Code Generator for Tally************


*Download all the files to the tally application folder

*Register the Dll with the below Steps

*load the txt file in Tally 

* Goto f11->Addon Features-> Enable Qr Code : Yes

* Click on the  Button(Generate Qr Code) in sales voucher to Generate Qr Code and print the invoice


# Steps to Register DLL:


1)Copy file (Qrcodegenerator.dll) to C:\Windows\System32

2)Open Cmd in administrator Mode (Elavated mode)

3)CD C:\Windows\Microsoft.NET\Framework64\v4.0.30319 ;; change directory

4)Type without quote "regasm Qrcodegenerator.dll /codebase"

5)you will get success message after it registered

you can customise the tdl as per your needs

it requires .Net framework version 4 in order to install this dll and work

*Qrcode will be displayed at top left of the invoice

*customize the tdl as per you need

**** Make sure all the files placed in Tally Working Directory

Thanks..
