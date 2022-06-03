using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator Kontrol;
    // Start is called before the first frame update
    private void Start()
    {
        Kontrol = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            Kontrol.SetBool("Yuru",true);
            Kontrol.SetBool("Dur",false);
        }
        else
        {
            Kontrol.SetBool("Dur", true);
            Kontrol.SetBool("Yuru",false );
        }
        
        
    }
}
