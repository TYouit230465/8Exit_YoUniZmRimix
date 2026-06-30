using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;




public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public RoomType currentRoomType;

    public string[] roomScenes;//部屋を入れる
    int lastIndex = -1;
    int correctCount = 0;
    int missCount = 0;//ButEnd分岐に使用

    GameObject TrackNo;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //シーン跨ぎで消えない
        }
        else
        {
            Destroy(gameObject); // 重複防止
        }

    }

    public void SetRoom(RoomType type)
    {
        currentRoomType = type;

        

    }

    public void GoBackToStart()
    {

        
        correctCount = 0;
        missCount++;
        SceneManager.LoadScene("GameSceneA0");
        

        if (missCount >= 6)//ミスカウントが６以上になったらバットエンドに分岐
        {
            SceneManager.LoadScene("ButEndScene01");
            
        }

    }

    public void GoNextRoom()
    {
        

        if (correctCount >= 8)
        {
            
            if (missCount == 0)
            {
                
                SceneManager.LoadScene("ClearScene");
                correctCount++;
                return;
            }
            else
            {
                SceneManager.LoadScene("ClearScene02");
                correctCount++;
                return;
            }
        }

        int index;
        do
        {
            index = Random.Range(0, roomScenes.Length);
        } while (index == lastIndex);

        lastIndex = index;


        SceneManager.LoadScene(roomScenes[index]);

        correctCount++;
    }

   

    void Start()
    {
        this.TrackNo = GameObject.Find("TrackNo");
    }

    void Update()
    {
        this.TrackNo.GetComponent<TextMeshProUGUI>().text = "" + correctCount ;

        if(correctCount == 9)
        {
            this.TrackNo.GetComponent<TextMeshProUGUI>().text = " ";
        }

        if(missCount >=6)
        {
            this.TrackNo.GetComponent<TextMeshProUGUI>().text = "[Censored]";
        }


        if (Keyboard.current.backspaceKey.isPressed)//バックスペースキー押したら隠しBatEnd
        {
            SceneManager.LoadScene("ButEndScene02");
            
        }


    }


}
