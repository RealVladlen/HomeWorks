using UnityEngine;

public class BombCollector : MonoBehaviour
{
    [SerializeField] private UIController _controller;
    [SerializeField] private GameObject _explosionEffects;
    [SerializeField] private AudioSource _explosion;


    private void OnTriggerEnter(Collider other)
    {
        Bomb coin = other.GetComponent<Bomb>();
        if (coin)
        {
            _controller.TakingLife();

            Instantiate(_explosionEffects, other.transform.position,Quaternion.identity);
            _explosion.Play();

            Destroy(other.gameObject);
        }
    }
}
