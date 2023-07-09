using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Spirit_Manager : MonoBehaviour
{
    public Animator animator;

    public GameObject Player;


    public float FollowSpeed = 5f;
    //public Transform target;

    private float distance;
    //private Vector3 offset;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Fight", true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        //Vector3 dir = Player.transform.position - transform.position;
        //dir.Normalize();
        //Vector3 offset.Normalize(dir);

        if (animator.GetBool("Fight") && distance >= 1)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, FollowSpeed*Time.deltaTime);
        }
        

      
    }
}
