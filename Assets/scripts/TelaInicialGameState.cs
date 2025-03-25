using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TelaInicialGameState:GameBaseState
{
    private GameObject telaInicialJogo;
     public override void enterState(GameStateManager gameState) {
        Debug.Log("Entramos na tela inicial");
        telaInicialJogo = GameObject.Find("tela_inicial_Snake_1280_1060_0");
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = true;
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.playingState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo da tela inicial");
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = false;

    }
}
