namespace Components.VerticalMenu
{
    public class VerticalStateChangedEventArgs : EventArgs
    {
        public VerticalStateChangedEventArgs(VerticalMenuState currentState)
        {
            CurrentState = currentState;
        }

        public VerticalMenuState CurrentState { get; }
    }
}
