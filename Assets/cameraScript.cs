using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraMoving();
    }

    public void CameraMoving()
    {

        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
    }
}
