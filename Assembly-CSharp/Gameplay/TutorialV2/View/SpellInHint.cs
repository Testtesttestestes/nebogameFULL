using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public class SpellInHint : MonoBehaviour
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x6ADA", Offset = "0x6ADA", VA = "0x6ADA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x6ADB", Offset = "0x6ADB", VA = "0x6ADB")]
		public SpellInHint()
		{
		}

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;
	}
}
