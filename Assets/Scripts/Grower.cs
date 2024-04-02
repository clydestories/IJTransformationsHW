using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        Grow();
    }

    public void Grow()
    {
        Vector3 growAmount = _growSpeed * Time.deltaTime * Vector3.one;

        transform.localScale += growAmount;
    }
}
