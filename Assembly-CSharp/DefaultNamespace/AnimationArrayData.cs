using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DefaultNamespace
{
	// Token: 0x02000E51 RID: 3665
	[Token(Token = "0x2000E51")]
	[CreateAssetMenu(menuName = "Heavens/Create animations array data")]
	public class AnimationArrayData : ScriptableObject
	{
		// Token: 0x060059CE RID: 22990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059CE")]
		[Address(RVA = "0xA6F6", Offset = "0xA6F6", VA = "0xA6F6")]
		public AnimationArrayData()
		{
		}

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0xC")]
		public GameObject[] GafAnimations;

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		[FieldOffset(Offset = "0x10")]
		public GameObject[] SpineAnimations;
	}
}
