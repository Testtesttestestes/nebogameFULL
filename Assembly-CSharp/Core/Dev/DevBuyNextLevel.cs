using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010AB RID: 4267
	[Token(Token = "0x20010AB")]
	public class DevBuyNextLevel : MonoBehaviour
	{
		// Token: 0x06006318 RID: 25368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006318")]
		[Address(RVA = "0xAF24", Offset = "0xAF24", VA = "0xAF24")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Core_Dev_DevBuyNextLevel__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6075e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevBuyNextLevel_Call__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6075e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevBuyNextLevel_Call__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006319 RID: 25369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006319")]
		[Address(RVA = "0xAF25", Offset = "0xAF25", VA = "0xAF25")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevBuyNextLevel__Awake(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a6075f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6075f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x81cdc528;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81cdc528:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_User_Controller_UserController__MainServiceOnSkillsChangedEvent
		            (*(undefined4 *)(iVar3 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x0600631A RID: 25370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631A")]
		[Address(RVA = "0xAF26", Offset = "0xAF26", VA = "0xAF26")]
		private void Call()
		{
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600631B")]
		[Address(RVA = "0xAF27", Offset = "0xAF27", VA = "0xAF27")]
		public DevBuyNextLevel()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevBuyNextLevel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60760 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dev_DevMenuArtifactComparerDebugMode_ToggleValueChanged__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a60760 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_Core_Dev_DevMenuArtifactComparerDebugMode_ToggleValueChanged__,
		             0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;
	}
}
