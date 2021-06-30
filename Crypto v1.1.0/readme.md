# Crypto

## What is it??
Crypto has been my first application with a actual usage. It uses the `RijndaelManaged` class to encrypt and decrypt any type of data. It uses a max of 32 char password. <br />
It's fully coded in C# and I used the winform framework. It is a really simple app although you can do very powerful things with it.

## How to use it??
The friendly UI helps you to understand how to use it. <br />

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/Crypto.png" alt="Crypto UI" height=350>

## 🟢 Input<br />
There are two types of inputs in Crypto. One is `file` and the other one is `folder`. <br />

  ### File
  The file option encodes a single file with the given password.
  
  ### Folder
  The folder option encodes all the file it finds in a folder. If a file couldn't be encoded then at the end of all encodings it will give you a warning saying how many <br />
  files have been skipped and their name. <br />

## 🟠 Settings<br />
In the settings section you can choose what to do with the file (`encode` or `decode` it), plus you can fill the password textbox with whatever password you want! <br />
It needs to be between `1` and `32` characters long though. 

## 🔵 Output Data<br />
This section gives you information about the application status and about the `file size`.

<img src="https://github.com/FrancescoMaca/FrancescoMaca/blob/main/images/Crypto_info.png" alt="Crypto UI with markup">


## Bugs

🔴 _Several graphical/logical bugs when using the `folder` option.

🟠 _The starting operation is too slow.

🟠 _Sometimes the loading bar can be not synced with the action the program's doing.

🟢 _Moving the window fast produces massive draw lag.

🟢 _Graphic bug when pressing the `Show Password` button (lasts for ~0.5 sec).


### Version: 1.1.0
