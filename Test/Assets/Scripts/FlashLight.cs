using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
   
    public GameObject LensObject;
    private AudioSource _audioSource;

    void Start()
    {
        
        _audioSource = GetComponent<AudioSource>();
    }

    public void LightOn()
    {
        _audioSource.Play();
        LensObject.SetActive(true);
    }

    public void LightOff()
    {
        _audioSource.Play();
        LensObject.SetActive(false);
    }

  
    

}
