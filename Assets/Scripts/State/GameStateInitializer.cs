using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStateInitializer
{

    private StateMachine _owner;
    private MeshRenderer _meshRendererP;
    private Transform _tower;
    private Transform _spawnerDef;
    private PlayerView _playerView;
    private TMP_Text _coinsText;
    private TMP_Text _levelText;
    private TMP_Text _scoreText;
    private MenuView _menuView;
    private DamePanelView _damePanelView;
    private LosePanelView _losePanelView;

    public GameStateInitializer(StateMachine owner, MeshRenderer meshRendererP, Transform tower, PlayerView playerView, TMP_Text coinsText, Transform spawnerDef, MenuView menuView, DamePanelView damePanelView, LosePanelView losePanelView, TMP_Text levelText, TMP_Text scoreText)
    {
        _owner = owner;
        _meshRendererP = meshRendererP;
        _tower = tower; 
        _playerView = playerView;
        _coinsText = coinsText;
        _spawnerDef = spawnerDef;
        _menuView = menuView;
        _damePanelView = damePanelView;
        _losePanelView = losePanelView;
        _levelText = levelText;
        _scoreText = scoreText;
    }

    public Dictionary<Type, AState> Initialize()
    {
        return new Dictionary<Type, AState>()
        {
            [typeof(StartState)] = new StartState(_owner, _meshRendererP, _tower, _coinsText, _levelText, _spawnerDef, _menuView ),
            [typeof(GameState)] = new GameState(_owner, _playerView, _damePanelView),
            [typeof(LoseState)] = new LoseState(_owner, _losePanelView),
            [typeof(WinState)] = new WinState(_owner)
        };
    }
}



