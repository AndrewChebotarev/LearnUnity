using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject nextCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nextCamera.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
