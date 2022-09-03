using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    public float array = 0.7f;
    
    
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x,connectedNode.transform.position.x,Time.deltaTime*20),
            0,
            connectedNode.position.z + array

        );
    }
}
