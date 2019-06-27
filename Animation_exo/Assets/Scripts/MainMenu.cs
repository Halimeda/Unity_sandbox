using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void StratGame()
    {
        SceneManager.LoadScene(0);
    }

    public void DisplaySliderValue(float value)
    {
        Debug.Log("Slider Value: " + value.ToString());
    }

}
