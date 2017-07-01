namespace DeJong.VisualAStar
{
    using System;
    using System.Collections.Generic;
    using Utilities.Core.Collections;

    public static class AStar
    {
        public const int MOVE = 10;

        public static AStarState State { get; private set; } = AStarState.Done;
        public static List<Node> OpenList { get; private set; }
        public static List<Node> ClosedList { get; private set; }
        public static Node Current { get; private set; }
        public static bool Failed { get; private set; }
        public static List<Node> Result { get; private set; }

        private static Map map;
        private static Node[] ajason;
        private static int ajasonIndex;

        public static void Initialize(Map map)
        {
            if (State != AStarState.Done) throw new InvalidOperationException($"Cannot call initialize when state is {State}");
            AStar.map = map;
            OpenList = new List<Node>();
            ClosedList = new List<Node>();
            State = AStarState.SettingCurrentNode;
        }

        public static void Reset()
        {
            State = AStarState.Done;
            Current = null;
            Failed = false;
            Result = null;
            OpenList = null;
            ClosedList = null;
            map = null;
            ajason = null;
            ajasonIndex = 0;
        }

        public static bool Tick()
        {
            switch (State)
            {
                case AStarState.SettingCurrentNode:
                    Tick_SettingCurrentNode();
                    State++;
                    break;
                case AStarState.RemovingFromOpenList:
                    Tick_RemoveFromOpenList();
                    State++;
                    break;
                case AStarState.AddingToClosedList:
                    Tick_AddingToClosedList();
                    State++;
                    break;
                case AStarState.GettingAsjasonNodes:
                    Tick_GetAdjasonNodes();
                    ajasonIndex = 0;
                    State++;
                    break;
                case AStarState.CheckIfEndReached:
                    bool found = Tick_CheckForEndPoint();
                    State = found ? AStarState.EndFound : (ajason.Length > 0 ? AStarState.SetFirstParent : AStarState.CheckingForFailure);
                    break;
                case AStarState.SetFirstParent:
                    bool set = Tick_SetFirstParent();
                    State = set ? AStarState.AddingToOpenList : AStarState.CheckNewParent;
                    break;
                case AStarState.CheckNewParent:
                    Tick_CheckNewParent();
                    State++;
                    break;
                case AStarState.AddingToOpenList:
                    Tick_AddingToOpenList();
                    State = ajasonIndex < ajason.Length ? AStarState.SetFirstParent : AStarState.CheckingForFailure;
                    break;
                case AStarState.CheckingForFailure:
                    Tick_CheckForFailure();
                    State = Failed ? AStarState.Done : AStarState.SettingCurrentNode;
                    break;
                case AStarState.EndFound:
                    Tick_EndFound();
                    State++;
                    break;
                case AStarState.Recalling:
                    Tick_Recalling();
                    State++;
                    break;
                case AStarState.Done:
                    return true;
            }

            return false;
        }

        private static void Tick_SettingCurrentNode()
        {
            if (Current == null) Current = map.Start;
            else
            {
                Node min = OpenList[0];

                for (int i = 1; i < OpenList.Count; i++)
                {
                    Node cur = OpenList[i];
                    if (cur.FValue < min.FValue) min = cur;
                }

                Current = min;
            }
        }

        private static void Tick_RemoveFromOpenList()
        {
            if (OpenList.Contains(Current)) OpenList.Remove(Current);
        }

        private static void Tick_AddingToClosedList()
        {
            ClosedList.Add(Current);
        }

        private static void Tick_GetAdjasonNodes()
        {
            ajason = new Node[4];
            int i = 0;

            if (Current.Postition.X - 1 >= map.Dim.X)
            {
                Vector2 pos = Current.Postition - Vector2.UnitX;
                if (!ShouldIgnore(pos)) ajason[i++] = map[pos];
            }
            if (Current.Postition.Y - 1 >= map.Dim.Y)
            {
                Vector2 pos = Current.Postition - Vector2.UnitY;
                if (!ShouldIgnore(pos)) ajason[i++] = map[pos];
            }
            if (Current.Postition.X + 1 < map.Dim.Width)
            {
                Vector2 pos = Current.Postition + Vector2.UnitX;
                if (!ShouldIgnore(pos)) ajason[i++] = map[pos];
            }
            if (Current.Postition.Y + 1 < map.Dim.Height)
            {
                Vector2 pos = Current.Postition + Vector2.UnitY;
                if (!ShouldIgnore(pos)) ajason[i++] = map[pos];
            }

            if (i < 4) Array.Resize(ref ajason, i);
        }

        private static bool ShouldIgnore(Vector2 position)
        {
            Node node = map[position];
            return node.IsImpassable || ClosedList.Contains(node);
        }

        private static bool Tick_CheckForEndPoint()
        {
            return ajason.Contains(n => n.Postition == map.EndPos);
        }

        private static bool Tick_SetFirstParent()
        {
            Node cur = ajason[ajasonIndex];
            if (cur.Parent == null && cur.Postition != map.StartPos)
            {
                cur.SetParent(Current, MOVE);
                return true;
            }

            return false;
        }

        private static void Tick_CheckNewParent()
        {
            Node cur = ajason[ajasonIndex];
            if (cur.Postition == map.StartPos) return;
            if (Current.GValue + MOVE < cur.GValue) cur.SetParent(Current, MOVE);
        }

        private static void Tick_AddingToOpenList()
        {
            Node cur = ajason[ajasonIndex++];
            if (!OpenList.Contains(cur)) OpenList.Add(cur);
        }

        private static void Tick_CheckForFailure()
        {
            Failed = OpenList.Count == 0;
        }

        private static void Tick_EndFound()
        {
            map.End.SetParent(Current, MOVE);
        }

        private static void Tick_Recalling()
        {
            Result = new List<Node>();
            Node cur = map.End;

            while (cur.Parent != null)
            {
                Result.Add(cur);
                cur = cur.Parent;
            }
        }
    }
}