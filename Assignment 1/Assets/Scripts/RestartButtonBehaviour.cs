﻿/***;
*Project            : When they are gone
*
*Program name       : "RestartButtonBehaviour.cs"
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

public class RestartButtonBehaviour : MonoBehaviour
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
    public void OnRestartButtonPressed()
    {
        Debug.Log("RestartButton Pressed");
        SceneManager.LoadScene("Menu");
    }
}