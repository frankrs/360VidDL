using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Xml;

public class DownLoader : MonoBehaviour {

	public WWW www;
	public string url;
	public bool downloaded;
	public int bytes;

	// Use this for initialization
	void Start () {
	
	}


	void OnGUI(){
		if(GUI.Button(new Rect(0,0,Screen.width,Screen.height * .5f),"GetVid")){
			StartCoroutine("GetVid");
		}
		GUI.Toggle(new Rect(0,Screen.height * .5f,Screen.width,Screen.height * .5f),downloaded,"DownLoaded");

	}



	IEnumerator GetVid(){
		www = new WWW(url);
		yield return www;
		downloaded = www.isDone;
		bytes = www.bytesDownloaded;
		System.IO.File.WriteAllBytes("/mnt/external_sd/" + "example.mp4", www.bytes);
	}


	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown("escape")){
		Application.Quit();
		}
	}



	
}
