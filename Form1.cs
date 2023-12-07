
namespace winforms;

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
        this.addBtn.Text = "Add user";
        this.addBtn.Location = new Point(0, 225);
        this.addBtn.Click += AddUser;
        this.Controls.Add(addBtn);

        this.updateBtn = new Button();
        this.updateBtn.Text = "Update user";
        this.updateBtn.Location = new Point(200, 225);
        this.updateBtn.Click += UpdateUser;
        this.Controls.Add(updateBtn);

        this.readBtn = new Button();
        this.readBtn.Text = "Read all users";
        this.readBtn.Location = new Point(100, 225);
        this.readBtn.Click += ReadUser;
        this.Controls.Add(readBtn);

        this.deleteBtn = new Button();
        this.deleteBtn.Text = "Delete user";
        this.deleteBtn.Click += DeleteUser;
        this.deleteBtn.Location = new Point(300, 225);
        this.Controls.Add(deleteBtn);

        this.txtBox1 = new TextBox();
        this.txtBox1.PlaceholderText = "Username";
        this.txtBox1.Location = new Point(50, 50);
        this.Controls.Add(txtBox1);

        this.txtBox2 = new TextBox();
        this.txtBox2.PasswordChar = '*';
        this.txtBox2.PlaceholderText = "Password";
        this.txtBox2.Location = new Point(250, 50);
        this.Controls.Add(txtBox2);
    }

    #endregion

    public Button addBtn;
    public Button updateBtn;
    public Button readBtn;
    public Button deleteBtn;
    public TextBox txtBox1;
    public TextBox txtBox2;
}
