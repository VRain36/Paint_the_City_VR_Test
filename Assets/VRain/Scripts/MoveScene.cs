using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    [SerializeField]
    private GameObject _text;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void HoverEntered()
    {
        _text.SetActive(true);
    }

    public void HoverExited()
    {
        _text.SetActive(false);
    }

    public void Select()
    {
        Debug.Log("Selected");
        SceneManager.LoadScene("Prototype_Main");
    }
}
