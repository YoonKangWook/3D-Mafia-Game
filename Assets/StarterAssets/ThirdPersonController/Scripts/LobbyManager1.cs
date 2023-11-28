using UnityEngine;
using UnityEngine.SceneManagement;

// 마스터(매치 메이킹) 서버와 룸 접속을 담당
public class LobbyManager1 : MonoBehaviour {

    public void OnClickGameStart()  
    {
        SceneManager.LoadScene("Main Menu");
    }
}