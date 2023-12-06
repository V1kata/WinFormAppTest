using Microsoft.Win32;

namespace WinFormAppTest;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 450);
        this.Text = "Form1";

        this.addBtn = new Button();
        this.addBtn.Location = new Point(200, 225);
        this.addBtn.Text = "Add";
        this.addBtn.Click += AddUser;
        this.Controls.Add(addBtn);

        this.readBtn = new Button();
        this.readBtn.Location = new Point(100, 225);
        this.readBtn.Text = "Read";
        this.readBtn.Click += ReadUser;
        this.Controls.Add(readBtn);

        this.updateBtn = new Button();
        this.updateBtn.Location = new Point(0, 225);
        this.updateBtn.Text = "Update";
        this.updateBtn.Click += UpdateUser;
        this.Controls.Add(updateBtn);

        this.deleteBtn = new Button();
        this.deleteBtn.Location = new Point(0, 225);
        this.deleteBtn.Text = "Delete";
        this.deleteBtn.Click += DeleteUser;
        this.Controls.Add(deleteBtn);

        this.txtBox1 = new TextBox();
        this.txtBox1.Location = new Point(50, 50);
        this.txtBox1.PlaceholderText = "Username";
        this.Controls.Add(txtBox1);

        this.txtBox2 = new TextBox();
        this.txtBox2.Location = new Point(200, 50);
        this.txtBox2.PlaceholderText = "Password";
        this.Controls.Add(txtBox2);
    }

    #endregion

    public Button addBtn;
    public Button readBtn;
    public Button updateBtn;
    public Button deleteBtn;

    public TextBox txtBox1;
    public TextBox txtBox2;
}
