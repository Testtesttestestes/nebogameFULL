using System;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	public class ClanRatingListElement : ClanInRatingListElement
	{
		// Token: 0x0600218E RID: 8590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x72ED", Offset = "0x72ED", VA = "0x72ED", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x72EE", Offset = "0x72EE", VA = "0x72EE")]
		private void DetermineDecorSprite()
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x72EF", Offset = "0x72EF", VA = "0x72EF")]
		public ClanRatingListElement()
		{
		}

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
