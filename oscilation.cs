using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscilation : MonoBehaviour
{
    Vector3 pos_0;
    [SerializeField] Vector3 move;
    [SerializeField] [Range(0,1)] float Mov_speed;
    [SerializeField] float period;

    void Start()
    {
        pos_0 = transform.position;
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period;

        const float twopi = Mathf.PI * 2;
        float rawSin = Mathf.Sin(cycles * twopi);

        Mov_speed = (rawSin + 1f) / 2f;

        Vector3 new_pos = move * Mov_speed;
        transform.position = pos_0 + new_pos;
    }
}
