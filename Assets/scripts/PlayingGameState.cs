using UnityEngine;

public class PlayingGameState:GameBaseState
{
     public override void  enterState(GameStateManager gameState) {
        Debug.Log("Entramos no modo jogo");
        gameState.AtivarElementosJogo(true);
        gameState.player.GetComponent<Snake>().ResetState();
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.gameOverState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo no modo jogo");
        gameState.AtivarElementosJogo(false);

    }
}
