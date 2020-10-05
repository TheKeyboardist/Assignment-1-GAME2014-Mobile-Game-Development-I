﻿/***;
*Project            : When they are gone
*
*Program name       : "StartButtonBehaviour.cs"
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

public class StartButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event Handler for the StartButton_Pressed Event
    public void OnStartButtonPressed()
    {
        Debug.Log("StartButton Pressed");
        SceneManager.LoadScene("Menu");
    }
}