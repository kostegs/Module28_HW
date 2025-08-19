using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerPanelButtons : MonoBehaviour
{
    public event Action<TimerState> TimerButtonPressed;

    [SerializeField] private Button _playButton;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _restartButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _pauseButton.onClick.AddListener(OnPauseButtonClick);
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnRestartButtonClick()
        => TimerButtonPressed?.Invoke(TimerState.Restart);    

    private void OnPauseButtonClick()
        => TimerButtonPressed?.Invoke(TimerState.Pause);
    
    private void OnPlayButtonClick()
        => TimerButtonPressed?.Invoke(TimerState.Play);
    
}
