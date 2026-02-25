using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public class ClanMemberDollsOSAView : OSAGenericBase<ClanMemberDollsOSAView.ClansMembersViewsHolder, ClanMemberDollsListElement.ClanMemberDollsListElementArgs>
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x6536", Offset = "0x6536", VA = "0x6536", Slot = "119")]
		protected override ClanMemberDollsOSAView.ClansMembersViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x6537", Offset = "0x6537", VA = "0x6537")]
		public ClanMemberDollsOSAView()
		{
		}

		// Token: 0x02000348 RID: 840
		[Token(Token = "0x2000348")]
		public class ClansMembersViewsHolder : ItemViewsHolder<ClanMemberDollsListElement>
		{
			// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x6538", Offset = "0x6538", VA = "0x6538", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001348 RID: 4936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x6539", Offset = "0x6539", VA = "0x6539")]
			public ClansMembersViewsHolder()
			{
			}
		}
	}
}
