using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Create a reference to the player
    public GameObject player;

    // create a variable for the camera's offset
    private Vector3 offset = new Vector3(-0.03f, 5.69f, -6.68f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
