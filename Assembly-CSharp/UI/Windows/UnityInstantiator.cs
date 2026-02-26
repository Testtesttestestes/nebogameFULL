using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	public class UnityInstantiator : IInstantiator
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F41")]
		public T Instantiate<T>(T original, Transform container) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x6175", Offset = "0x6175", VA = "0x6175")]
		public UnityInstantiator()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_UnityInstantiator___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a639f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3001);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a639f5 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12610,param1,
		                     Method_UI_Windows_PopupController_Show_DialogWindow___);
		  uVar2 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3001,uVar2,0);
		  UnityEngine_Texture2D___ctor(uVar1,uVar2,0);
		  return uVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Instantiate<object> ---
		int UI_Windows_UnityInstantiator__Instantiate_object_(int param1)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int param1_01;
		  
		  puVar2 = *(undefined4 **)(param1 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    puVar2 = *(undefined4 **)(param1 + 0x1c);
		    if (puVar2 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param1);
		      puVar2 = *(undefined4 **)(param1 + 0x1c);
		    }
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = UnityEngine_Object__CheckNullArgument(uVar3,0);
		  param1_01 = *(int *)(*(int *)(param1 + 0x1c) + 4);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  if (param1_00 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(param1_00,param1_01);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(param1_00,param1_01);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar1;
		}
		*/

}
