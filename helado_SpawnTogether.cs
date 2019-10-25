namespace XRL.World.Parts
{
    public class helado_SpawnTogether : IPart
    {
        public string BlueprintName = "helado_Tesi";

        public override bool FireEvent(Event E)
        {
            switch (E.ID)
            {
                case "EnteredCell":
                    if (XRL.Core.XRLCore.Core.Game.GetStringGameState("embark") != "&YJoppa")
                    {
                        ParentObject.CurrentCell.getClosestReachableCell().AddObject(BlueprintName);
                    }

                    ParentObject.RemovePart(this);
                    return true;
                default:
                    return base.FireEvent(E);
            }
        }

        public override void Register(GameObject Object)
        {
            Object.RegisterPartEvent(this, "EnteredCell");
            base.Register(Object);
        }
    }
}
