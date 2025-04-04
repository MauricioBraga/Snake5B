using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.AI;



public class Snake: MonoBehaviour
{
    public int score;

    public Vector2Int direction = Vector2Int.right;
    private Vector2Int input;

    public List<Transform> segments = new List<Transform>();
    public Transform segmentPreFab;
    public bool ativo = true;

    public GameStateManager gameState;

    public void Start()
    {
        // ativo = true;
        segments.Clear();
        segments.Add(transform);
        score = 0;
        direction = Vector2Int.right;   
    }

    public void setAtivo(bool estado_player)  {
         ativo = estado_player; 
    }

    private void Update()
    {
        if (!ativo)
            return;

            if (direction.x !=0f)   {
                if (Input.GetKeyDown(KeyCode.W) ||  Input.GetKeyDown(KeyCode.UpArrow)) {
                    direction = Vector2Int.up;
                }
                else if (Input.GetKeyDown(KeyCode.S) ||  Input.GetKeyDown(KeyCode.DownArrow)) {
                    direction = Vector2Int.down;
                } 
            }
            else if (direction.y !=0f)   {
                if (Input.GetKeyDown(KeyCode.D) ||  Input.GetKeyDown(KeyCode.RightArrow)) {
                    direction = Vector2Int.right;
                }
                else if (Input.GetKeyDown(KeyCode.A) ||  Input.GetKeyDown(KeyCode.LeftArrow)) {
                    direction = Vector2Int.left;
                }
            }


    }

    public void FixedUpdate()
    {
       
        if (!ativo)
            return;
         Debug.Log("cobra rodando ativa");
        for(int i = segments.Count - 1; i > 0; i--)  {
            segments[i].position = segments[i-1].position;
        }           

        int x = Mathf.RoundToInt(transform.position.x) + direction.x;
        int y = Mathf.RoundToInt(transform.position.y) + direction.y;
        transform.position = new Vector2(x,y);
        
    }

public void ResetState()    {

        // reseta a posição inicial da cobra 
        // e sua direção inicial.
        direction = Vector2Int.right;
        transform.position = Vector3.zero;

        // destroiCobra();
        score = 0;
    }

public void destroiCobra()    {
        // destroi apenas os objetos segmentos da cobra,

        // não destrói a cabeça, por isso começa em 1.
        for (int i = 1; i < segments.Count; i++)     {
            // O metodo destroy recebe um GameObject, por isso
            // usamos a variável gameObject do Transform
            Destroy(segments[i].gameObject);
        }
        // objetos foram destruídos, mas a lista ainda tem variáveis que 
        // apontam para eles (apontam para null agora?)
        // então limpamos a lista, e depois adicionamos de volta a cabeça.
        segments.Clear();
        segments.Add(transform);
    }


}
