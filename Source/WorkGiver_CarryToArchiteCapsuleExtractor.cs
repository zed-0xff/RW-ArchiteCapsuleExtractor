using Verse;
using RimWorld;

namespace ArchiteCapsuleExtractor
{
    public class WorkGiver_CarryToArchiteCapsuleExtractor : WorkGiver_CarryToBuilding
    {
#if RW15
        public override ThingRequest PotentialWorkThingRequest => ThingRequest.ForDef(ArchiteCapsuleExtractor_DefOfs.ArchiteCapsuleExtractor);
#else
        public override ThingRequest ThingRequest => ThingRequest.ForDef(ArchiteCapsuleExtractor_DefOfs.ArchiteCapsuleExtractor);
#endif

        public override bool ShouldSkip(Pawn pawn, bool forced = false) => !ModsConfig.BiotechActive;
    }
}
