using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float vitesse;

    void Update()
    {
        transform.position -= new Vector3(8, 0, 0) * (vitesse * Time.deltaTime);

        if (transform.position.y > 0)
        {
            // Destroy(gameObject);
        }
    }
    
}
