using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataInserter : MonoBehaviour
{

    public int inputScore;

    public static string url = "https://argame.azurewebsites.net/insert.php";

    // Use this for initialization
    

    


public static IEnumerator CreateUser(string url, int score)
{
    Debug.Log("Test 1 ");
    WWWForm form = new WWWForm();
    form.AddField("scorePost", score);
    UnityWebRequest www = UnityWebRequest.Post(url, form);


    yield return www.SendWebRequest();
    if (www.isNetworkError || www.isHttpError)
    {
        Debug.Log(www.error);
    }

    else
    {
        Debug.Log("Form Upload Complete!");
    }
    Debug.Log(www.downloadHandler.text);

}
}

