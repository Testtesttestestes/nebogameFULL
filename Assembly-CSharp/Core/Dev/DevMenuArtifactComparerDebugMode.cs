using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010AC RID: 4268
	[Token(Token = "0x20010AC")]
	public class DevMenuArtifactComparerDebugMode : MonoBehaviour
	{
		// Token: 0x0600631C RID: 25372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631C")]
		[Address(RVA = "0xAF28", Offset = "0xAF28", VA = "0xAF28")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuArtifactComparerDebugMode__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a60761 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60761 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		          goto code_r0x81cdc673;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81cdc673:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar4 != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		            goto code_r0x81cdc71c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81cdc71c:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      if (*(int *)(iVar4 + 0x1c) != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120
		                               );
		              goto code_r0x81cdc7cc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81cdc7cc:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		        UnityEngine_Scripting_RequiredByNativeCodeAttribute__set_Name
		                  (*(undefined4 *)(iVar4 + 0x1c),(uint)*(byte *)(*(int *)(param1 + 0x10) + 0xc4),0);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600631D RID: 25373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631D")]
		[Address(RVA = "0xAF29", Offset = "0xAF29", VA = "0xAF29")]
		private void ToggleValueChanged(bool enabled)
		{
		/* --- GHIDRA: ToggleValueChanged ---
		void Core_Dev_DevMenuArtifactComparerDebugMode__ToggleValueChanged(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60762 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dev_DevMenuArtifactComparerDebugMode_ToggleValueChanged__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a60762 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_Core_Dev_DevMenuArtifactComparerDebugMode_ToggleValueChanged__,
		             0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x0600631E RID: 25374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631E")]
		[Address(RVA = "0xAF2A", Offset = "0xAF2A", VA = "0xAF2A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631F")]
		[Address(RVA = "0xAF2B", Offset = "0xAF2B", VA = "0xAF2B")]
		public DevMenuArtifactComparerDebugMode()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuArtifactComparerDebugMode___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60763 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuGotoUserIsle_GoToUserIsleButton__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1995);
		    DAT_ram_00a60763 = '\x01';
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x10),StringLiteral_1995,0);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Core_Dev_DevMenuGotoUserIsle_GoToUserIsleButton__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Toggle _toggle;
	}
}
