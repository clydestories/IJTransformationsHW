using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }
}