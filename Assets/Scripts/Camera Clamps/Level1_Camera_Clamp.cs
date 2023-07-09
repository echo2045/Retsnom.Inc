using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_Camera_Clamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -2.44f, 20.47f), Mathf.Clamp(targetToFollow.position.y, -3.86f, 13.88f), transform.position.z);

    }
}
