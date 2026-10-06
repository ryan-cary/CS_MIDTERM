using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float _amplitude = 1f;
    [SerializeField] private float _frequency = 2f;
    [SerializeField] private float _offset = 0f;

    private Vector3 _startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + Vector3.up * Mathf.Sin(Time.time * _frequency) * _amplitude + Vector3.up * _offset;
    }
}
