using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private float limitX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 newPos = transform.position;
            newPos.x = mousePos.x;

    

            newPos.x = Mathf.Clamp(newPos.x, -limitX, limitX);  

            Vector3 LerpPos = Vector3.Lerp(transform.position, newPos, 0.4f);
            transform.position = newPos;
        }
    }
}
