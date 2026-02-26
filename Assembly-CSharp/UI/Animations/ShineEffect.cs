using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Animations
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public class ShineEffect : MonoBehaviour
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x6106", Offset = "0x6106", VA = "0x6106")]
		private void Update()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x6107", Offset = "0x6107", VA = "0x6107")]
		public ShineEffect()
		{
		/* --- GHIDRA: .cctor ---
		void UI_Animations_ShineEffect___cctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a639c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_FindObjectOfType_PlayerInputController___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639c8 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = UnityEngine_Object__FindFirstObjectByType_object_
		                    (Method_UnityEngine_Object_FindObjectOfType_PlayerInputController___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_Animations_ShineEffect___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a639c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Animations_ShineEffect_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19261);
		    DAT_ram_00a639c7 = '\x01';
		  }
		  uVar1 = UnityEngine_Shader__TagToID(StringLiteral_19261,0);
		  **(undefined4 **)(UI_Animations_ShineEffect_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x18")]
		private float _timer;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ShineLocationId;
	}
}
