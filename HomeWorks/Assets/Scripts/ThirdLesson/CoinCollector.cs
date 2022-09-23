using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private UIController _controller;
    [SerializeField] private AudioSource _pick;

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();
        if (coin)
        {
            _controller.UpCoins();
            _pick.Play();
            Destroy(other.gameObject);
        }
    }
}
