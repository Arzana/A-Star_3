namespace DeJong.VisualAStar
{
    public enum AStarState
    {
        SettingCurrentNode,
        RemovingFromOpenList,
        AddingToClosedList,
        GettingAsjasonNodes,
        CheckIfEndReached,
        SetFirstParent,
        CheckNewParent,
        AddingToOpenList,
        CheckingForFailure,
        EndFound,
        Recalling,
        Done
    }
}