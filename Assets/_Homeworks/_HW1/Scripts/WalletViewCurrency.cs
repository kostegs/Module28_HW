using TMPro;
using UnityEngine;

namespace Homework_28.Homework1
{
    public class WalletViewCurrency : MonoBehaviour
    {
        [SerializeField] private Currencies _currency;
        [SerializeField] private TMP_Text _valueText;

        private int _value;
        private WalletView _walletView;

        public void Initialize(WalletView walletView)
        {
            _walletView = walletView;
            _walletView.ValueChanged += OnValueChanged;
        }

        private void OnDestroy()
            => _walletView.ValueChanged -= OnValueChanged;

        private void OnValueChanged(Currencies currency, int value)
        {
            if (currency == _currency)
            {
                _value += value;
                _valueText.text = _value.ToString();                
            }                
        }
    }
}

