namespace DeJong.VisualAStar
{
    using System.Drawing;

    public sealed class Map
    {
        public Vector2 StartPos { get; private set; }
        public Vector2 EndPos { get; private set; }
        public Rectangle Dim { get; private set; }

        public Node Start { get { return this[StartPos]; } }
        public Node End { get { return this[EndPos]; } }

        private Node[] nodes;
        private int w, h;

        public Node this[float x, float y]
        {
            get { return nodes[((int)y) * w + (int)x]; }
            set { nodes[((int)y) * w + (int)x] = value; }
        }

        public Node this[Vector2 pos]
        {
            get { return this[pos.X, pos.Y]; }
            set { this[pos.X, pos.Y] = value; }
        }

        public Map(int width, int height)
        {
            w = width;
            h = height;
            Dim = new Rectangle(0, 0, w, h);
            EmptyMap();
        }

        public void SetStart(Vector2 pos)
        {
            StartPos = pos;
        }

        public void SetEnd(Vector2 pos)
        {
            EndPos = pos;
            SetHeuristic();
        }

        public void Initialize(PaintConfig config, Vector2 offset)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].SetDrawValiables(config, offset);
            }
        }

        public void EmptyMap()
        {
            nodes = new Node[w * h];

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    nodes[(y * w + x)] = new Node(new Vector2(x, y));
                }
            }

            StartPos = Vector2.InvOne;
            EndPos = Vector2.InvOne;
        }

        private void SetHeuristic()
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].SetHeuristic(EndPos);
            }
        }
    }
}