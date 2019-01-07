using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*コルーチンを使ってロードする練習 */

public class LoadScene : MonoBehaviour {

	// 0:読み込み前 1:読み込み開始 2:ローディング完了
	private int loadState;
	AsyncOperation nextScene;

	void Update(){
		if(loadState==2 && Input.GetMouseButtonDown(0)){
			nextScene.allowSceneActivation = true;
		}
	}

	void OnMouseDown () {
		if(loadState>0){
			return;
		}
		StartCoroutine("LoadNextScene");
	}

	void LoadNextScene () {
		loadState = 1;
		nextScene = Application.LoadLevelAsync("SCENE2");
		nextScene.allowSceneActivation = false;
		while(nextScene.progress < 0.9f){
			Debug.Log(nextScene.progress * 100 + "%");
		}
		loadState = 2;
	}

}
