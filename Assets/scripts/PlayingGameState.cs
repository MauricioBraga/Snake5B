using UnityEngine;

public class PlayingGameState:GameBaseState
{
     public override void  enterState(GameStateManager gameState) {
        Debug.Log("Entramos no modo jogo");
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.telaCreditosState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo no modo jogo");

    }
}
