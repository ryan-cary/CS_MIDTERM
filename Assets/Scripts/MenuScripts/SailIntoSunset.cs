using UnityEngine;

public class SailIntoSunset : MonoBehaviour
{
    [SerializeField] private float speed = 25f;
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
