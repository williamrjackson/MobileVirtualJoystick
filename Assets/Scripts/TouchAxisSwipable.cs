using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAxisSwipable : MonoBehaviour
{
    public void MoveUp()
    {
        transform.position += transform.up;
    }
    public void MoveDown()
    {
        transform.position -= transform.up;
    }
    public void MoveRight()
    {
        transform.position += transform.right;
    }
    public void MoveLeft()
    {
        transform.position -= transform.right;
    }
}
