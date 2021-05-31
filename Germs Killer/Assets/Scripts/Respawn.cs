using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies = null;
    [SerializeField] private float maxTimeToResp = 5;
    [SerializeField] private float minTimeToResp = 1;
    [SerializeField] private GameLevel gameLevel = null;
    private float timeToNextRespawn = 1;
    private int lastEnemyInTheList = 1;

    private void Start()
    {
        StartCoroutine(RespawnEnemy());
    }
    IEnumerator RespawnEnemy()
    {
        if (gameLevel.level > enemies.Length)
        {
            lastEnemyInTheList = enemies.Length;
        }
        else
        {
            lastEnemyInTheList = gameLevel.level;
        }
        timeToNextRespawn = Random.Range(minTimeToResp, maxTimeToResp);
        GameObject enemy = Instantiate(enemies[Random.Range(0, lastEnemyInTheList)], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(timeToNextRespawn);
        StartCoroutine(RespawnEnemy());
    } 
}
