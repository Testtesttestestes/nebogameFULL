using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A3C RID: 2620
	[Token(Token = "0x2000A3C")]
	public class ClanMembersViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C60")]
		public ClanMemberListElement.ClanMemberListElementArgs ClanMemberData
		{
			[Token(Token = "0x6003DFE")]
			[Address(RVA = "0x8CBD", Offset = "0x8CBD", VA = "0x8CBD")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DFF")]
			[Address(RVA = "0x8CBE", Offset = "0x8CBE", VA = "0x8CBE")]
			set
			{
			}
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x8CBF", Offset = "0x8CBF", VA = "0x8CBF", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x8CC0", Offset = "0x8CC0", VA = "0x8CC0")]
		public ClanMembersViewsHolder()
		{
		}

		// Token: 0x040022CC RID: 8908
		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x14")]
		private ClanMemberListElement _clanMemberListElement;
	}
}
