using UnityEngine;

public class TelaCreditosGameState:GameBaseState
{
     private GameObject telaCreditosJogo;
     public override void  enterState(GameStateManager gameState) {
        Debug.Log("Entramos na tela créditos");
        telaCreditosJogo = GameObject.Find("tela_creditos_Snake_1280_1060_0");
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = true;
     }
    public override void updateState(GameStateManager gameState) {
            if (Input.GetKeyDown(KeyCode.Space))  {
                gameState.switchState(gameState.telaInicialState);
            }
    }

    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo da tela créditos");
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = false;

    }
}
