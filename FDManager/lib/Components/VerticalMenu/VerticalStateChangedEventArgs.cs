namespace Components.VerticalMenu
{
    public sealed class VerticalStateChangedEventArgs : EventArgs
    {
        public VerticalStateChangedEventArgs(VerticalMenuState currentState)
        {
            CurrentState = currentState;
        }

        public VerticalMenuState CurrentState { get; }
    }
}
