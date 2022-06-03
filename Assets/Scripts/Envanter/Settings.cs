using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject envanterPanel, bilgiPanel;
    public bool envanter, bilgi;
    void Start()
    {
        envanter = false;
    }

   [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            envanter = !envanter;
            bilgi = !bilgi;
        }
        if (envanter)
        {
            envanterPanel.SetActive(true);
            Screen.lockCursor = false;
        }
        else
        {
            envanterPanel.SetActive(false);
            Screen.lockCursor = true;
        }
        if (bilgi)
        {
            bilgiPanel.SetActive(true);
        }
        else
        {
            bilgiPanel.SetActive(false);
        }
    }
}
