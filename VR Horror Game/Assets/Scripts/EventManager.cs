using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public AudioSource m_AudioSource;

    private void OnTriggerEnter(Collider Collision)
    {
       if(Collision.gameObject.tag=="SCREAM EVENT")
        {
            m_AudioSource.Play();
            Destroy(Collision.gameObject);
            Debug.Log("Worked");
        }
    }

}
