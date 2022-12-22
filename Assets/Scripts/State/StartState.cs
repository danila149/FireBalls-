using TMPro;
using UnityEngine;

public class StartState : AState
{
    private MeshRenderer _meshRendererP;
    private SpawnPancake spawnPancake = new SpawnPancake();
    private Transform _spawnerDef;
    private SpawnDefence spawnDefence = new SpawnDefence();
    private Transform _tower;
    private TMP_Text _coinsText;
    private TMP_Text _levelsText;
    private MenuView _menuView;
    private int _number = 0;
    private int _level = 0;
    public StartState(StateMachine owner, MeshRenderer meshRendererP, Transform tower, TMP_Text pointText, TMP_Text levelsText , Transform spawnerDef, MenuView menuView) : base(owner)
    {
        _meshRendererP = meshRendererP;
        _tower = tower;
        _coinsText = pointText;
        _spawnerDef = spawnerDef;
        _menuView = menuView;
        _levelsText = levelsText;

    }
    public override void Enter()
    {
        NumberLevel();
        _meshRendererP.material.color = Color.red;
        spawnPancake.Spawn(_tower ,  () => ChangePointText(), () => _owner.ChangeState(typeof(StartState)));
        spawnDefence.Spawn(_spawnerDef);
        _menuView.StartGameButton.onClick.RemoveAllListeners();
        _menuView.StartGameButton.onClick.AddListener(() => _owner.ChangeState(typeof(GameState)));
        _menuView.gameObject.SetActive(true);
    }
    public override void Update()
    {

    }
    public override void Exit()
    {
        _meshRendererP.material.color = Color.green;
        _menuView.gameObject.SetActive(false);
    }

    private void ChangePointText()
    {
        _number++;
        _coinsText.text = "Score:" + _number.ToString();
    }
    private void NumberLevel()
    {
        _level++;
        _levelsText.text = "Level:" + _level.ToString();
    }
}
