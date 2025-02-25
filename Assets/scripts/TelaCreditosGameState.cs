using UnityEngine;

public class TelaCreditosGameState:GameBaseState
{
     public override void  enterState(GameStateManager gameState) {
        Debug.Log("Entramos na tela créditos");
     }
    public override void updateState(GameStateManager gameState) {

    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo da tela créditos");

    }
}
