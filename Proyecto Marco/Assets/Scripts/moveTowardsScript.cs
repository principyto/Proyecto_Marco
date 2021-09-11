using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveTowardsScript : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    //[SerializeField]
    //GameObject target;
    //[SerializeField] Transform targetRotate;
    //public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Awake()
    {
        Follow();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
        //Follow();
        //RotateTowards();
    }

    void Follow()
    {
        player = GameObject.Find("Player");
    }

    //void RotateTowards()
    //{
    //    Vector3 direction = targetRotate.position - transform.position;
    //    Quaternion rotation = Quaternion.LookRotation(direction);
    //    transform.rotation = rotation;
    //}
}
