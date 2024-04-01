using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        Vector3 growAmount = new Vector3(_growSpeed * Time.deltaTime, _growSpeed * Time.deltaTime, _growSpeed * Time.deltaTime);

        transform.localScale += growAmount;
    }
}
