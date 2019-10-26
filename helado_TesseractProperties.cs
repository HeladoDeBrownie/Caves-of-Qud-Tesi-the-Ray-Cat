namespace XRL.World.Parts
{
    public class helado_TesseractProperties : IPart
    {
        public override bool FireEvent(Event E)
        {
            ParentObject.Destroy(true);
            XRL.UI.Popup.Show("&RNo.");
            return true;
        }

        public override void Register(GameObject Object)
        {
            Object.RegisterPartEvent(this, "EnteredCell");
            base.Register(Object);
        }
    }
}
