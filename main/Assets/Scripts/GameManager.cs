using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;   
    public int score = 0;
    public GameObject ScoreText;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
            {
                Destroy(_hit.transform.gameObject);

                Coin();

            }
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Destroy(obj);
        }
        else if (collision.gameObject.tag == "floor")
        {
            Destroy(obj1);
        }

    }

    public void Coin()
    {

        score++;
        ScoreText.GetComponent<Text>().text =  score.ToString();

    }





}
