using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
    public GameObject NotificationImg;

    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        NotificationImg.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //audioSource.Play();
            NotificationImg.SetActive(true);
            StartCoroutine(DisableImg());
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        NotificationImg.SetActive(false);
    }
}
