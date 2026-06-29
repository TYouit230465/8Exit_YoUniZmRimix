using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public RoomType currentRoomType;

    public string[] roomScenes;//部屋を入れる
    int lastIndex = -1;
    int correctCount = 0;

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

        Debug.Log("現在の部屋タイプ：" + type);

    }

    public void GoBackToStart()
    {

        Debug.Log("0番に戻る");
        correctCount = 0;
        SceneManager.LoadScene("GameSceneA0");

    }

    public void GoNextRoom()
    {
        

        if (correctCount >= 8)
        {
            Debug.Log("クリア！");
            SceneManager.LoadScene("ClearScene");
            correctCount++;
            return;
        }

        int index;
        do
        {
            index = Random.Range(0, roomScenes.Length);
        } while (index == lastIndex);

        lastIndex = index;

        Debug.Log(correctCount + "番");

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
            this.TrackNo.GetComponent<TextMeshProUGUI>().text = "?";
        }
        
    }


}

