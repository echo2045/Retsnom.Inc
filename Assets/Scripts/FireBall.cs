using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject Player, FireSpirit;

    float distance, angle, speed = 10f;
    Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(FireSpirit.transform.position, Player.transform.position);
        direction = Player.transform.position - FireSpirit.transform.position;
        direction.Normalize();
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        transform.position += (direction * speed * Time.deltaTime);

       /* if (transform.position.x > 21f || transform.position.x < -3f || transform.position.y > 14f || transform.position.y < -4f)
        {
            Destroy(gameObject);
        }*/

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

   
}
