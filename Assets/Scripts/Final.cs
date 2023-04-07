using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public int sahne_id;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            SceneManager.LoadScene(sahne_id);
        }
    }
}
