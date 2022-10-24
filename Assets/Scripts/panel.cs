using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour
{

    Button restartBtn;

    void Start()
    {
        restartBtn = transform.GetChild(0).GetComponent<Button>();
        restartBtn.onClick.AddListener(retry);
    }

    void Update()
    {
        
    }

    public void retry()
    {
        // Debug.Log("@retry() Pressed");
        gameManager.I.retry();
    }
}
