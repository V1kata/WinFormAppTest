using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormAppTest;

public partial class Form1 : Form
{
    List<User> users = new List<User>();
    // private static nextId = 0;
    public Form1()
    {
        InitializeComponent();
    }

    public void AddUser(object sender, EventArgs e)
    {
        if (CheckTxtBoxInfo())
        {
            return;
        }

        User user = new User(this.txtBox1.Text, this.txtBox2.Text);
        users.Add(user);

        ResetTxtBox();
    }

    public void ReadUser(object sender, EventArgs e)
    {
        string userData = "";

        foreach (var item in users)
        {
            userData += item.ToString() + "\n";
        }

        MessageBox.Show(userData);
    }

    public void UpdateUser(object sender, EventArgs e)
    {
        if (CheckTxtBoxInfo())
        {
            return;
        }

        string username = this.txtBox1.Text;
        User currentUser;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Username.Contains(username))
            {
                currentUser = users[i];
                string newPassword = this.txtBox2.Text;
                currentUser.Password = newPassword;
                users[i] = currentUser;
                break;
            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }
        }

        ResetTxtBox();
    }

    public void DeleteUser(object sender, EventArgs e)
    {
        string username = this.txtBox1.Text;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Username.Equals(username))
            {
                users.RemoveAt(i);
                break;
            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }
        }
    }

    public void ResetTxtBox()
    {
        this.txtBox1.Text = "";
        this.txtBox2.Text = "";
    }

    public bool CheckTxtBoxInfo()
    {
        if (this.txtBox1.Text == "" || this.txtBox2.Text == "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
