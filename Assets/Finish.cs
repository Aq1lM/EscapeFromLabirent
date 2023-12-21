using UnityEngine;
using UnityEngine.UI;


public class Finish : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Finish"))
        {
            hasCollided = true;

            Destroy(collision.gameObject);
        }
    }

    
    void OnGUI()
    {
        if (hasCollided)
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Congratulations!");
        }
    }
}
