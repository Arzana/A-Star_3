namespace DeJong.VisualAStar
{
    using System.Windows.Forms;

    public partial class SettingsWindow : Form
    {
        public PaintConfig Config { get { return Config; } set { config = value; temp = config.Clone(); UpdateGUI(); } }
        public int TickCooldown { get; set; }

        private PaintConfig config;
        private PaintConfig temp;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void UpdateGUI()
        {
            BtnWallColor.BackColor = temp.WallColor;
            BtnStartColor.BackColor = temp.StartColor;
            BtnEndColor.BackColor = temp.EndColor;
            BtnCurColor.BackColor = temp.CurColor;
            BtnTextColor.ForeColor = temp.TextColor;
            BtnArrowColor.BackColor = temp.ArrowColor;
            BtnGridColor.BackColor = temp.GridColor;
            BtnRouteColor.BackColor = temp.RouteColor;
            BtnClosedColor.BackColor = temp.ClosedColor;
            BtnOpenColor.BackColor = temp.OpenColor;
            NumGridPenSize.Value = temp.GridSize;
            NumRoutePenSize.Value = temp.RouteSize;
            NumNodeSize.Value = temp.NodeSize;
            NumTickCooldown.Value = TickCooldown;
        }

        private void BtnApply_Click(object sender, System.EventArgs e)
        {
            temp.GridSize = (int)NumGridPenSize.Value;
            temp.RouteSize = (int)NumRoutePenSize.Value;
            temp.NodeSize = (int)NumNodeSize.Value;
            TickCooldown = (int)NumTickCooldown.Value;
            config.Update(temp);
            Close();
        }

        private void BtnWallColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.WallColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnStartColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.StartColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnEndColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.EndColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnCurColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.CurColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnTextColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.TextColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnArrowColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.ArrowColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnGridColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.GridColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnRouteColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.RouteColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnClosedColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.ClosedColor = DialogColor.Color;
                UpdateGUI();
            }
        }

        private void BtnOpenColor_Click(object sender, System.EventArgs e)
        {
            if (DialogColor.ShowDialog() == DialogResult.OK)
            {
                temp.OpenColor = DialogColor.Color;
                UpdateGUI();
            }
        }
    }
}