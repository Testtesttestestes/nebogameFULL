using System;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	public class UserRatingListElement : UserInRatingListElement
	{
		// Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x7326", Offset = "0x7326", VA = "0x7326", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x7327", Offset = "0x7327", VA = "0x7327")]
		private void DetermineDecorSprite()
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x7328", Offset = "0x7328", VA = "0x7328")]
		public UserRatingListElement()
		{
		}

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
