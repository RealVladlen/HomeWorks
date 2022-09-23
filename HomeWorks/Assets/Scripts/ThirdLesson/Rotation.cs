using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float X, Y, Z;

    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
    }
    private void Update()
    {
        _transform.Rotate(new Vector3(Time.deltaTime * X, Time.deltaTime * Y, Time.deltaTime * Z));
    }
}
