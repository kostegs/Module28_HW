using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_28.Homework1
{
    public class Homework1 : MonoBehaviour
    {
        private const KeyCode AddMoneyButton = KeyCode.M;
        private const KeyCode AddEnergyButton = KeyCode.E;
        private const KeyCode AddDiamondButton = KeyCode.D;

        [SerializeField] private Wallet _wallet;
        [SerializeField] private int _moneyValue;
        [SerializeField] private int _energyValue;
        [SerializeField] private int _diamondValue;

        private KeyCode[] _trackKeys;        

        public void Initialize() 
        {
            _trackKeys = new KeyCode[] { AddMoneyButton, AddEnergyButton, AddDiamondButton };
        }

        private void Update()
        {
            if (Input.anyKeyDown)
                foreach (KeyCode keyCode in _trackKeys)
                    if (Input.GetKeyDown(keyCode))
                        switch (keyCode)
                        {
                            case AddMoneyButton:
                                _wallet.AddValue(Currencies.Money, _moneyValue);
                                break;
                            case AddEnergyButton:
                                _wallet.AddValue(Currencies.Energy, _energyValue);
                                break;
                            case AddDiamondButton:
                                _wallet.AddValue(Currencies.Diamond, _diamondValue);
                                break;
                            default:
                                break;                                
                        }
        }
    }
}