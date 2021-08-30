using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    [SerializeField] int xPos;
    [SerializeField] int yPos;
    [SerializeField] int enemyCount;
    [SerializeField] int roundLimit;


    // Start is called before the first frame update
    void Start()
    {
        roundLimit = 100;
        StartCoroutine(EnemySpawn1());
        StartCoroutine(EnemySpawn2());
        StartCoroutine(EnemySpawn3());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemySpawn1()
    {
        float secondsToWait = Random.Range(0.01f, 2f);
        while (enemyCount < roundLimit)
        {
            xPos = Random.Range(-217, 232);
            yPos = 10;
            Instantiate(enemy1, new Vector3(xPos, yPos, 56), Quaternion.identity);
            yield return new WaitForSeconds(secondsToWait);
            enemyCount += 1;
        }
    }
    IEnumerator EnemySpawn2()
    {
        float secondsToWait = Random.Range(0.01f, 2f);
        while (enemyCount < roundLimit)
        {
            xPos = Random.Range(-217, 232);
            yPos = 10;
            Instantiate(enemy2, new Vector3(xPos, yPos, 56), Quaternion.identity);
            yield return new WaitForSeconds(secondsToWait);
            enemyCount += 1;
        }
    }
    IEnumerator EnemySpawn3()
    {
        float secondsToWait = Random.Range(0.01f, 2f);
        while (enemyCount < roundLimit)
        {
            xPos = Random.Range(-217, 232);
            yPos = 10;
            Instantiate(enemy3, new Vector3(xPos, yPos, 56), Quaternion.identity);
            yield return new WaitForSeconds(secondsToWait);
            enemyCount += 1;
        }
    }
}
