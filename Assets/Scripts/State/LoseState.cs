using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseState : AState
{
    private LosePanelView _losePanelView;
    public LoseState(StateMachine owner, LosePanelView losePanelView) : base(owner)
    {
        _losePanelView = losePanelView;
    }

    public override void Enter()
    {
        _losePanelView.gameObject.SetActive(true);
        ChekWalker.onPulkaChek -= _owner.ChangeState;
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _owner.ChangeState(typeof(StartState));
        }
        _losePanelView.StartGameButton.onClick.AddListener(() => _owner.ChangeState(typeof(GameState)));
        

    }
    public override void Exit()
    {
        _losePanelView.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
}