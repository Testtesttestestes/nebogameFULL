using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class BankOsaView : OSA<BaseParamsWithPrefab, BankOptionViewHolder>
	{
		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C8D RID: 19597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6D")]
		public SimpleDataHelper<BankOptionViewArgs> Data
		{
			[Token(Token = "0x6004C8C")]
			[Address(RVA = "0x9ACD", Offset = "0x9ACD", VA = "0x9ACD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C8D")]
			[Address(RVA = "0x9ACE", Offset = "0x9ACE", VA = "0x9ACE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x9ACF", Offset = "0x9ACF", VA = "0x9ACF", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x9AD0", Offset = "0x9AD0", VA = "0x9AD0", Slot = "99")]
		protected override BankOptionViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x9AD1", Offset = "0x9AD1", VA = "0x9AD1", Slot = "100")]
		protected override void UpdateViewsHolder(BankOptionViewHolder newOrRecycled)
		{
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x9AD2", Offset = "0x9AD2", VA = "0x9AD2")]
		public void AddItemsAt(int index, IList<BankOptionViewArgs> items)
		{
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x9AD3", Offset = "0x9AD3", VA = "0x9AD3")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x9AD4", Offset = "0x9AD4", VA = "0x9AD4")]
		public void SetItems(IList<BankOptionViewArgs> items)
		{
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x9AD5", Offset = "0x9AD5", VA = "0x9AD5")]
		public BankOsaView()
		{
		}
	}
}
