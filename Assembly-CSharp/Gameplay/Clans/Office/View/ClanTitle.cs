using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class ClanTitle : MonoBehaviour
	{
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C04")]
		private TextMeshProUGUI Text
		{
			[Token(Token = "0x6003CE7")]
			[Address(RVA = "0x8BA7", Offset = "0x8BA7", VA = "0x8BA7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x8BA8", Offset = "0x8BA8", VA = "0x8BA8")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x8BA9", Offset = "0x8BA9", VA = "0x8BA9")]
		public ClanTitle()
		{
		}

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI _text;
	}
}
