using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    float fTimeIntervals;

    [SerializeField]
    Vector3 v3SpawnPosJitter;

    float fTimer = 0;
    void Start()
    {
        fTimer = fTimeIntervals;
    }

    void FixedUpdate()
    {
        fTimer -= Time.deltaTime;
        print(fTimer);
        if (fTimer <= 0)
        {
            if (Input.GetKey(keyPositive))
            {
                GetComponent<Rigidbody>().velocity += v3Force * 2;
                fTimer = 10;
            }
            if (Input.GetKey(keyNegative))
            {
                GetComponent<Rigidbody>().velocity -= v3Force * 2;
                fTimer = 10;
            }
        }

    }
}
