namespace DeJong.VisualAStar
{
    using System.Drawing;

    public sealed class PaintConfig
    {
        public Color WallColor { get { return wall; } set { wall = value; WallBrush = new SolidBrush(wall); } }
        public Color StartColor { get { return start; } set { start = value; StartBrush = new SolidBrush(start); } }
        public Color EndColor { get { return end; } set { end = value; EndBrush = new SolidBrush(end); } }
        public Color CurColor { get { return cur; } set { cur = value; CurBrush = new SolidBrush(cur); } }
        public Color TextColor { get { return text; } set { text = value; TextBrush = new SolidBrush(text); } }
        public Color ArrowColor { get { return arrow ; } set { arrow = value; ArrowBrush = new SolidBrush(arrow); } }
        public Color GridColor { get { return grid; } set { grid = value; GridPen = new Pen(grid, gridSize); } }
        public Color RouteColor { get { return route; } set { route = value; RoutePen = new Pen(route, routeSize); } }

        public int GridSize { get { return gridSize; } set { gridSize = value; GridPen = new Pen(grid, gridSize); } }
        public int RouteSize { get { return routeSize; } set { routeSize = value; RoutePen = new Pen(route, routeSize); } }

        public SolidBrush WallBrush { get; private set; }
        public SolidBrush StartBrush { get; private set; }
        public SolidBrush EndBrush { get; private set; }
        public SolidBrush CurBrush { get; private set; }
        public SolidBrush TextBrush { get; private set; }
        public SolidBrush ArrowBrush { get; private set; }

        public Pen GridPen { get; private set; }
        public Pen RoutePen { get; private set; }

        public Font TextFont { get; set; }

        public bool ShowHeuristic { get; set; }
        public bool ShowGValue { get; set; }
        public bool ShowFValue { get; set; }
        public bool ShowParent { get; set; }
        public int NodeSize { get; set; }
        public int RouteOffset { get { return NodeSize >> 1; } }
        public int MapMargin { get { return 25; } }

        private Color wall, start, end, cur, text, arrow, grid, route;
        private int gridSize, routeSize;
        
        public PaintConfig()
        {
            WallColor = Color.Red;
            StartColor = Color.Green;
            EndColor = Color.Yellow;
            CurColor = Color.Orange;
            TextColor = Color.Black;
            ArrowColor = Color.Cyan;

            grid = Color.Blue;
            route = Color.Blue;
            GridSize = 2;
            RouteSize = 10;

            TextFont = new Font("Arial", 12);

            ShowHeuristic = true;
            ShowGValue = true;
            ShowFValue = false;
            ShowParent = true;
            NodeSize = 100;
        }

        public void Update(PaintConfig config)
        {
            WallColor = config.WallColor;
            StartColor = config.StartColor;
            EndColor = config.EndColor;
            CurColor = config.CurColor;
            TextColor = config.TextColor;
            ArrowColor = config.ArrowColor;

            grid = config.grid;
            route = config.route;
            GridSize = config.GridSize;
            RouteSize = config.RouteSize;

            TextFont = config.TextFont;
            NodeSize = config.NodeSize;
        }

        public PaintConfig Clone()
        {
            return MemberwiseClone() as PaintConfig;
        }
    }
}