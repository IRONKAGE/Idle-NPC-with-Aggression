using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    [Header ("Stats")]
    public float speed;
    public float nearDistance;

    [Header ("References")]
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("agressionNPC").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < nearDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, player.position) >= nearDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void OnBecameVisible()
    {
        return;
    }
}
