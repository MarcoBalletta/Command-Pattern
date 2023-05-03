using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : BaseCharacter
{

    private float timer = 0f;
    private SortedList<float, TypeOfCommand> mapCommands = new SortedList<float, TypeOfCommand>();
    private TypeOfCommand currentCommand;

    protected override void Awake()
    {
        base.Awake();    
    }

    public void Setup(float speedValue, float jumpForce, SortedList<float, TypeOfCommand> mapCommands)
    {
        speed = speedValue;
        this.jumpForce = jumpForce;
        this.mapCommands = mapCommands;
    }

    private void Start()
    {
        StartCoroutine(RepeatActions());
    }

    private IEnumerator RepeatActions()
    {
        int indexActions = 0;
        while(indexActions < mapCommands.Count)
        {
            Debug.Log("Timer : " + timer + " ---- " + mapCommands.Keys[indexActions]);
            if (timer >= mapCommands.Keys[indexActions])
            {
                currentCommand = mapCommands.Values[indexActions];
                indexActions++;
            }

            timer += Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        Destroy(gameObject, 3f);
    }

    private void FixedUpdate()
    {
        HandleVelocity();
    }

    private void HandleVelocity()
    {
        int direction = 1;
        if (currentCommand == TypeOfCommand.moveLeft)
        {
            direction = -1;
        }else if(currentCommand == TypeOfCommand.idle)
        {
            direction = 0;
        }

        rb.velocity = new Vector2(Vector2.right.x * direction * speed * Time.deltaTime, rb.velocity.y);
    }
}
