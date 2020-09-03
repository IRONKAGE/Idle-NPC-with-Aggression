using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour
{
    public float timeLeft;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            Destroy(gameObject);
        }
    }
}
