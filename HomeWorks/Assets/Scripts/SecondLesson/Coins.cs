using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private float _speed = 90;

    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
    }
    private void Update()
    {
        _transform.Rotate(new Vector3(Time.deltaTime * _speed, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().UpCoins();
            Destroy(gameObject);
        }
    }
}
