using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.World.Model;
using Gameplay.WorldAxis.Model;
using Gameplay.WorldAxis.Office.View;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class WorldAxisOfficeModel : AbstractModel
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028A")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001123")]
			[Address(RVA = "0x6320", Offset = "0x6320", VA = "0x6320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x6321", Offset = "0x6321", VA = "0x6321")]
		public WorldAxisOfficeModel(UserData user, WorldAxisModel worldAxisModel)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028B")]
		public ColossusBattleListElement.ColossusBattleListElementArgs[] ColossusBattles
		{
			[Token(Token = "0x6001125")]
			[Address(RVA = "0x6322", Offset = "0x6322", VA = "0x6322")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001126")]
			[Address(RVA = "0x6323", Offset = "0x6323", VA = "0x6323")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x6324", Offset = "0x6324", VA = "0x6324")]
		public List<TabBarItemData<WorldAxisOfficeWindow.Tab>> GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x6325", Offset = "0x6325", VA = "0x6325")]
		public void RepopulateColossusBattles()
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x6326", Offset = "0x6326", VA = "0x6326")]
		public void AddRating(IList<ColossusRating> ratings, uint colossusId)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x6327", Offset = "0x6327", VA = "0x6327")]
		public IList<WorldAxisOfficeModel.ColossusClanRating> GetRating(uint colossusId)
		{
			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x6328", Offset = "0x6328", VA = "0x6328")]
		private ColossusBattleListElement.ColossusBattleListElementArgs CreateArgs(ColossusBattleData data)
		{
			return null;
		}

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<uint, WorldAxisOfficeModel.ColossusClanRating[]> _colossusRatingsDict;

		// Token: 0x020002D7 RID: 727
		[Token(Token = "0x20002D7")]
		public class ColossusClanRating
		{
			// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x632A", Offset = "0x632A", VA = "0x632A")]
			public ColossusClanRating(ColossusRating rating, Dictionaries dict)
			{
			}

			// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x632B", Offset = "0x632B", VA = "0x632B")]
			public ColossusClanRating()
			{
			}

			// Token: 0x040008EB RID: 2283
			[Token(Token = "0x40008EB")]
			[FieldOffset(Offset = "0x8")]
			public ClanData ClanData;

			// Token: 0x040008EC RID: 2284
			[Token(Token = "0x40008EC")]
			[FieldOffset(Offset = "0x10")]
			public long Score;
		}
	}
}
