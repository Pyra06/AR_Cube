using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadArrow : MonoBehaviour
{
    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;

                switch (btnName)
                {
                    case "Left":
                        Debug.Log("Left");
                        break;
                    case "Right":
                        Debug.Log("Right");
                        break;
                    case "Up":
                        Debug.Log("Up");
                        break;
                    case "Down":
                        Debug.Log("Down");
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
