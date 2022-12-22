public abstract class AState
{
    protected StateMachine _owner;

    protected AState(StateMachine owner)
    {
        _owner = owner;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
