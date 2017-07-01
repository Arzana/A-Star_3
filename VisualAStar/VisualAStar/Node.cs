namespace DeJong.VisualAStar
{
    using System.Drawing;

    public sealed class Node
    {
        public int Heuristic { get; private set; }
        public int GValue { get; set; }
        public int FValue { get { return GValue + Heuristic; } }

        public Vector2 Postition { get; private set; }
        public Node Parent { get; private set; }
        public bool HasParent { get { return Parent != null; } }
        public bool IsImpassable { get; set; }

        public Rectangle DrawRect { get; private set; }
        public string HeuristicText { get; private set; }
        public PointF HeuristicPosition { get; private set; }
        public string GText { get { return $"G: {GValue}"; } }
        public PointF GPosition { get; private set; }
        public string FText { get { return $"F: {FValue}"; } }
        public PointF FPosition { get; private set; }

        public Node(Vector2 position)
        {
            Postition = position;
        }

        public void SetDrawValiables(PaintConfig config, Vector2 offset)
        {
            Vector2 drawPos = Postition * config.NodeSize + offset;
            DrawRect = new Rectangle((int)drawPos.X, (int)drawPos.Y, config.NodeSize, config.NodeSize);

            int heightAdder = config.TextFont.Height + 1;
            int heightOffset = 0;

            if (config.ShowHeuristic)
            {
                HeuristicText = $"H: {Heuristic}";
                HeuristicPosition = drawPos;
                heightOffset += heightAdder;
            }

            if (config.ShowGValue)
            {
                GPosition = new PointF(drawPos.X, drawPos.Y + heightOffset);
                heightOffset += heightAdder;
            }

            if (config.ShowFValue)
            {
                FPosition = new PointF(drawPos.X, drawPos.Y + heightOffset);
                heightOffset += heightAdder;
            }
        }

        public void SetHeuristic(Vector2 endPos)
        {
            Heuristic = (int)Vector2.DistanceManhattan(Postition, endPos);
        }

        public void SetParent(Node newParent, int cost)
        {
            GValue += newParent.GValue + cost;
            Parent = newParent;
        }
    }
}