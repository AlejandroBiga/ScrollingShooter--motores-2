using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            GameObject obstacle = Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);

            
            Destroy(obstacle, 3f);

            yield return new WaitForSeconds(2f);
        }
    }
}
