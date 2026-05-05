using UnityEngine;

public class PlayerContriller : MonoBehaviour
{
    private Vector3 moveVector = new Vector3(0, 0, 1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(moveVector);
    }
}
