using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth_Move : MonoBehaviour
{
    //Bool
    bool shouldmove = false;
    bool left, right, up, down = false;
    bool IsMoving= false;
    [SerializeField]
    float speed = 4f;//higher is slower
    //Vectors
    public Vector2 goalvecter;

    //inputs

    // Start is called before the first frame update
    void Start()
    {
        goalvecter = transform.position;//defaults location of goal startpoint
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (shouldmove)
        {
            Vector2 position = transform.position;

            transform.position = Vector2.MoveTowards(transform.position, goalvecter, speed * Time.deltaTime);
            if (position == goalvecter)
            {
                goalvecter = position;
                IsMoving = false;
            }
        }
    }
    void Update()
    {
        Vector2 position = transform.position;//updates position now

        //get the inputs
        left = Input.GetKey("left");
        right = Input.GetKey("right");
        up = Input.GetKey("up");
        down = Input.GetKey("down");

        if (IsMoving) { return; }
        //if
        if (left)
        {
            goalvecter = goalvecter + new Vector2(-1, 0);
            shouldmove = true;
            IsMoving = true;
        }
        if (right)
        {
            goalvecter = goalvecter + new Vector2(1, 0);
            shouldmove = true;
            IsMoving = true;
        }
        if (up)
        {
            goalvecter = goalvecter + new Vector2(0, 1);
            shouldmove = true;
            IsMoving = true;
        }
        if (down)
        {
            goalvecter = goalvecter - new Vector2(0, 1);
            shouldmove = true;
            IsMoving = true;
        }
        if (goalvecter == position)
        {
            shouldmove = false;
            IsMoving = false;
        }
    }


}
