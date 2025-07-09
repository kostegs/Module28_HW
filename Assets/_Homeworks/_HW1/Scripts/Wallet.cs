using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_28.Homework1
{
    public class Wallet : MonoBehaviour, IWallet
    {
        public event Action<Currencies, int> ValueChanged;

        private Dictionary<Currencies, int> _values;       

        public void Initialize()
        {
            _values = new Dictionary<Currencies, int>();
            
            foreach (Currencies currency in Enum.GetValues(typeof(Currencies)))            
                _values.Add(currency, 0);            
        }

        public void AddValue(Currencies currency, int value)
        {
            _values[currency] += value;
            ValueChanged?.Invoke(currency, value);
        }
    }
}

