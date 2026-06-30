using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContoroller : MonoBehaviour
{
    
    
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
