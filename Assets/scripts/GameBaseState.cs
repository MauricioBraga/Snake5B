using UnityEngine;

public abstract class GameBaseState
{
    public abstract void enterState(GameStateManager gameState);
    public abstract void updateState(GameStateManager gameState);

    public abstract void leaveState(GameStateManager gameState);

    
}
