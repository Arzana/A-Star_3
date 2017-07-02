namespace DeJong.VisualAStar
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public sealed class Painter
    {
        public PaintConfig Config { get; private set; }
        public Rectangle WorkSpace { get { return new Rectangle((int)offset.X, (int)offset.Y, window.Width - (int)offset.X, window.Height - (int)offset.Y); } }

        private RectangleF? startRect, endRect, curRect;
        private Vector2 offset, hafNode;
        private MainWindow window;
        private PointF[] path;

        public Painter(MainWindow w)
        {
            Config = new PaintConfig();
            offset = new Vector2(
                w.ControllGroup.Location.X + w.ControllGroup.Width + w.ControllGroup.Margin.Right,
                w.ControllGroup.Location.Y + w.ControllGroup.Margin.Top * 2);
            hafNode = new Vector2(Config.NodeSize / 2);
            window = w;
        }

        public void Initialize(Map map)
        {
            map.Initialize(Config, offset);
            hafNode = new Vector2(Config.NodeSize / 2);
        }

        public void Reset()
        {
            startRect = null;
            endRect = null;
            curRect = null;
            path = null;
        }

        public void SetStart(Vector2 position)
        {
            position = position * Config.NodeSize + offset;
            startRect = new RectangleF(position.X, position.Y, Config.NodeSize, Config.NodeSize);
        }

        public void SetEnd(Vector2 position)
        {
            position = position * Config.NodeSize + offset;
            endRect = new RectangleF(position.X, position.Y, Config.NodeSize, Config.NodeSize);
        }

        public void SetCurrent(Vector2 position)
        {
            position = position * Config.NodeSize + offset + hafNode / 2;
            curRect = new RectangleF(position.X, position.Y, Config.NodeSize / 2, Config.NodeSize / 2);
        }

        public void SetPath(List<Node> result)
        {
            path = new PointF[result.Count];
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = result[i].DrawRect.Location + hafNode;
            }
        }

        public void Draw(Graphics gfx, Map map)
        {
            Rectangle dim = map.Dim;
            int width = (int)offset.X + dim.Width * Config.NodeSize + Config.MapMargin;
            int height = (int)offset.Y + dim.Height * Config.NodeSize + Config.MapMargin + (window.Height - window.ClientRectangle.Height);
            bool mustUpdateGraphicsDevice = false;

            if ((width > window.Width) || (width > window.MinimumSize.Width && width < window.Width))
            {
                window.Width = width;
                mustUpdateGraphicsDevice = true;
            }

            if ((height > window.Height) || (height > window.MinimumSize.Height && height < window.Height))
            {
                window.Height = height;
                mustUpdateGraphicsDevice = true;
            }

            if (mustUpdateGraphicsDevice)
            {
                window.Invalidate();
                return;
            }

            if (map.StartPos != Vector2.InvOne) DrawStart(gfx);
            if (map.EndPos != Vector2.InvOne) DrawEnd(gfx);
            if (curRect != null) DrawCurrent(gfx);

            for (int y = 0; y < dim.Height; y++)
            {
                for (int x = 0; x < dim.Width; x++)
                {
                    DrawNode(gfx, map[x, y]);
                }
            }

            if (path != null) DrawPath(gfx);
        }

        private void DrawStart(Graphics gfx)
        {
            gfx.FillEllipse(Config.StartBrush, startRect.Value);
        }

        private void DrawEnd(Graphics gfx)
        {
            gfx.FillEllipse(Config.EndBrush, endRect.Value);
        }

        private void DrawCurrent(Graphics gfx)
        {
            gfx.FillEllipse(Config.CurBrush, curRect.Value);
        }

        private void DrawParentArrow(Graphics gfx, PointF start, PointF end)
        {
            PointF[] points = null;
            if (end.X < start.X) points = GetLeftArrowPoints(start, end);
            else if (end.Y < start.Y) points = GetUpArrowPoints(start, end);
            else if (end.X > start.X) points = GetRightArrowPoints(start, end);
            else if (end.Y > start.Y) points = GetDownArrowPoints(start, end);

            for (int i = 0; i < points.Length; i++) points[i] = points[i] + hafNode;

            gfx.FillPolygon(Config.ArrowBrush, points, FillMode.Winding);
        }

        private PointF[] GetLeftArrowPoints(PointF start, PointF end)
        {
            Vector2 p1 = end;
            Vector2 p2 = p1 + new Vector2(hafNode.X, -(hafNode.Y / 2));
            Vector2 p3 = p2 + new Vector2(0, hafNode.Y / 4);
            Vector2 p4 = start - new Vector2(0, hafNode.Y / 4);
            Vector2 p5 = start + new Vector2(0, hafNode.Y / 4);
            Vector2 p6 = p3 + new Vector2(0, hafNode.Y / 2);
            Vector2 p7 = p1 + new Vector2(hafNode.X, hafNode.Y / 2);

            return new PointF[] { p1, p2, p3, p4, p5, p6, p7 };
        }

        private PointF[] GetRightArrowPoints(PointF start, PointF end)
        {
            Vector2 p1 = end;
            Vector2 p2 = p1 + new Vector2(-hafNode.X, -(hafNode.Y / 2));
            Vector2 p3 = p2 + new Vector2(0, hafNode.Y / 4);
            Vector2 p4 = start - new Vector2(0, hafNode.Y / 4);
            Vector2 p5 = start + new Vector2(0, hafNode.Y / 4);
            Vector2 p6 = p3 + new Vector2(0, hafNode.Y / 2);
            Vector2 p7 = p1 + new Vector2(-hafNode.X, hafNode.Y / 2);

            return new PointF[] { p1, p2, p3, p4, p5, p6, p7 };
        }

        private PointF[] GetUpArrowPoints(PointF start, PointF end)
        {
            Vector2 p1 = end;
            Vector2 p2 = p1 + new Vector2(-(hafNode.X / 2), hafNode.Y);
            Vector2 p3 = p2 + new Vector2(hafNode.X / 4, 0);
            Vector2 p4 = start - new Vector2(hafNode.Y / 4, 0);
            Vector2 p5 = start + new Vector2(hafNode.Y / 4, 0);
            Vector2 p6 = p3 + new Vector2(hafNode.Y / 2, 0);
            Vector2 p7 = p1 + new Vector2(hafNode.X / 2, hafNode.Y);

            return new PointF[] { p1, p2, p3, p4, p5, p6, p7 };
        }

        private PointF[] GetDownArrowPoints(PointF start, PointF end)
        {
            Vector2 p1 = end;
            Vector2 p2 = p1 + new Vector2(-(hafNode.X / 2), -hafNode.Y);
            Vector2 p3 = p2 + new Vector2(hafNode.X / 4, 0);
            Vector2 p4 = start - new Vector2(hafNode.Y / 4, 0);
            Vector2 p5 = start + new Vector2(hafNode.Y / 4, 0);
            Vector2 p6 = p3 + new Vector2(hafNode.Y / 2, 0);
            Vector2 p7 = p1 + new Vector2(hafNode.X / 2, -hafNode.Y);

            return new PointF[] { p1, p2, p3, p4, p5, p6, p7 };
        }

        private void DrawNode(Graphics gfx, Node node)
        {
            if (node.IsImpassable) gfx.FillRectangle(Config.WallBrush, node.DrawRect);
            else
            {
                gfx.DrawRectangle(Config.GridPen, node.DrawRect);

                if (Config.ShowParent && node.HasParent) DrawParentArrow(gfx, node.DrawRect.Location, node.Parent.DrawRect.Location);
                if (Config.ShowHeuristic) DrawString(gfx, node.HeuristicText, node.HeuristicPosition);
                if (Config.ShowGValue) DrawString(gfx, node.GText, node.GPosition);
                if (Config.ShowFValue) DrawString(gfx, node.FText, node.FPosition);
            }
        }

        private void DrawString(Graphics gfx, string text, PointF position)
        {
            gfx.DrawString(text, Config.TextFont, Config.TextBrush, position);
        }

        private void DrawPath(Graphics gfx)
        {
            PointF start = path[0];

            for (int i = 1; i < path.Length; i++)
            {
                PointF end = path[i];
                gfx.DrawLine(Config.RoutePen, start, end);
                start = end;
            }

            gfx.DrawLine(Config.RoutePen, start, startRect.Value.Location + hafNode);
        }
    }
}