using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsScript : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
