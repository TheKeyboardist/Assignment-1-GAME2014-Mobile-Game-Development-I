using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundEffectController : MonoBehaviour
{
    public AudioSource clickSoound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void PlaySound()
    {
        clickSoound.Play(); 
    }
}
