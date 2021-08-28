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

    private Transform _selection;

    void Update()
    {
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
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
            }
        }
    }
}
