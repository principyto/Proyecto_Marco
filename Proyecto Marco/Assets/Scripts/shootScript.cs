using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRender = selection.GetComponent<Renderer>();
            if(selectionRender != null)
            {
                selectionRender.material = highlightMaterial;
            }
        }
    }
}
