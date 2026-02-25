using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Bank.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	public class SpecialOfferPickerOsaSpinner : OSA<BaseParamsWithPrefab, BankOptionPickerOsaViewHolder>
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000593")]
		public SimpleDataHelper<BankOptionListElement.BankOptionListElementArgs> Data
		{
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x7004", Offset = "0x7004", VA = "0x7004")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x7005", Offset = "0x7005", VA = "0x7005")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000594")]
		public int CurrentSelectedIndex
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x7006", Offset = "0x7006", VA = "0x7006")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x7007", Offset = "0x7007", VA = "0x7007")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000137 RID: 311
		// (add) Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000137")]
		public event Action<int> CurrentSelectedIndexChangedEvent
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x7008", Offset = "0x7008", VA = "0x7008")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x7009", Offset = "0x7009", VA = "0x7009")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x700A", Offset = "0x700A", VA = "0x700A", Slot = "67")]
		protected override void Awake()
		{
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x700B", Offset = "0x700B", VA = "0x700B", Slot = "70")]
		protected override void Update()
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x700C", Offset = "0x700C", VA = "0x700C")]
		private BankOptionPickerOsaViewHolder GetLargeItem(List<BankOptionPickerOsaViewHolder> items)
		{
			return null;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x700D", Offset = "0x700D", VA = "0x700D")]
		private void SelectItem(int index)
		{
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x700E", Offset = "0x700E", VA = "0x700E", Slot = "99")]
		protected override BankOptionPickerOsaViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x700F", Offset = "0x700F", VA = "0x700F", Slot = "100")]
		protected override void UpdateViewsHolder(BankOptionPickerOsaViewHolder newOrRecycled)
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x7010", Offset = "0x7010", VA = "0x7010")]
		public SpecialOfferPickerOsaSpinner()
		{
		}
	}
}
