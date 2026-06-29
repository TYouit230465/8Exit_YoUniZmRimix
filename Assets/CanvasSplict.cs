using UnityEngine;

public class CanvasSplict : MonoBehaviour
{
    public static CanvasSplict Instance;
    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //ÉVÅ[Éìå◊Ç¨Ç≈è¡Ç¶Ç»Ç¢
        }
        else
        {
            Destroy(gameObject); // èdï°ñhé~
        }

    }
}
