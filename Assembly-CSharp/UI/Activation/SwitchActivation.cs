using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Activation
{
	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	public class SwitchActivation : MonoBehaviour
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x610F", Offset = "0x610F", VA = "0x610F")]
		public void SwitchActive()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x6110", Offset = "0x6110", VA = "0x6110")]
		public void SetActive(bool active)
		{
		/* --- GHIDRA: SetActive ---
		void UI_Activation_SwitchActivation__SetActive
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a639cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		    DAT_ram_00a639cd = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		  *(undefined1 *)(param2_00 + 0x18) = (undefined1)param2;
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = 1;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x6111", Offset = "0x6111", VA = "0x6111")]
		public void DelayedSetActive(bool active)
		{
		/* --- GHIDRA: DelayedSetActive ---
		int UI_Activation_SwitchActivation__DelayedSetActive
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a639cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		    DAT_ram_00a639cd = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		  *(undefined1 *)(iVar1 + 0x18) = (undefined1)param2;
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x6112", Offset = "0x6112", VA = "0x6112")]
		private IEnumerator DelayedSetActiveRoutine(bool active, int delayFrames = 1)
		{
			return null;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x6113", Offset = "0x6113", VA = "0x6113")]
		public SwitchActivation()
		{
		}
	}
}
