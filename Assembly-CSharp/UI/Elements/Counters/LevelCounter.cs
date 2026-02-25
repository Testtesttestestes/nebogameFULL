using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Counters
{
	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	public class LevelCounter : MonoBehaviour
	{
		// Token: 0x170001E0 RID: 480
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E0")]
		public uint Level
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x60B9", Offset = "0x60B9", VA = "0x60B9")]
			set
			{
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x60BA", Offset = "0x60BA", VA = "0x60BA")]
		public LevelCounter()
		{
		}

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
