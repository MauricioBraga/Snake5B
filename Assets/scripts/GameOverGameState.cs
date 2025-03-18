using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameOverGameState:GameBaseState
{
    private GameObject telaGameOver;
     public override void enterState(GameStateManager gameState) {
        Debug.Log("Entramos no game over");
        telaGameOver = GameObject.Find("tela_Game_Over_Snake_1280_1060_0");
        telaGameOver.GetComponent<SpriteRenderer>().enabled = true;
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.telaCreditosState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo do game over");
        telaGameOver.GetComponent<SpriteRenderer>().enabled = false;

    }
}
