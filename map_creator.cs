using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class map_creator : MonoBehaviour
{
    private int a;
    public GameObject Prefab;
    private Vector3 pos;

    public void creator(float x, float z, int a)
    {
        pos.x = x;
        pos.z = z;

        for (int i = -a/2; i <= a/2; i++)
        {
            pos.x = x + 0.75f * i;
            pos.z = z - 0.433f * (a - 1 - abs(i));
            for (int j = 0; j < a - abs(i); j++)
            {
                Instantiate(Prefab, pos, transform.rotation);
                pos.z += 0.433f * 2;
            }
        }

    }



    public int abs(int s)
    {
        if (s < 0)
            s = -s;
        return s;
    }

}
