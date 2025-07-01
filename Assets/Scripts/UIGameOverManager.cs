using UnityEngine;

public class UIGameOverManager : MonoBehaviour
{
    public static UIGameOverManager instance;
    
    void Start()
    {
        instance = this;
        // On s'assure que l'écran Game Over est caché au début
        gameObject.SetActive(false);
    }

    public void Display()
    {
        gameObject.SetActive(true);
    }
}
