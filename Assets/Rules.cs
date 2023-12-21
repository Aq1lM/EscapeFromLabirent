using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    private bool hasCollided = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rules"))
        {
            hasCollided = true;

            Destroy(collision.gameObject);
        }
    }

    void OnGUI()
    {
        if (hasCollided)
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Rule: Escape From Labirent!");
        }
    }
}
