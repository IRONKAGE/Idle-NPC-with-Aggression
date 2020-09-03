using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    [Header ("Parameters")]
    public float speed;
    public float time;
    public int newAim;
    public NavMeshAgent nav;
    public Vector3 pos;
    public Vector3 aim;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time >= newAim)
        {
            NewAim();
            time = 0;
        }
    }

    void NewAim()
    {
        Vector3 pos = gameObject.transform.position;

        aim = new Vector3(pos.x + Random.Range(-speed, speed), pos.y , pos.z + Random.Range( -speed, speed));

        nav.SetDestination(aim);
        newAim = Random.Range(1, 5);
    }
}
