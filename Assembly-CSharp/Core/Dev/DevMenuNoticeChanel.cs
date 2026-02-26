using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010AE RID: 4270
	[Token(Token = "0x20010AE")]
	public class DevMenuNoticeChanel : MonoBehaviour
	{
		// Token: 0x06006324 RID: 25380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006324")]
		[Address(RVA = "0xAF30", Offset = "0xAF30", VA = "0xAF30")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuNoticeChanel__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a60767 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Heavens_External_Common_IAppHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Heavens_External_Common_INotifications_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11661);
		    DAT_ram_00a60767 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81cdcbf1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cdcbf1:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x81cdcc73;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x13);
		code_r0x81cdcc73:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (OKG_Heavens_External_Common_IAppHolder_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x81cdccf1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,OKG_Heavens_External_Common_IAppHolder_TypeInfo,1);
		code_r0x81cdccf1:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x160);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (OKG_Heavens_External_Common_INotifications_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cdcd7a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,OKG_Heavens_External_Common_INotifications_TypeInfo,0);
		code_r0x81cdcd7a:
		  local_1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,uVar5,puVar2[1]);
		  uVar5 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar5 = func_ii_4419(StringLiteral_28579,uVar5,0);
		  uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11661,uVar5,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06006325 RID: 25381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006325")]
		[Address(RVA = "0xAF31", Offset = "0xAF31", VA = "0xAF31")]
		private void ButtonClick()
		{
		/* --- GHIDRA: ButtonClick ---
		void Core_Dev_DevMenuNoticeChanel__ButtonClick(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60768 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuNoticeChanel_ButtonClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a60768 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuNoticeChanel_ButtonClick__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006326 RID: 25382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006326")]
		[Address(RVA = "0xAF32", Offset = "0xAF32", VA = "0xAF32")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006327")]
		[Address(RVA = "0xAF33", Offset = "0xAF33", VA = "0xAF33")]
		public DevMenuNoticeChanel()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuNoticeChanel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60769 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dev_DevMenuScheduleNotification_ScheduleButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1911);
		    DAT_ram_00a60769 = '\x01';
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x10),StringLiteral_1911,0);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Core_Dev_DevMenuScheduleNotification_ScheduleButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;
	}
}
