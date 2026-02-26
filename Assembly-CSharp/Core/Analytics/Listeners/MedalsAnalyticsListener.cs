using System;
using System.Collections.Generic;
using Core.Data;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D7 RID: 4823
	[Token(Token = "0x20012D7")]
	public class MedalsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173B")]
		protected override string Theme
		{
			[Token(Token = "0x60072AB")]
			[Address(RVA = "0xBCB4", Offset = "0xBCB4", VA = "0xBCB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AC")]
		[Address(RVA = "0xBCB5", Offset = "0xBCB5", VA = "0xBCB5", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_MedalsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_MedalsAnalyticsListener_BuyMedalEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_MedalsAnalyticsListener_NewMedalEvent__);
		    DAT_ram_00a595f0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x50);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_MedalsAnalyticsListener_NewMedalEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x50);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_MedalsAnalyticsListener_BuyMedalEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AD")]
		[Address(RVA = "0xBCB6", Offset = "0xBCB6", VA = "0xBCB6", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_MedalsAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20807);
		    DAT_ram_00a595f1 = '\x01';
		  }
		  if (*(char *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x18) != '\0') {
		    param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		    uVar2 = 0;
		    Core_Analytics_Listeners_MedalsAnalyticsListener__NewMedalEvent
		              (param1,param2_00,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x14),1,0);
		    param1_00 = (int *)param1[2];
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar1 = StringLiteral_20807;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x810382e3;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810382e3:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072AE RID: 29358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AE")]
		[Address(RVA = "0xBCB7", Offset = "0xBCB7", VA = "0xBCB7")]
		private void BuyMedalEvent(MedalsScope.MedalEventArgs e)
		{
		/* --- GHIDRA: BuyMedalEvent ---
		void Core_Analytics_Listeners_MedalsAnalyticsListener__BuyMedalEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25582);
		    DAT_ram_00a595f2 = '\x01';
		  }
		  if (*(char *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x18) != '\0') {
		    param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		    uVar2 = 0;
		    Core_Analytics_Listeners_MedalsAnalyticsListener__NewMedalEvent
		              (param1,param2_00,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x14),0,0);
		    param1_00 = (int *)param1[2];
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar1 = StringLiteral_25582;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x81038540;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81038540:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AF")]
		[Address(RVA = "0xBCB8", Offset = "0xBCB8", VA = "0xBCB8")]
		private void NewMedalEvent(MedalsScope.MedalEventArgs e)
		{
		/* --- GHIDRA: NewMedalEvent ---
		void Core_Analytics_Listeners_MedalsAnalyticsListener__NewMedalEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4,int param5,
		               undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a595f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24819);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25332);
		    DAT_ram_00a595f3 = '\x01';
		  }
		  iVar1 = Gameplay_Medals_Model_MedalDicGroup__set_IsVisible(*(undefined4 *)(param3 + 8),param4,0);
		  local_1 = *(undefined1 *)(*(int *)(param3 + 8) + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  func_ii_2946(param2,StringLiteral_24819,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = param4;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param2,StringLiteral_25331,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = func_ii_14054(*(undefined4 *)(iVar1 + 0x10),0);
		  func_ii_2946(param2,StringLiteral_25333,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  func_ii_2946(param2,StringLiteral_25332,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x10) + 0x24);
		  if ((iVar1 != 0) && (param5 != 0)) {
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (param1,param2,iVar1,StringLiteral_26155,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B0")]
		[Address(RVA = "0xBCB9", Offset = "0xBCB9", VA = "0xBCB9")]
		private void AppendMedalProperties(Dictionary<string, object> properties, MedalData medalData, uint medalId, bool includePrice)
		{
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B1")]
		[Address(RVA = "0xBCBA", Offset = "0xBCBA", VA = "0xBCBA")]
		public MedalsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_MedalsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_26240);
		    DAT_ram_00a595f4 = '\x01';
		  }
		  return StringLiteral_26240;
		}
		*/

		}

		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		private const string BUY_MEDAL = "buy_medal";

		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		private const string NEW_MEDAL = "new_medal";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_MedalsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_MedalsAnalyticsListener_BuyMedalEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_MedalsAnalyticsListener_NewMedalEvent__);
		    DAT_ram_00a595ef = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x50);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_MedalsAnalyticsListener_NewMedalEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x50);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_MedalsAnalyticsListener_BuyMedalEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_MedalsScope_MedalEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_MedalsScope_MedalEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
