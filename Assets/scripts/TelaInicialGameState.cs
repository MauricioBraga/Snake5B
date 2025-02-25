using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TelaInicialGameState:GameBaseState
{
     public override void enterState(GameStateManager gameState) {
        Debug.Log("Entramos na tela inicial");
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.telaCreditosState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo da tela inicial");

    }
}
