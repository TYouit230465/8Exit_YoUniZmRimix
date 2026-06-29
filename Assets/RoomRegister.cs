using UnityEngine;

public class RoomRegister : MonoBehaviour
{
    public RoomInfo roomInfo;
    void Start()
    {
        GameManager.Instance.SetRoom(roomInfo.roomType);
    }

}
//•”‰®‚Ìî•ñ‚ğGM‚É“`‚¦‚Ä‚é