namespace DeJong.VisualAStar
{
    using System.Windows.Forms;

    public partial class MainWindow : Form
    {
        public SimulationState CurrentState { get; set; }

        private const int WS_EX_COMPOSITED = 0x02000000;
        private Painter painter;
        private Map map;
        private bool auto;

        public MainWindow()
        {
            InitializeComponent();
            painter = new Painter(this);
            UpdateMapSize();
            CurrentState = SimulationState.CreateMap;
        }

        private void UpdateMapSize()
        {
            map = new Map(SldWidth.Value, SldHeight.Value);
            painter.Initialize(map);
            Invalidate();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            if (map != null) painter.Draw(e.Graphics, map);
        }

        private void SldWidth_ValueChanged(object sender, System.EventArgs e)
        {
            LblWidth.Text = $"Width: {SldWidth.Value}";
            UpdateMapSize();
        }

        private void SldHeight_ValueChanged(object sender, System.EventArgs e)
        {
            LblHeight.Text = $"Height: {SldHeight.Value}";
            UpdateMapSize();
        }

        private void BtnFinalizeSize_Click(object sender, System.EventArgs e)
        {
            SldWidth.Enabled = false;
            SldHeight.Enabled = false;
            BtnFinalizeSize.Enabled = false;
            CurrentState = SimulationState.SetStart;
        }

        private void BtnFinalizeMap_Click(object sender, System.EventArgs e)
        {
            BtnFinalizeMap.Enabled = false;
            BtnTick.Enabled = true;
            BtnAutoUpdate.Enabled = true;
            CurrentState = SimulationState.FindingPath;
            AStar.Initialize(map);
        }

        private void BtnTick_Click(object sender, System.EventArgs e)
        {
            Tick();
        }

        private void Tick()
        {
            if (AStar.Tick())
            {
                if (!AStar.Failed) painter.SetPath(AStar.Result);
                BtnTick.Enabled = false;
            }

            Text = $"Visualization of A* ({(AStar.State != AStarState.Done ? AStar.State.ToString() : (AStar.Failed ? "Failed" : "Succeeded"))})";
            painter.SetCurrent(AStar.Current.Postition);

            ListViewClosed.Items.Clear();
            for (int i = 0; i < AStar.ClosedList.Count; i++)
            {
                ListViewClosed.Items.Add(AStar.ClosedList[i].Postition.ToString());
            }

            ListViewOpen.Items.Clear();
            for (int i = 0; i < AStar.OpenList.Count; i++)
            {
                ListViewOpen.Items.Add(AStar.OpenList[i].Postition.ToString());
            }

            Invalidate();
        }

        private void CheckH_CheckedChanged(object sender, System.EventArgs e)
        {
            painter.Config.ShowHeuristic = CheckH.Checked;
            painter.Initialize(map);
            Invalidate();
        }

        private void CheckG_CheckedChanged(object sender, System.EventArgs e)
        {
            painter.Config.ShowGValue = CheckG.Checked;
            painter.Initialize(map);
            Invalidate();
        }

        private void CheckF_CheckedChanged(object sender, System.EventArgs e)
        {
            painter.Config.ShowFValue = CheckF.Checked;
            painter.Initialize(map);
            Invalidate();
        }

        private void CheckP_CheckedChanged(object sender, System.EventArgs e)
        {
            painter.Config.ShowParent = CheckP.Checked;
            Invalidate();
        }

        private void MainWindow_Click(object sender, System.EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            if (!painter.WorkSpace.Contains(me.Location)) return;
            Vector2 relPos = new Vector2((me.X - painter.WorkSpace.X) / 100, (me.Y - painter.WorkSpace.Y) / 100);

            switch (CurrentState)
            {
                case SimulationState.SetStart:
                    SetStartClick(relPos);
                    break;
                case SimulationState.SetEnd:
                    SetEndClick(relPos);
                    break;
                case SimulationState.SetWalls:
                    SetWallClick(relPos);
                    break;
                case SimulationState.CreateMap:
                case SimulationState.FindingPath:
                case SimulationState.PathFound:
                    return;
            }

            Invalidate();
        }

        private void SetStartClick(Vector2 pos)
        {
            map.SetStart(pos);
            painter.SetStart(pos);
            CurrentState = SimulationState.SetEnd;
        }

        private void SetEndClick(Vector2 pos)
        {
            map.SetEnd(pos);
            painter.SetEnd(pos);
            painter.Initialize(map);
            CurrentState = SimulationState.SetWalls;
            BtnFinalizeMap.Enabled = true;
        }

        private void SetWallClick(Vector2 pos)
        {
            Node node = map[pos];
            if (node.Postition == map.EndPos || node.Postition == map.StartPos) return;
            node.IsImpassable = !node.IsImpassable;
        }

        private void BtnAutoUpdate_Click(object sender, System.EventArgs e)
        {
            if (auto)
            {
                AutoTicker.Stop();
                BtnAutoUpdate.Text = "Start AutoTick";
            }
            else
            {
                AutoTicker.Start();
                BtnAutoUpdate.Text = "Stop AutoTick";
            }

            auto = !auto;
        }

        private void AutoTicker_Tick(object sender, System.EventArgs e)
        {
            Tick();
            if (!BtnTick.Enabled) AutoTicker.Stop();
        }

        private void BtnReset_Click(object sender, System.EventArgs e)
        {
            if (auto) AutoTicker.Stop();
            painter.Reset();
            AStar.Reset();
            CurrentState = SimulationState.CreateMap;
            SldWidth.Enabled = true;
            SldHeight.Enabled = true;
            BtnFinalizeSize.Enabled = true;
            BtnFinalizeMap.Enabled = false;
            BtnTick.Enabled = false;
            BtnAutoUpdate.Enabled = false;
            ListViewClosed.Clear();
            ListViewOpen.Clear();
            Text = "Visualization of A*";
            UpdateMapSize();
        }
    }
}