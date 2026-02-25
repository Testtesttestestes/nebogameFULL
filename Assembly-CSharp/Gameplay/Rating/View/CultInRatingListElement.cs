using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x02000575 RID: 1397
	[Token(Token = "0x2000575")]
	public class CultInRatingListElement : SelectableListElement<CultInRatingListElement.CultInRatingListElementArgs>
	{
		// Token: 0x06002195 RID: 8597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x72F4", Offset = "0x72F4", VA = "0x72F4", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x72F5", Offset = "0x72F5", VA = "0x72F5", Slot = "10")]
		protected override void CallElementClickedEvent(CultInRatingListElement.CultInRatingListElementArgs args)
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x72F6", Offset = "0x72F6", VA = "0x72F6")]
		public CultInRatingListElement()
		{
		}

		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TextMeshProUGUI _place;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected TextMeshProUGUI _rating;

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected GameImage _cultIcon;

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		public class CultInRatingListElementArgs : SelectableListElementArgs<CultInRatingListElement>
		{
			// Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002198")]
			[Address(RVA = "0x72F7", Offset = "0x72F7", VA = "0x72F7")]
			public CultInRatingListElementArgs()
			{
			}

			// Token: 0x04001257 RID: 4695
			[Token(Token = "0x4001257")]
			[FieldOffset(Offset = "0x1C")]
			public CultDic CultDic;

			// Token: 0x04001258 RID: 4696
			[Token(Token = "0x4001258")]
			[FieldOffset(Offset = "0x20")]
			public uint Rating;

			// Token: 0x04001259 RID: 4697
			[Token(Token = "0x4001259")]
			[FieldOffset(Offset = "0x24")]
			public int Place;

			// Token: 0x0400125A RID: 4698
			[Token(Token = "0x400125A")]
			[FieldOffset(Offset = "0x28")]
			public bool MyCult;
		}
	}
}
