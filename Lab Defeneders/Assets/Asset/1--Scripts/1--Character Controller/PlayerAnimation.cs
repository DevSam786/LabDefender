using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.SetFloat("InputX", playerController.input.x);
        anime.SetFloat("InputY", playerController.input.y);

    }
}
