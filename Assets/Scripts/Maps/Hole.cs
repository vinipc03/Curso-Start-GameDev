using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{

    /*
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite hole; 
    */
    [SerializeField] private bool detecting;

    // Start is called before the first frame update
    void Start()
    {
       //spriteRenderer.sprite = hole;
    }

    // Update is called once per frame
    void Update()
    {
        //spriteRenderer.sprite = hole;
        if (detecting)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Teste");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            detecting = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            detecting = false;
        }
    }

}
