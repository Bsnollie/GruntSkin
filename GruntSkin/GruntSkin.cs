using System.Linq;
using System.IO;

namespace DuckGame.GruntSkin
{
    public class GruntSkin : ClientMod
    {
        public override Priority priority
        {
            get
            {
                return Priority.HatPack;
            }
        }

        protected override void OnPostInitialize()
        {
            Team team = Team.Deserialize(Mod.GetPath<GruntSkin>("hats/Grunt MC.png"));

            if (team != null)
            {
                Teams.AddExtraTeam(team);
            }

            base.OnPostInitialize();
        }
    }
}