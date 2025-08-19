using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] TimerPanelButtons _timerPanel;

    private Timer _timer;

    private void Awake()
    {
        _timerPanel.TimerButtonPressed += OnTimerButtonPressed;

        _timer = new Timer();
        _timer.Initialize(this);
        _timer.SecondPassed += OnTimerSecondPassed;
        _timer.Start();
    }

    private void OnTimerSecondPassed()
    {
        Debug.Log("Second passed");
    }

    private void OnDestroy() => _timerPanel.TimerButtonPressed -= OnTimerButtonPressed;

    private void OnTimerButtonPressed(TimerState button)
    {
        switch (button)
        {
            case TimerState.Play:
                _timer.Start();
                break;
            case TimerState.Pause:
                _timer.Pause();
                break;
            case TimerState.Restart:
                _timer.Stop();
                break;
            default:
                break;
        }
    }
}
