using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtoFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = thingtoFollow.transform.position + new Vector3(0,0, -10);
    }
}
