using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ARShoes()
    {
        SceneManager.LoadScene("HumanBodyTrackingShoes");
    }
    public void ARBodyDrawing()
    {
        SceneManager.LoadScene("HumanBodyTrackingDrawingWithOptions");
    }
    public void ARBodySuperPower()
    {
        SceneManager.LoadScene("HumanBodyTrackingWithSuperPowers");
    }
    public void HomePage()
    {
        SceneManager.LoadScene("HomePage");
    }
}