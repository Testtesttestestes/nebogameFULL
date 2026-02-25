using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DefaultNamespace
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000E52")]
	[CreateAssetMenu(menuName = "Heavens/Create animations array string data")]
	public class AnimationArrayStringData : ScriptableObject
	{
		// Token: 0x060059CF RID: 22991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059CF")]
		[Address(RVA = "0xA6F7", Offset = "0xA6F7", VA = "0xA6F7")]
		public AnimationArrayStringData()
		{
		}

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		[FieldOffset(Offset = "0xC")]
		public string[] GafAnimations;

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0x10")]
		public string[] SpineAnimations;
	}
}
