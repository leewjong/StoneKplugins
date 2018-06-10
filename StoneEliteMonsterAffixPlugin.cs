using System.Collections.Generic;
using System.Linq;
using Turbo.Plugins.Default;

namespace Turbo.Plugins.Stone
{

    public class StoneEliteMonsterAffixPlugin : BasePlugin, IInGameWorldPainter, ICustomizer
	{

        public Dictionary<MonsterAffix, WorldDecoratorCollection> AffixDecorators { get; set; }
        public Dictionary<MonsterAffix, string> CustomAffixNames { get; set; }

        public bool HideOnIllusions { get; set; }

        public StoneEliteMonsterAffixPlugin()
		{
            Enabled = true;
            Order = 20000;
            HideOnIllusions = true;
		}
        public void Customize()
        {
            Hud.TogglePlugin<EliteMonsterAffixPlugin>(false);
        }


        public override void Load(IController hud)
        {
            base.Load(hud);

            CustomAffixNames = new Dictionary<MonsterAffix, string>();
            CustomAffixNames.Add(MonsterAffix.Wormhole, "�ð�");
            CustomAffixNames.Add(MonsterAffix.Illusionist, "ȯ��");
            CustomAffixNames.Add(MonsterAffix.Juggernaut, "����");
            CustomAffixNames.Add(MonsterAffix.Molten, "����");
            CustomAffixNames.Add(MonsterAffix.Waller, "��");
            CustomAffixNames.Add(MonsterAffix.Arcane, "����");
            CustomAffixNames.Add(MonsterAffix.Electrified, "����");
            CustomAffixNames.Add(MonsterAffix.FireChains, "�罽");
            CustomAffixNames.Add(MonsterAffix.HealthLink, "����");
            CustomAffixNames.Add(MonsterAffix.Horde, "����");
            CustomAffixNames.Add(MonsterAffix.Shielding, "����");
            CustomAffixNames.Add(MonsterAffix.Teleporter, "����");



            AffixDecorators = new Dictionary<MonsterAffix, WorldDecoratorCollection>();

            AffixDecorators.Add(MonsterAffix.Arcane, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 120, 0, 120, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Electrified, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 6f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 40, 40, 240, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.FireChains, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 6f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 170, 50, 0, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.HealthLink, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 6f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Horde, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Illusionist, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Juggernaut, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 255, 0, 0, 0),
                }
                ));

            AffixDecorators.Add(MonsterAffix.Molten, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 170, 50, 0, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Shielding, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 255, 255, 255, true, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 255, 0, 0, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Teleporter, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 6f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Waller, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 6f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));
            AffixDecorators.Add(MonsterAffix.Wormhole, new WorldDecoratorCollection(
                new GroundLabelDecorator(Hud)
                {
                    BorderBrush = Hud.Render.CreateBrush(128, 0, 0, 0, 2),
                    TextFont = Hud.Render.CreateFont("tahoma", 10f, 255, 200, 220, 120, false, false, false),
                    BackgroundBrush = Hud.Render.CreateBrush(255, 50, 50, 50, 0),
                }
                ));

        }

        public void PaintWorld(WorldLayer layer)
        {
            var monsters = Hud.Game.AliveMonsters;
            foreach (var monster in monsters.Where(x => x.IsElite))
            {
                if (HideOnIllusions && (monster.SummonerAcdDynamicId != 0) && (monster.Rarity == ActorRarity.RareMinion) || (monster.Rarity == ActorRarity.RareMinion)) continue;

                foreach (var snoMonsterAffix in monster.AffixSnoList)
                {
                    WorldDecoratorCollection decorator;
                    if (!AffixDecorators.TryGetValue(snoMonsterAffix.Affix, out decorator)) continue;

                    string affixName = null;
                    if (CustomAffixNames.ContainsKey(snoMonsterAffix.Affix))
                    {
                        affixName = CustomAffixNames[snoMonsterAffix.Affix];
                    }
                    else affixName = snoMonsterAffix.NameLocalized;

                    decorator.Paint(layer, monster, monster.FloorCoordinate, affixName);
                }
            }
        }

    }

}