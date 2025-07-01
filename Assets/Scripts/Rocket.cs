using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public float vitesse;
    public bool monte;

    public GameObject explosion;
    
    public void JumpKeyPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump");
            monte = true;
        }
        else if (context.canceled)
        {
            Debug.Log("Stop Jump");
            monte = false;
        }
    }

    public void Update()
    {
        switch (monte)
        {
            case true when transform.position.y < 2.8:
                transform.position +=  new Vector3(0, 1, 0) * (vitesse * Time.deltaTime);
                break;
            case false when transform.position.y > -2.8:
                transform.position -=  new Vector3(0, 1, 0) * (vitesse * Time.deltaTime);
                break;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity );
        
        UIGameOverManager.instance.Display();
        print("Aie");
    }
}
