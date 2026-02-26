using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010AF RID: 4271
	[Token(Token = "0x20010AF")]
	public class DevMenuScheduleNotification : MonoBehaviour
	{
		// Token: 0x06006328 RID: 25384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006328")]
		[Address(RVA = "0xAF34", Offset = "0xAF34", VA = "0xAF34")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuScheduleNotification__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6076a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6510);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4622);
		    DAT_ram_00a6076a = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Net_WebHeaderCollection__Add
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x160),&local_4,0);
		  if (iVar1 == 0) {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                      (StringLiteral_4622,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x160),0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  else {
		    local_8 = local_4;
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_6510,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006329 RID: 25385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006329")]
		[Address(RVA = "0xAF35", Offset = "0xAF35", VA = "0xAF35")]
		private void ScheduleButtonClickedEventHandler()
		{
		/* --- GHIDRA: ScheduleButtonClickedEventHandler ---
		void Core_Dev_DevMenuScheduleNotification__ScheduleButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6076b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dev_DevMenuScheduleNotification_ScheduleButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6076b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Core_Dev_DevMenuScheduleNotification_ScheduleButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600632A RID: 25386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632A")]
		[Address(RVA = "0xAF36", Offset = "0xAF36", VA = "0xAF36")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632B")]
		[Address(RVA = "0xAF37", Offset = "0xAF37", VA = "0xAF37")]
		public DevMenuScheduleNotification()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuScheduleNotification___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6076c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuShowConsole_ClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6076c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuShowConsole_ClickHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _scheduleButton;
	}
}
