using RimWorld;
using Verse;

namespace Gimmicks;

public class ThoughtWorker_WearingWhip : ThoughtWorker
{
    protected override ThoughtState CurrentStateInternal(Pawn p)
    {
        return p.equipment.Primary?.def.defName is "Tool_Whip" or "VWE_Tool_Whip"
            ? ThoughtState.ActiveAtStage(0)
            : ThoughtState.Inactive;
    }
}