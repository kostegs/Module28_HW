using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public event Action SecondPassed;

    private const int Delay = 1;

    private Coroutine _timerCoroutine;
    private MonoBehaviour _objectForCoroutine;
    private WaitForSeconds _delay;

    public void Initialize(MonoBehaviour objectForCoroutine)
    {
        _delay = new WaitForSeconds(Delay);
        _objectForCoroutine = objectForCoroutine;        
    }

    public void Start() => _timerCoroutine = _objectForCoroutine.StartCoroutine(ProcessTimer());
    
    public void Stop() => _objectForCoroutine.StopCoroutine(_timerCoroutine);

    public void Pause() => Stop();

    private IEnumerator ProcessTimer()
    {
        while (true)
        {
            yield return _delay;
            SecondPassed?.Invoke();
        }        
    }

}

