using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	public class DailyQuestsListAdapter : OSA<BaseParamsWithPrefab, DailyQuestsViewsHolder>
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A00")]
		public SimpleDataHelper<DailyQuestsListElementArgs> Data
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x830E", Offset = "0x830E", VA = "0x830E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x830F", Offset = "0x830F", VA = "0x830F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BE")]
		[Address(RVA = "0x8310", Offset = "0x8310", VA = "0x8310", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x8311", Offset = "0x8311", VA = "0x8311")]
		public void SetItems(IList<DailyQuestsListElementArgs> items)
		{
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x8312", Offset = "0x8312", VA = "0x8312", Slot = "99")]
		protected override DailyQuestsViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x8313", Offset = "0x8313", VA = "0x8313", Slot = "104")]
		protected override void OnBeforeRecycleOrDisableViewsHolder(DailyQuestsViewsHolder inRecycleBinOrVisible, int newItemIndex)
		{
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x8314", Offset = "0x8314", VA = "0x8314", Slot = "100")]
		protected override void UpdateViewsHolder(DailyQuestsViewsHolder newOrRecycled)
		{
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x8315", Offset = "0x8315", VA = "0x8315")]
		public DailyQuestsListAdapter()
		{
		}
	}
}
