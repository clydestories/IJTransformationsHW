using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
