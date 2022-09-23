using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rb;

    private void Start()
    {
        _speed = 3;
        _rotateSpeed = 1;

        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float rotate = Input.GetAxis("Vertical");
        float move = Input.GetAxis("Horizontal");

        _rb.AddRelativeForce(0, 0, move * _speed);
        _rb.AddRelativeTorque(rotate * _rotateSpeed, 0, 0);
    }

    public void ZeroSpeed()
    {
        _speed = 0;
        _rotateSpeed = 0;
    }
}
