using System;
using Core.Data;
using Core.Data.Balance;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Common;
using TMPro;
using UI.Elements.GenericList;
using UI.Price;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	public class TreasuryOptionListElement : SelectableListElement<TreasuryOptionListElement.TreasuryOptionListElementArgs>
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x647F", Offset = "0x647F", VA = "0x647F", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x6480", Offset = "0x6480", VA = "0x6480", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x6481", Offset = "0x6481", VA = "0x6481", Slot = "10")]
		protected override void CallElementClickedEvent(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x6482", Offset = "0x6482", VA = "0x6482")]
		public TreasuryOptionListElement()
		{
		}

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _availableText;

		// Token: 0x02000326 RID: 806
		[Token(Token = "0x2000326")]
		public class TreasuryOptionListElementArgs : SelectableListElementArgs<TreasuryOptionListElement>
		{
			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06001289 RID: 4745 RVA: 0x00004980 File Offset: 0x00002B80
			// (set) Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DF")]
			public uint Count
			{
				[Token(Token = "0x6001289")]
				[Address(RVA = "0x6483", Offset = "0x6483", VA = "0x6483")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600128A")]
				[Address(RVA = "0x6484", Offset = "0x6484", VA = "0x6484")]
				set
				{
				}
			}

			// Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x6485", Offset = "0x6485", VA = "0x6485")]
			public TreasuryOptionListElementArgs()
			{
			}

			// Token: 0x04000A06 RID: 2566
			[Token(Token = "0x4000A06")]
			[FieldOffset(Offset = "0x1C")]
			private uint _count;

			// Token: 0x04000A07 RID: 2567
			[Token(Token = "0x4000A07")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactData ArtifactData;

			// Token: 0x04000A08 RID: 2568
			[Token(Token = "0x4000A08")]
			[FieldOffset(Offset = "0x24")]
			public ResourceSet Price;

			// Token: 0x04000A09 RID: 2569
			[Token(Token = "0x4000A09")]
			[FieldOffset(Offset = "0x28")]
			public IBalanceSource ClanBalance;

			// Token: 0x04000A0A RID: 2570
			[Token(Token = "0x4000A0A")]
			[FieldOffset(Offset = "0x2C")]
			public uint OptionId;
		}
	}
}
