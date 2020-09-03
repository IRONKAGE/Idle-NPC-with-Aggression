using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP;

    public void TakeDamage()
    {
        if(HP<1)
        {
            Destroy(gameObject);
        }
        else
        {
            HP--;
        }
    }
}
