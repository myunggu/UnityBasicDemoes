using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        GetComponent<RectTransform>().anchoredPosition += new Vector2(1, 0) * 50 * Time.deltaTime;
    }
}
