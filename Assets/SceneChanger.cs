using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ARShoes1()
    {
        SceneManager.LoadScene("HumanBodyTrackingShoes1");
    }
    public void ARShoes2()
    {
        SceneManager.LoadScene("HumanBodyTrackingShoes2");
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