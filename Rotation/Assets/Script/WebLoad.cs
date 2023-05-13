using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebLoad : MonoBehaviour
{
    [SerializeField] RawImage image;
    
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(GetTexture(image));
    }

    IEnumerator GetTexture(RawImage webImage)
    {
        string url = "https://cdn.pixabay.com/photo/2017/09/04/18/39/coffee-2714970_960_720.jpg";

        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if(www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        } else
        {
            webImage.texture = ((DownloadHandlerTexture) www.downloadHandler).texture;
        }
    }

}
