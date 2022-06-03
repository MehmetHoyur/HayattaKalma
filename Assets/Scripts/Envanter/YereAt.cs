using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class YereAt : MonoBehaviour,IPointerDownHandler
{
    public GameObject myObject,ObjectSP;
    Envanter inv;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button.ToString()=="Left"&&inv.tasi)
        {
            yereAt(inv.tasinanItem);
        }
    }
    public void yereAt(Item item)
    {
        GameObject obje=Instantiate(myObject,ObjectSP.transform.position,Quaternion.identity) as GameObject;
    obje.GetComponent<ObjeBelirle>().item = item;
    }
    // Start is called before the first frame update
    void Start()
    {
        inv=GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
        ObjectSP = GameObject.FindGameObjectWithTag("DropItem");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
