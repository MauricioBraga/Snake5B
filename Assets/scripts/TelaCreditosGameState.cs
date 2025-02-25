using UnityEngine;

public class TelaCreditosGameState:GameBaseState
{
     public override void  enterState(GameStateManager gameState) {
        Debug.Log("Entramos na tela créditos");
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.telaInicialState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo da tela créditos");

    }
}
