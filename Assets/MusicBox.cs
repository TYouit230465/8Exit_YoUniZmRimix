using UnityEngine;

public class MusicBox : MonoBehaviour
{
    AudioSource audioSource;
    public static MusicBox Instance;
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
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.15f;
        audioSource.Play();
    }

   
}
