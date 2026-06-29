using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContoroller : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void OnMouseUpAsSButton()
    {
        SceneManager.LoadScene("GameSceneA0");
        
    }

    public void OnMouseUpMoveetc()
    {
        SceneManager.LoadScene("MoveScene");
    }

    public void OnMouseUpTitel()
    {
        SceneManager.LoadScene("TitelScene");
    }

}
