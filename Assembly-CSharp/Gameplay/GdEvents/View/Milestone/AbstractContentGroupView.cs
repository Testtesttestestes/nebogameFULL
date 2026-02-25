using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x200071E")]
	public abstract class AbstractContentGroupView : MonoBehaviour
	{
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700084F")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002B9E")]
			[Address(RVA = "0x7C35", Offset = "0x7C35", VA = "0x7C35")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x7C36", Offset = "0x7C36", VA = "0x7C36")]
		protected AbstractContentGroupView()
		{
		}

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}
}
