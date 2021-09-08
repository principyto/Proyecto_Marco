using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsScript : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField] Transform targetRotate;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Follow();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        RotateTowards();
    }

    void Follow()
    {
        target = GameObject.Find("Player");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    void RotateTowards()
    {
        Vector3 direction = targetRotate.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}
