using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        return true;

    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake & archerIsAwake & prisonerIsAwake) return true;
        if (knightIsAwake & !archerIsAwake & !prisonerIsAwake) return true;
        if (!knightIsAwake & archerIsAwake & !prisonerIsAwake) return true;
        if (!knightIsAwake & !archerIsAwake & prisonerIsAwake) return true;
        if (!knightIsAwake & archerIsAwake & prisonerIsAwake) return true;
        if (knightIsAwake & !archerIsAwake & prisonerIsAwake) return true;
        if (knightIsAwake & archerIsAwake & !prisonerIsAwake) return true;
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
            return true;
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake & archerIsAwake & prisonerIsAwake & !petDogIsPresent)
            return false;
        if(!knightIsAwake & !archerIsAwake & prisonerIsAwake & !petDogIsPresent)
            return true;
        if(!knightIsAwake & !archerIsAwake & prisonerIsAwake & petDogIsPresent)
            return true;
        if(knightIsAwake & !archerIsAwake & !prisonerIsAwake & petDogIsPresent)
            return true;
        if(knightIsAwake & !archerIsAwake & prisonerIsAwake & petDogIsPresent)
            return true;
        if (!knightIsAwake & !archerIsAwake & !prisonerIsAwake & petDogIsPresent)
            return true;
        
        return false;

    }
}
