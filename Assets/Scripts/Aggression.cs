using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggression : MonoBehaviour
{
    [Header ("Stats")]
    public float speed;
    public float nearDistance;
    public float stopingDistance;
    public float startTimeBeetwenShots;
    public float timeBetweenShots;

    [Header ("References")]
    public GameObject shot;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("idleNPC").transform;       
    }

    void Update()
    {
        // Makes the Aggression NPC to MOVE
        if(Vector2.Distance(transform.position, player.position) < nearDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, player.position) > stopingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, player.position) < stopingDistance && Vector2.Distance(transform.position, player.position) > nearDistance)
        {
            transform.position = this.transform.position;
        }

        // Makes the Aggression NPC to SHOOT
        if(timeBetweenShots <= 0)
        {
            Instantiate(shot, transform.position, Quaternion.identity);
            timeBetweenShots = startTimeBeetwenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }
}