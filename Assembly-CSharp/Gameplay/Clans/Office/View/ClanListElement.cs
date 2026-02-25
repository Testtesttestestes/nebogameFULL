using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	public abstract class ClanListElement<T> : SelectableListElement<T> where T : SelectableListElementArgs
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD6")]
		protected ClanListElement()
		{
		}

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _place;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _rating;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameImage _cultIcon;
	}
}
