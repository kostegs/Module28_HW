using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_28.Homework1
{
    public class WalletView : MonoBehaviour
    {
        public Action<Currencies, int> ValueChanged;

        [SerializeField] private List<WalletViewCurrency> _currencies;

        private IWallet _wallet;

        public void Initialize(IWallet wallet)
        {
            TurnOnView();
            _wallet = wallet;
            _wallet.ValueChanged += OnValueChanged;
        }

        private void OnDestroy()
            => _wallet.ValueChanged -= OnValueChanged;

        private void OnValueChanged(Currencies currency, int value) 
            => ValueChanged?.Invoke(currency, value);

        public void TurnOnView()
        {
            foreach (WalletViewCurrency currency in _currencies)
            {
                currency.gameObject.SetActive(true);
                currency.Initialize(this);
            }                
        }        
    }
}

