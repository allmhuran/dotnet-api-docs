﻿using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

public class Form1: Form
{
 protected TextBox textBox1;
// <Snippet1>
 public void CreateMyMainMenu()
 {
    // Create two MenuItem objects and assign to array.
    MenuItem menuItem1 = new MenuItem();
    MenuItem menuItem2 = new MenuItem();
 
    menuItem1.Text = "&File";
    menuItem2.Text = "&Edit";
 
    // Create a MainMenu and assign MenuItem objects.
    MainMenu mainMenu1 = new MainMenu(new MenuItem[] {
          menuItem1,
          menuItem2});
    
    // Bind the MainMenu to Form1.
    Menu = mainMenu1;   
 }

// </Snippet1>
}
