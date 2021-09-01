//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class gunsScript : MonoBehaviour
//{
//    [SerializeField] private string selectableTag1 = "Enemy1";
//    [SerializeField] private Material enemy1Material;
//    [SerializeField] private Material defaultMaterial;

//    public float damage = 10f;

//    public Camera fpsCamera;

//    private Transform _selection;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (_selection != null)
//        {
//            var selectionRenderer = _selection.GetComponent<Renderer>();
//            selectionRenderer.material = defaultMaterial;
//            _selection = null;
//        }

//        if (Input.GetMouseButtonDown(0))
//        {
//            Shoot();
//        }
           
//    }

//    void Shoot()
//    {
//        RaycastHit hit;
//        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit))
//        {
//            var selection = hit.transform;
//            if (selection.CompareTag(selectableTag1))
//            {
//                var selectionRender = selection.GetComponent<Renderer>();
//                if (selectionRender != null)
//                {
//                    enemyHealth Health = hit.transform.GetComponent<enemyHealth>();
//                    Health.TakeDamage();
//                    selectionRender.material = enemy1Material;
//                }
//                _selection = selection;
//            }
//            Debug.Log(hit.transform.name);
//        }
//    }
//}
