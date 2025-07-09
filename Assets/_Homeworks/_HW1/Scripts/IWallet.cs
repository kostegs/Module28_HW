using System;

namespace Homework_28.Homework1
{
    public interface IWallet
    {
        event Action<Currencies, int> ValueChanged;
    }
}

