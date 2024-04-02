using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
