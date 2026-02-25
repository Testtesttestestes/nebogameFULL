using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.UIController
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	[CreateAssetMenu(fileName = "ResourceColor", menuName = "Heavens/ResourceColor")]
	public class ResourceBarColorSO : ScriptableObject
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x5CBD", Offset = "0x5CBD", VA = "0x5CBD")]
		public ResourceColorElement GetColor(ResourceBarColor resourceBarColor)
		{
			return null;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x5CBE", Offset = "0x5CBE", VA = "0x5CBE")]
		public ResourceBarColorSO()
		{
		}

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private List<ResourceColorElement> _colorElements;
	}
}
