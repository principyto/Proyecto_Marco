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
    public float fireRate = 30f;
    public float nextTimeToFire = 0f;
    public float damage = 0;
    //public int bulletsPerShot = 5;

    [SerializeField] Camera cam;
    private Transform _selection;

    RaycastHit hit;

    private void Awake()
    {

    }

    void Update()
    {

        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }


        if(pistol)
        {
            if(Input.GetMouseButtonDown(0))
            {
                LayerMask mask = LayerMask.GetMask("Enemigos_Player");

                soundManagerScript.PlaySound("GunShot");
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, mask))
                {
                    RaycastSegment();
                    //var selection = hit.transform;S
                    //Hitboxes hitBox = hit.transform.GetComponent<Hitboxes>();
                    //hitBox.OnRaycastHit(this);
                    Debug.Log(hit.collider.name);
                    //if (selection.CompareTag(selectableTag2))
                    //{
                    //    var selectionRender = selection.GetComponent<Renderer>();
                    //    if (selectionRender != null)
                    //    {
                    //        enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                    //        Health.TakeDamage(damage);
                    //        selectionRender.material = enemy2Material;
                    //    }
                    //    _selection = selection;
                    //}
                    //if (selection.CompareTag(selectableTag3))
                    //{
                    //    var selectionRender = selection.GetComponent<Renderer>();
                    //    if (selectionRender != null)
                    //    {
                    //        enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
                    //        Health.TakeDamage(damage);
                    //        selectionRender.material = enemy3Material;
                    //    }
                    //    _selection = selection;
                    //}

                }
            }
        }
        if (machinegun)
        {
            //aca poner loop de audio source
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
                            Health.TakeDamage(damage);
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
                            Health.TakeDamage(damage);
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
                            Health.TakeDamage(damage);
                            selectionRender.material = enemy3Material;
                        }
                        _selection = selection;
                    }
                }
            }
        }
       
    }

    void RaycastSegment()
    {
        var hitbox = hit.collider.GetComponent<Hitboxes>();
        if(hitbox)
        {
            hitbox.OnRaycastHit(this);
        }
    }
}
