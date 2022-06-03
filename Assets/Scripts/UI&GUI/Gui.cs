using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gui : MonoBehaviour
{
    #region items

    public int spray;
    public int batarya;
    public int Metal_parca;
    public int zemin;
    public int duvar;
    public Text sprayUI;
    public Text bataryaUI;
    public Text Metal_parcaUI;
    public Text zeminUI;
    public Text duvarUI;
    #endregion

    #region Degerler
    public float health;
    public float stamina;
    public float maxStamina;
    public float experience;
    public GameObject StmaBar;
    public GameObject CanBar;
    public GameObject KirBar;
    #endregion
    public bool envanter;
    public GameObject Inventory;
    public MouseLook look;
    public Movement move;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            envanter = !envanter;
            if (envanter)
            {
                Inventory.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                look=Camera.main.GetComponent<MouseLook>();
                look.enabled = false;
            }
            else
            {
                Inventory.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                look.enabled = true;
            }
        }


        sprayUI.text = "Spray= " + spray.ToString();
        bataryaUI.text = "Batarya= " + batarya.ToString();
        Metal_parcaUI.text = "Metal Parca= " + Metal_parca.ToString();
        zeminUI.text = "Zemin= " + zemin.ToString();
        duvarUI.text = "Duvar= " + duvar.ToString();

        #region Health


        if (health>100)
        {
            health = 100;

        }


        #endregion
        #region Stamina
        if (stamina > 0)
        {
            StmaBar.transform.localScale = new Vector3(stamina / 100, 1, 1);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= 1 * Time.deltaTime;
        }
        if (stamina <= 0)
        {
            stamina = 0;
        }

        #endregion
        #region Barlar
        CanBar.transform.localScale = new Vector3(health / 100, 1, 1);
        StmaBar.transform.localScale = new Vector3(stamina / 100, 1, 1);
        KirBar.transform.localScale = new Vector3(experience / 100, 1, 1);
        maxStamina -= 1 * Time.deltaTime;
        stamina -= 0.1f * Time.deltaTime;
        #endregion


    }
}
