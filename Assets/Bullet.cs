using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbdoy;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbdoy = GetCompnent<Rigidbody>();
        bulletRigidbdoy.velocity = transform.forward * speed;

        Destory(gameObject, 3f);
    }
    
    void Destory(Object obj, float t);

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            PlayerController playerController = other.GetCompnent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }
    }

  
}
