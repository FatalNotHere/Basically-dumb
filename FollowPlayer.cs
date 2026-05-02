using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    private float groundLength = 100f;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.transform;
    }
    void Update()
    {
        if (player.position.z>transform.position.z+groundLength)
        {
        transform.position+=new Vector3(0,0, groundLength*2);
        }
    } 
}