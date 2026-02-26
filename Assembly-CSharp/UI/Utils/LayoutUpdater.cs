using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Utils
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[ExecuteInEditMode]
	public class LayoutUpdater : MonoBehaviour
	{
		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x5C79", Offset = "0x5C79", VA = "0x5C79")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Utils_LayoutUpdater__Start(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5b8b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a5b8b2 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  if (DAT_ram_00a5b8b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		    DAT_ram_00a5b8b3 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = uVar1;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x5C7A", Offset = "0x5C7A", VA = "0x5C7A")]
		public void Rebuild()
		{
		/* --- GHIDRA: Rebuild ---
		int UI_Utils_LayoutUpdater__Rebuild(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b8b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		    DAT_ram_00a5b8b3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x5C7B", Offset = "0x5C7B", VA = "0x5C7B")]
		protected IEnumerator SetDirty(RectTransform rectTransform)
		{
		/* --- GHIDRA: SetDirty ---
		int UI_Utils_LayoutUpdater__SetDirty(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b8b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Utils_LayoutUpdater__DelayedSetDirty_d__3_TypeInfo);
		    DAT_ram_00a5b8b4 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Utils_LayoutUpdater__DelayedSetDirty_d__3_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x5C7C", Offset = "0x5C7C", VA = "0x5C7C")]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x5C7D", Offset = "0x5C7D", VA = "0x5C7D")]
		public LayoutUpdater()
		{
		}
	}
}
