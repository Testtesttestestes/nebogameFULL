using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public class CultRatingListElement : CultInRatingListElement
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x72F8", Offset = "0x72F8", VA = "0x72F8", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x72F9", Offset = "0x72F9", VA = "0x72F9")]
		private void DetermineDecorSprite()
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x72FA", Offset = "0x72FA", VA = "0x72FA")]
		public CultRatingListElement()
		{
		}

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
