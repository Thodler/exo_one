using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public List<GameObject> obstacles =  new List<GameObject>();
    public int start;
    
    void Start()
    {
        InvokeRepeating("Spawn", start, 2);
    }

    void Spawn()
    {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            return;
        }
        int indexAleatoire = Random.Range(0, obstacles.Count);
        print(indexAleatoire);
        GameObject newObstacle = Instantiate(obstacles[indexAleatoire], transform.position, Quaternion.identity);
        
        float facteurEchelle = Random.Range(0.8f, 1);
        newObstacle.transform.localScale *= facteurEchelle;
        
    }
}
