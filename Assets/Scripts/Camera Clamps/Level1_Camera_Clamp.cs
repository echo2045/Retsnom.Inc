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

        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, 0.25f, 17.75f), Mathf.Clamp(targetToFollow.position.y, -2.82f, 12.85f), transform.position.z);

    }
}
