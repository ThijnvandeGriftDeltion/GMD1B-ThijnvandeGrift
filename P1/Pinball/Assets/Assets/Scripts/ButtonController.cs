using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

    public GameObject loadingImage;

    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}