using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class weaponSwitch : MonoBehaviour
{
    public int selectedWeapon = 0;
    public GameObject pistola;
    public GameObject m4;
    GameObject change;


    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }
    private void Awake()
    {
        change = GameObject.Find("ShootManager");

    }
    // Update is called once per frame
    void Update()
    {

        SelectWeapon();

    }

    public void SwitchButton()
    {
        selectedWeapon++;
        if(selectedWeapon > 1)
        {
            selectedWeapon = 0;
        }
        
        Debug.Log("cambio");
    }

    void SelectWeapon()
    {

        if (selectedWeapon == 0)
        {
            pistola.SetActive(true);
            m4.SetActive(false);
            change.GetComponent<shootScript>().pistol = true;
            change.GetComponent<shootScript>().machinegun = false;

        }
        else if (selectedWeapon == 1)
        {
            pistola.SetActive(false);
            m4.SetActive(true);
            change.GetComponent<shootScript>().pistol = false;
            change.GetComponent<shootScript>().machinegun = true;
        }
    }
}
