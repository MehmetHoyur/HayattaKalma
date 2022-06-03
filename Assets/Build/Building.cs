using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int id1,id2,id3;
    public int istenen1,istenen2,istenen3;
    public int verilen1,verilen2,verilen3;
    public bool sart1,sart2,sart3;
    public GameObject build;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (id1!=0)
        {
            if (verilen1>=istenen1)
            {
                sart1 = true;
            }
            
        }else
            {
                sart1 = true;
            }
        if (id2 != 0)
        {
            if (verilen2 >= istenen2)
            {
                sart2 = true;
            }

        }
        else
        {
            sart2 = true;
        }
        if (id3 != 0)
        {
            if (verilen3 >= istenen3)
            {
                sart3 = true;
            }

        }
        else
        {
            sart3 = true;
        }
        if (sart1&&sart2&&sart3)
        {
            Instantiate(build, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }

    }
}
