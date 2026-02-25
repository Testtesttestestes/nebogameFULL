using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	public class ClanMembersOSAView : OSA<BaseParamsWithPrefab, ClanMembersViewsHolder>
	{
		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5F")]
		public SimpleDataHelper<ClanMemberListElement.ClanMemberListElementArgs> Data
		{
			[Token(Token = "0x6003DF6")]
			[Address(RVA = "0x8CB5", Offset = "0x8CB5", VA = "0x8CB5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DF7")]
			[Address(RVA = "0x8CB6", Offset = "0x8CB6", VA = "0x8CB6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x8CB7", Offset = "0x8CB7", VA = "0x8CB7", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x8CB8", Offset = "0x8CB8", VA = "0x8CB8", Slot = "99")]
		protected override ClanMembersViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x8CB9", Offset = "0x8CB9", VA = "0x8CB9", Slot = "100")]
		protected override void UpdateViewsHolder(ClanMembersViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x8CBA", Offset = "0x8CBA", VA = "0x8CBA")]
		public void AddItemsAt(int index, IList<ClanMemberListElement.ClanMemberListElementArgs> items)
		{
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x8CBB", Offset = "0x8CBB", VA = "0x8CBB")]
		public void SetItems(IList<ClanMemberListElement.ClanMemberListElementArgs> items)
		{
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x8CBC", Offset = "0x8CBC", VA = "0x8CBC")]
		public ClanMembersOSAView()
		{
		}
	}
}
