using UnityEngine;

namespace Homework_28.Homework1
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Wallet _wallet;
        [SerializeField] private Homework1 _homework1;
        [SerializeField] private WalletView _walletView;

        private void Awake()
        {
            _wallet.Initialize();
            _homework1.Initialize();
            _walletView.Initialize(_wallet);
        }
    }
}

