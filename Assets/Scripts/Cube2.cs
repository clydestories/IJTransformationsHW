using UnityEngine;

public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _growSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
        Rotate();
        Grow();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    private void Grow()
    {
        Vector3 growAmount = new Vector3(_growSpeed * Time.deltaTime, _growSpeed * Time.deltaTime, _growSpeed * Time.deltaTime);

        transform.localScale += growAmount;
    }
}
