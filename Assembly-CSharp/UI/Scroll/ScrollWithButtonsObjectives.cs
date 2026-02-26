using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Scroll
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class ScrollWithButtonsObjectives : ScrollWithButtonsVertical
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x5E41", Offset = "0x5E41", VA = "0x5E41", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x5E42", Offset = "0x5E42", VA = "0x5E42")]
		public ScrollWithButtonsObjectives()
		{
		/* --- GHIDRA: .ctor ---
		float UI_Scroll_ScrollWithButtonsObjectives___ctor(int param1,undefined4 param2)
		
		{
		  undefined1 auStack_8 [4];
		  float4 local_4;
		  
		  UnityEngine_RectTransform__set_anchorMax(auStack_8,*(undefined4 *)(param1 + 0x28),0);
		  return -(float)local_4;
		}
		*/

		}

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _buttonsParent;
	}
}
