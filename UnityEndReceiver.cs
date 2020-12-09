using System.Runtime.Serialization;
using System.Collections;
using System.IO;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine;


public class json : MonoBehaviour
{
    // Start is called before the first frame update

    private string url ="http://127.0.0.1:5000/3";
    public void GetData()
    {
        StartCoroutine(MakeRequest());
    }
    IEnumerator MakeRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        if (request.isNetworkError|| request.isHttpError){
            Debug.Log(request.error);
        }else{
            my_details loaded_my_details = JsonUtility.FromJson<my_details>(request.downloadHandler.text);
            Debug.Log("epoch"+loaded_my_details.request_time);
        }

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



        //string json = File.ReadAllText("C:/Users/sarina/Desktop/personal.json");
        //my_details loaded_my_details = JsonUtility.FromJson<my_details>(json);
        //Debug.Log("age"+loaded_my_details.age);
        
    }
    private class my_details{
        public string name;
        public int request_time;
    }
}
