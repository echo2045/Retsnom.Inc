using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Camera_clamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -5, 5), Mathf.Clamp(targetToFollow.position.y, -3, 3), transform.position.z);
        
    }
}
