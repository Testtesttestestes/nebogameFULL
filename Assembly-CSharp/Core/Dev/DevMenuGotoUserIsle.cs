using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010AD RID: 4269
	[Token(Token = "0x20010AD")]
	public class DevMenuGotoUserIsle : MonoBehaviour
	{
		// Token: 0x06006320 RID: 25376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006320")]
		[Address(RVA = "0xAF2C", Offset = "0xAF2C", VA = "0xAF2C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuGotoUserIsle__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60764 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4624);
		    DAT_ram_00a60764 = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = System_UInt64__Parse(*(undefined4 *)(*(int *)(param1 + 0x10) + 0x160),&local_8,0);
		  if (iVar2 == 0) {
		    uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                      (StringLiteral_4624,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x160),0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar4,0);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		          goto code_r0x81cdc9c7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81cdc9c7:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		    Core_Gameplay_Managers_WorldManager__GoHome(uVar4,local_8,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006321 RID: 25377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006321")]
		[Address(RVA = "0xAF2D", Offset = "0xAF2D", VA = "0xAF2D")]
		private void GoToUserIsleButton()
		{
		/* --- GHIDRA: GoToUserIsleButton ---
		void Core_Dev_DevMenuGotoUserIsle__GoToUserIsleButton(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60765 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuGotoUserIsle_GoToUserIsleButton__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a60765 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Core_Dev_DevMenuGotoUserIsle_GoToUserIsleButton__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006322 RID: 25378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006322")]
		[Address(RVA = "0xAF2E", Offset = "0xAF2E", VA = "0xAF2E")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006323")]
		[Address(RVA = "0xAF2F", Offset = "0xAF2F", VA = "0xAF2F")]
		public DevMenuGotoUserIsle()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuGotoUserIsle___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60766 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuNoticeChanel_ButtonClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21093);
		    DAT_ram_00a60766 = '\x01';
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x10),StringLiteral_21093,0);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuNoticeChanel_ButtonClick__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _goToUsleByIdButton;
	}
}
