using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new(0f, 4.16f, -8f);
 
    void LateUpdate() => transform.position = player.transform.position + offset;
}
