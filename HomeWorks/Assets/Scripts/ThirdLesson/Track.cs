using UnityEngine;

public class Track : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _offset;


    void FixedUpdate()
    {
        Vector3 newCamPos = _target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, newCamPos, 0.5f);
    }
}
