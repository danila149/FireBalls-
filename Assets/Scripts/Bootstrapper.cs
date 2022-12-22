using System.Collections;
using TMPro;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private MeshRenderer _rendererPlayer;
    private StateMachine _stateMachine;
    [SerializeField] private Transform _tower;
    [SerializeField] private Transform _Defense;
    [SerializeField] private PlayerView _playerView;

    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _levelText;
    [SerializeField] private TMP_Text _scoreText;

    [SerializeField] private MenuView _menuView;
    [SerializeField] private DamePanelView _damePanelView;
    [SerializeField] protected LosePanelView _losePanelView;
    void Start()
    {
        
        _stateMachine = new StateMachine();
        _stateMachine.SetStateInitializer(new GameStateInitializer(
            _stateMachine,
            _rendererPlayer,
            _tower,
            _playerView,
            _coinsText,
            _Defense,
            _menuView,
            _damePanelView,
            _losePanelView,
            _levelText,
            _scoreText));
        _stateMachine.ChangeState(typeof(StartState));
    }
    void Update()
    {
        _stateMachine.UseStateUpdate();

    }
}
