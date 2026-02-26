using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners.DebugListeners
{
	// Token: 0x020012E8 RID: 4840
	[Token(Token = "0x20012E8")]
	public class Debug107447AnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001749")]
		protected override string Theme
		{
			[Token(Token = "0x600733F")]
			[Address(RVA = "0xBD48", Offset = "0xBD48", VA = "0xBD48", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700174A")]
		private string TASK_EVENT_NAME
		{
			[Token(Token = "0x6007340")]
			[Address(RVA = "0xBD49", Offset = "0xBD49", VA = "0xBD49")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007341")]
		[Address(RVA = "0xBD4A", Offset = "0xBD4A", VA = "0xBD4A", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59668 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_PaymentBonusReceivedEvent__
		              );
		    DAT_ram_00a59668 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x48);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_PaymentBonusReceivedEvent__
		             ,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_BankScope_PaymentBonusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0xc) = iVar3;
		  uVar2 = System_Action_BankScope_PaymentBonusEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007342")]
		[Address(RVA = "0xBD4B", Offset = "0xBD4B", VA = "0xBD4B", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  uint uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59669 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_uint___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24511);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1904);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a59669 = '\x01';
		  }
		  iVar7 = Method_System_Collections_Generic_List_uint__Add__;
		  if (*(int *)(param2 + 0x10) != 0) {
		    uVar4 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		    param1_00 = param1[4];
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    }
		    uVar5 = 0;
		    piVar6 = *(int **)(param2 + 0xc);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x810468d4;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810468d4:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar7 = Core_Extensions_Dict_DictExt__GetCurrenciesDic(uVar3,uVar4,0);
		    if (iVar7 == 0) {
		      uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		      func_ii_2946(uVar4,StringLiteral_27640,StringLiteral_1904,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      uVar3 = System_String__Join_float_
		                        (StringLiteral_1236,param1[4],Method_System_String_Join_uint___);
		      func_ii_2946(uVar4,StringLiteral_24511,uVar3,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      piVar6 = (int *)param1[2];
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      if (DAT_ram_00a59666 == '\0') {
		        Mono_Security_ASN1__get_Item(&StringLiteral_27639);
		        DAT_ram_00a59666 = '\x01';
		      }
		      uVar1 = StringLiteral_27639;
		      uVar5 = 0;
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8 + 4) * 8 + iVar7 + 0xd8);
		            goto code_r0x81046a06;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar5);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81046a06:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar3,uVar1,uVar4,puVar2[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007343")]
		[Address(RVA = "0xBD4C", Offset = "0xBD4C", VA = "0xBD4C")]
		private void PaymentBonusReceivedEvent(BankScope.PaymentBonusEventArgs e)
		{
		/* --- GHIDRA: PaymentBonusReceivedEvent ---
		void Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener__PaymentBonusReceivedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5966a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a5966a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007344")]
		[Address(RVA = "0xBD4D", Offset = "0xBD4D", VA = "0xBD4D")]
		public Debug107447AnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5966b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_AxisIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_WorldObject_IsleCloudObjectArgs__get_Args__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3484);
		    DAT_ram_00a5966b = '\x01';
		  }
		  CloudsFly_BaseIsleWorldObject__OnInit(param1,param1);
		  param1_00 = *(int **)(param1[9] + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Isles_Axis_AxisIsle_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Isles_Axis_AxisIsle_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Isles_Axis_AxisIsle_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Isles_Axis_AxisIsle_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Isles_Axis_View_AxisIsleView__UpdateViews(param1[0x11],param1_00,0);
		  local_8 = *(undefined8 *)(param1_00 + 6);
		  uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_3484,uVar1,0);
		  UnityEngine_Texture2D___ctor(param1,uVar1,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  return;
		}
		*/

		}

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		private const string TASK_ID = "107447";

		// Token: 0x04003C57 RID: 15447
		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x10")]
		private List<uint> _bonusIds;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		undefined4
		Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener__get_Theme
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59666 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27639);
		    DAT_ram_00a59666 = '\x01';
		  }
		  return StringLiteral_27639;
		}
		*/


		/* --- GHIDRA: get_TASK_EVENT_NAME ---
		void Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener__get_TASK_EVENT_NAME
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59667 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_PaymentBonusReceivedEvent__
		              );
		    DAT_ram_00a59667 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x48);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_PaymentBonusReceivedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_BankScope_PaymentBonusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0xc) = iVar3;
		  uVar2 = System_Action_BankScope_PaymentBonusEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_BankScope_PaymentBonusEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
