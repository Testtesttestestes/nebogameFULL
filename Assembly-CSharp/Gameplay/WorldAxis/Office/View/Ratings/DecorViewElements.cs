using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	[Serializable]
	public class DecorViewElements
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x6420", Offset = "0x6420", VA = "0x6420")]
		public void DetermineDecorSprite(int position, bool myClan)
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x6421", Offset = "0x6421", VA = "0x6421")]
		public DecorViewElements()
		{
		}

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
