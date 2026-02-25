using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	public class UserBuildingTag_4 : AbstractTag
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x17000912")]
		public uint BuildingViewId
		{
			[Token(Token = "0x6002EAA")]
			[Address(RVA = "0x7F25", Offset = "0x7F25", VA = "0x7F25")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x7F26", Offset = "0x7F26", VA = "0x7F26", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x7F27", Offset = "0x7F27", VA = "0x7F27")]
		public UserBuildingTag_4()
		{
		}

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		public const string BUILDING_TITLE = "building_title";

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		public const string BUILDING_LEVEL = "building_level";

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		public const string BUILDING_VIEW = "building_view";

		// Token: 0x04001993 RID: 6547
		[Token(Token = "0x4001993")]
		public const string VIEW_PREFAB_PATH = "BuildingTagView";
	}
}
