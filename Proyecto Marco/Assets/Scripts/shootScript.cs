using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    [SerializeField] private string selectableTag1 = "Enemy1";
    [SerializeField] private string selectableTag2 = "Enemy2";
    [SerializeField] private string selectableTag3 = "Enemy3";
    [SerializeField] private Material enemy1Material;
    [SerializeField] private Material enemy2Material;
    [SerializeField] private Material enemy3Material;
    [SerializeField] private Material defaultMaterial;


    [SerializeField] public bool pistol = false;
    [SerializeField] public bool machinegun = false;
    //[SerializeField] private bool shotgun = true;

    //public float spread = 2f;
    float fireRate = 30f;
    float nextTimeToFire = 0f;
    //public int bulletsPerShot = 5;

    [SerializeField] Camera cam;
    private Transform _selection;

    void Update()
    {
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        RaycastHit hit;

        if(pistol)
        {
            if(Input.GetMouseButtonDown(0))
            {
                soundManagerScript.PlaySound("Gunshot");
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
                {
                    var selection = hit.transform;
                    if(selection.CompareTag(selectableTag1))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy1Material;
                        }
                        _selection = selection;
                    }
                    if (selection.CompareTag(selectableTag2))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy2Material;
                        }
                        _selection = selection;
                    }
                    if (selection.CompareTag(selectableTag3))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy3Material;
                        }
                        _selection = selection;
                    }
                    Debug.Log(hit);

                }
            }
        }
        if (machinegun)
        {
            if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 3f / fireRate;
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
                {
                    var selection = hit.transform;
                    if (selection.CompareTag(selectableTag1))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy1Material;
                        }
                        _selection = selection;
                    }
                    if (selection.CompareTag(selectableTag2))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy2Material;
                        }
                        _selection = selection;
                    }
                    if (selection.CompareTag(selectableTag3))
                    {
                        var selectionRender = selection.GetComponent<Renderer>();
                        if (selectionRender != null)
                        {
                            enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                            Health.TakeDamage();
                            selectionRender.material = enemy3Material;
                        }
                        _selection = selection;
                    }
                }
            }
        }
        //if (shotgun)
        //{
        //    float x = Random.Range(-spread, spread);
        //    float y = Random.Range(-spread, spread);
        //    Vector3 direction = cam.transform.forward + new Vector3(x, y, 0);
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        for(int i = 0; i < bulletsPerShot; i++)
        //        {
        //            if (Physics.Raycast(cam.transform.position, direction, out hit))
        //            {
        //                Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.green);

        //                var selection = hit.transform;
        //                if (selection.CompareTag(selectableTag1))
        //                {
        //                    var selectionRender = selection.GetComponent<Renderer>();
        //                    if (selectionRender != null)
        //                    {
        //                        enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
        //                        Health.TakeDamage();
        //                        selectionRender.material = enemy1Material;
        //                    }
        //                    _selection = selection;
        //                }
        //                if (selection.CompareTag(selectableTag2))
        //                {
        //                    var selectionRender = selection.GetComponent<Renderer>();
        //                    if (selectionRender != null)
        //                    {
        //                        enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
        //                        Health.TakeDamage();
        //                        selectionRender.material = enemy2Material;
        //                    }
        //                    _selection = selection;
        //                }
        //                if (selection.CompareTag(selectableTag3))
        //                {
        //                    var selectionRender = selection.GetComponent<Renderer>();
        //                    if (selectionRender != null)
        //                    {
        //                        enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
        //                        Health.TakeDamage();
        //                        selectionRender.material = enemy3Material;
        //                    }
        //                    _selection = selection;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
