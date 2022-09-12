using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5, _rotationSpeed = 300;

    [SerializeField] private Counter _counter;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float yRotation = Input.GetAxis("Mouse X");
        float y = yRotation * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, y, 0);

        float moveLeft = Input.GetAxis("Horizontal");
        float moveForward = Input.GetAxis("Vertical");

        Vector3 offset = new Vector3(moveLeft, 0, moveForward) * _speed * Time.deltaTime;
        transform.Translate(offset);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 3;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed /= 3;
        }
    }

    public void UpCoins()
    {
        _counter.UpCountCoins();
    }

    public void EndGame()
    {
        _speed = 0;
        _rotationSpeed = 0;
    }
}
