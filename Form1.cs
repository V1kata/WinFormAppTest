namespace winforms;

public partial class Form1 : Form
{
    List<User> users = new List<User>();
    public Form1()
    {
        InitializeComponent();
    }

    public void AddUser(object sender, EventArgs e) {
        if (CheckIfThereIsData()) {
            MessageBox.Show("Please fill all fields");
            return;
        }

        for (int i = 0; i < users.Count; i++) {
            if (users[i].Username == this.txtBox1.Text) {
                MessageBox.Show($"User {this.txtBox1.Text} is already regiters");
                ClearFields();
                return;
            }
        }

        User user = new User(this.txtBox1.Text, this.txtBox2.Text);
        users.Add(user);

        ClearFields();
    }

    public void ReadUser(object sender, EventArgs e) {
        string userData = "";

        foreach (var item in users)
        {
            userData += item.SeeData();
        }

        MessageBox.Show(userData);
        ClearFields();
    }

    public void UpdateUser(object sender, EventArgs e) {
        if (CheckIfThereIsData()) {
            MessageBox.Show("Please fill all fields");
            return;
        }

        User currentUser;
        string username = this.txtBox1.Text;

        for (int i = 0; i < users.Count; i++) {
            if (users[i].Username == username) {
                currentUser = users[i];
                currentUser.Password = this.txtBox2.Text;
                users[i] = currentUser;
                MessageBox.Show($"User with {username} was updated");
                break;
            } else {
                MessageBox.Show("User doesn't exist");
            }
        }

        ClearFields();
    }

    public void DeleteUser(object sender, EventArgs e) {
        if (this.txtBox1.Text == "") {
            MessageBox.Show("Please fill all fields");
            return;
        }

        string username = this.txtBox1.Text;

        for (int i = 0; i < users.Count; i++) {
            if (users[i].Username == username) {
                users.RemoveAt(i);
                MessageBox.Show($"User with {username} was deleted");
                break;
            } else {
                MessageBox.Show("User doesn't exist");
            }
        }

        ClearFields();
    }

    private void ClearFields() {
        this.txtBox1.Text = "";
        this.txtBox2.Text = "";
    }

    private bool CheckIfThereIsData() {
        if (this.txtBox1.Text == "" || this.txtBox2.Text == "") {
            return true;
        }

        return false;
    }
}
