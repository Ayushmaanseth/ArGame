using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private Vector3 colliderPos;
    public static int score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                colliderPos = hit.collider.transform.position;
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                    score++;
                    Debug.Log("Score now is " + score);
                }
            }
        }
    }

    void LateUpdate()
    {
        StartCoroutine(DataInserter.CreateUser(DataInserter.url, score)); 
    }

}
