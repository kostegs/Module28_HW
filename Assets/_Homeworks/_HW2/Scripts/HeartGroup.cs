using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGroup : MonoBehaviour
{
    [SerializeField] private GameObject _heartSprite;

    private void Awake()
    {
        for (int i = 1; i < 10; i++)
            Instantiate(_heartSprite, transform.position, Quaternion.identity, transform);
    }
}