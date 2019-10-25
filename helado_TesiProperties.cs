namespace XRL.World.Parts
{
    public class helado_TesiProperties : IPart
    {
        public override bool FireEvent(Event E)
        {
            switch (E.ID)
            {
                case "helado_Amalgamate":
                    if (E.GetGameObjectParameter("OtherObject").HasPart("helado_TesiProperties"))
                    {
                        E.SetParameter("Blueprint", "helado_Tesseract");
                    }

                    return true;

                default:
                    return base.FireEvent(E);
            }
        }

        public override void Register(GameObject Object)
        {
            Object.RegisterPartEvent(this, "helado_Amalgamate");
            base.Register(Object);
        }
    }
}
