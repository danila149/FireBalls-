using UnityEngine;

public class GameState : AState
{
    private PlayerView _playerView;
    private SpawnerPulka _spawnerPulka = new SpawnerPulka();
    private DamePanelView _gamePanelView;
    public GameState(StateMachine owner, PlayerView playerView, DamePanelView gamePanelView) : base(owner)
    {
        _playerView = playerView;
        _gamePanelView = gamePanelView;
    }

    public override void Enter()
    {
        _gamePanelView.gameObject.SetActive(true);

    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _owner.ChangeState(typeof(StartState));

        }
        if (Input.GetMouseButtonDown(0))
        {
            _spawnerPulka.Spawn(_playerView);
        }
    }
    public override void Exit()
    {
        _gamePanelView.gameObject.SetActive(false);
    }
}
