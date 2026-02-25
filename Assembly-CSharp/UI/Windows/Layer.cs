using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	[AddComponentMenu("PopupLayer")]
	public class Layer : MonoBehaviour
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x17000217")]
		public LayerId LayerId
		{
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x614D", Offset = "0x614D", VA = "0x614D")]
			get
			{
				return LayerId.None;
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x614E", Offset = "0x614E", VA = "0x614E")]
		public Layer()
		{
		}

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LayerId _layerId;
	}
}
