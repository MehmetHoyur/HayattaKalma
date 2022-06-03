using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looting : MonoBehaviour
{
    Envanter inv;
    RaycastHit hit;
    ObjeBelirle ob;
    void Start()
    {
        inv=GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit,25))
        {
            if (hit.transform.gameObject.tag=="Object")
            {
                ob= hit.transform.gameObject.GetComponent<ObjeBelirle>();  
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Debug.Log("Buradyýmmmm");
                    inv.itemEkle(ob.item.itemid,ob.item.itemadet);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
