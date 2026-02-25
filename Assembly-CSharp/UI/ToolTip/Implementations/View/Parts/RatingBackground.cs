using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class RatingBackground : MonoBehaviour
	{
		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x5D30", Offset = "0x5D30", VA = "0x5D30")]
		public void Show(int ratingPlace, bool itsMe)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5D31", Offset = "0x5D31", VA = "0x5D31")]
		public void Show(int ratingPlace)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x5D32", Offset = "0x5D32", VA = "0x5D32")]
		public RatingBackground()
		{
		}

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		public const int MIN_COOL_RATING_PLACE = 3;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _background;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Sprite[] _availBackgroundSprites;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _availBackgoundSpriteForLoggedUser;
	}
}
