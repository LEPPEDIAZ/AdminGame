using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour {
    public Scene scene;
    [SerializeField] private string loadLevel;
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
            SceneManager.LoadScene(loadLevel);
            Debug.Log("COLISIONO");
          
          
        }
    }
}
