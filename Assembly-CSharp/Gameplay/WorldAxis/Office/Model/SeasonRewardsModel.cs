using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	public class SeasonRewardsModel : AbstractModel
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000286")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001118")]
			[Address(RVA = "0x6315", Offset = "0x6315", VA = "0x6315")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x6316", Offset = "0x6316", VA = "0x6316")]
		public SeasonRewardsModel(UserData user)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000287")]
		public RatingPrizeDic[] UserPrizes
		{
			[Token(Token = "0x600111A")]
			[Address(RVA = "0x6317", Offset = "0x6317", VA = "0x6317")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x6318", Offset = "0x6318", VA = "0x6318")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000288")]
		public RatingPrizeDic[] ClanPrizes
		{
			[Token(Token = "0x600111C")]
			[Address(RVA = "0x6319", Offset = "0x6319", VA = "0x6319")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111D")]
			[Address(RVA = "0x631A", Offset = "0x631A", VA = "0x631A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000289")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x600111E")]
			[Address(RVA = "0x631B", Offset = "0x631B", VA = "0x631B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111F")]
			[Address(RVA = "0x631C", Offset = "0x631C", VA = "0x631C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;
	}
}
