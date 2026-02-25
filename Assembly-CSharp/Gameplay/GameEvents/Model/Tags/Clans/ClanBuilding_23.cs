using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	public class ClanBuilding_23 : AbstractTag
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x1700091D")]
		public uint BuildingType
		{
			[Token(Token = "0x6002ED2")]
			[Address(RVA = "0x7F41", Offset = "0x7F41", VA = "0x7F41")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x1700091E")]
		public uint BuildingLevel
		{
			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0x7F42", Offset = "0x7F42", VA = "0x7F42")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x1700091F")]
		public uint Cult
		{
			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0x7F43", Offset = "0x7F43", VA = "0x7F43")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x7F44", Offset = "0x7F44", VA = "0x7F44", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x7F45", Offset = "0x7F45", VA = "0x7F45")]
		public ClanBuilding_23()
		{
		}

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		public const string TITLE = "clan_building_title";

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		public const string LEVEL = "clan_building_level";

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		public const string BUILDING_WIDGET = "clan_building_view";

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		public const string VIEW_PREFAB_PATH = "BuildingTagView";
	}
}
