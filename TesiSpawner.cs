using System;

namespace XRL.World.Parts {
    [Serializable] public class helado_TesiSpawner : IPart {
        public bool didAlreadySpawnTesi;

        public helado_TesiSpawner () {
            base.Name = "helado_TesiSpawner"; }

        public override bool FireEvent (Event e) {
            if (e.ID == "EnteredCell" && !didAlreadySpawnTesi) {
                Physics physics = this.ParentObject.GetPart ("Physics") as Physics;
                GameObject tesi = GameObjectFactory.Factory.CreateObject ("helado_Tesi");
                physics.CurrentCell.getClosestReachableCell ().AddObject (tesi);
                didAlreadySpawnTesi = true;
                return true; }
            else {
                return false; } }

        public override void Register (GameObject Object) {
            Object.RegisterPartEvent (this, "EnteredCell"); }

        public override bool SameAs (IPart p) {
            return false; } } }
