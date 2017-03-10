using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scSceneMove : MonoBehaviour
{
    //이동할 씬의 이름을 미리 받아옴
    public string sceneName;

    public void MoveScene()
    {
        //씬의 이름을 아래 케이스들과 비교
        switch (sceneName)
        {
            //씬의 이름이 Main이거나 loadeGame이면 sceneName의 씬으로 이동
            case "Main":
            case "loadGame":
                SceneManager.LoadScene(sceneName);
                break;
            //씬의 이름이 leaveGame이면 게임 종료
            case "leaveGame":
                //SceneManager의 게임 종료를 몰라서 구형식으로 작성함.
                Application.Quit();
                break;
            case "setting":
                GameObject canvas = Resources.Load("Prefab/Canvas") as GameObject;
                Instantiate(canvas, new Vector3(0,0,0), Quaternion.identity);
                break;
            default:
                Debug.Log("지정되지 않은 버튼 / Unspecified button.");
                break;
        }
    }
}
