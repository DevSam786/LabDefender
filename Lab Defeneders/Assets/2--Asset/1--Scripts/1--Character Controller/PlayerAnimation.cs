using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public GameInput gameInput;
    public PlayerController playerController;
    private Animator anime;

    // Start is called before the first frame update
    private void Awake()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       /* Vector2 input = gameInput.GetInputVectorNormalized();
        

        Vector2 moveDir = new Vector2(input.x, input.y);

        anime.SetFloat("InputX", moveDir.x);
        anime.SetFloat("InputY", moveDir.y);


        if(playerController.isDashing == true)
        {
            anime.SetTrigger("dash");
        }*/

    }
}
