﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    public GameObject loadingImage;
	
	//Puts up a loading image
    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene ("Pinball");
    }
}