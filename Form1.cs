namespace PointCounter
{
    public partial class Form1 : Form
    {
        private int userPoints = 0;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblPoints.Text = $"Points: {userPoints}";
        }

        private void GivePoints_Click(object sender, EventArgs e)
        {
            userPoints += 5;
            lblPoints.Text = $"Points: {userPoints}";
        }

        private void DeductPoints_Click(object sender, EventArgs e)
        {
            if (userPoints >= 5)
            {
                userPoints -= 5;
                lblPoints.Text = $"Points: {userPoints}";
            }
            else
            {
                MessageBox.Show("Not enough points to deduct", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
