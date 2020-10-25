/***;
*Project            : When they are gone
*
*Program name       : "Instructions.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 20/10/03
*
*Description        : Load scenes with button press.
*
*Last modified      : 20/10/03
*
* Revision History  :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201003    Ivan Kravchenko        Created script. 
*
|**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{

    public AudioSource click;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time); 
        SceneManager.LoadScene("Instructions");
    }


    // Event Handler for the StartButton_Pressed Event
    public void OnInstructionsButtonPressed()
    {
        click.Play();
        StartCoroutine("Delay", 0.15f);
        Debug.Log("Instructions Button Pressed");
    }
}
