using RimWorld;
using Verse;

namespace Gimmicks
{
    // Token: 0x02000003 RID: 3
    public class ThoughtWorker_WearingWhip : ThoughtWorker
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (p.equipment.Primary == null)
            {
                return ThoughtState.Inactive;
            }

            if (p.equipment.Primary.def.defName == "Tool_Whip" ||
                p.equipment.Primary.def.defName == "VWE_Tool_Whip")
            {
                return ThoughtState.ActiveAtStage(0);
            }

            return ThoughtState.Inactive;
        }
    }
}