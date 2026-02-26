using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C0 RID: 4800
	[Token(Token = "0x20012C0")]
	public class AprsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001724")]
		protected override string Theme
		{
			[Token(Token = "0x60071FC")]
			[Address(RVA = "0xBC05", Offset = "0xBC05", VA = "0xBC05", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FD")]
		[Address(RVA = "0xBC06", Offset = "0xBC06", VA = "0xBC06", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AprsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59558 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AprsAnalyticsListener_BuyAprEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AprsAnalyticsListener_NewAprEvent__);
		    DAT_ram_00a59558 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AprsAnalyticsListener_BuyAprEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AprsAnalyticsListener_NewAprEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
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

		// Token: 0x060071FE RID: 29182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FE")]
		[Address(RVA = "0xBC07", Offset = "0xBC07", VA = "0xBC07", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AprsAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59559 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25581);
		    DAT_ram_00a59559 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = 0;
		  Core_Analytics_Listeners_AprsAnalyticsListener__BuyAprEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),0,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_25581;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81028361;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81028361:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0xBC08", Offset = "0xBC08", VA = "0xBC08")]
		private void NewAprEvent(AprsScope.AprsEventArgs e)
		{
		/* --- GHIDRA: NewAprEvent ---
		void Core_Analytics_Listeners_AprsAnalyticsListener__NewAprEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5955a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20804);
		    DAT_ram_00a5955a = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = 0;
		  Core_Analytics_Listeners_AprsAnalyticsListener__BuyAprEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),1,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_20804;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81028563;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81028563:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007200")]
		[Address(RVA = "0xBC09", Offset = "0xBC09", VA = "0xBC09")]
		private void BuyAprEvent(AprsScope.AprsEventArgs e)
		{
		/* --- GHIDRA: BuyAprEvent ---
		void Core_Analytics_Listeners_AprsAnalyticsListener__BuyAprEvent
		               (undefined4 param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5955b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19894);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19893);
		    DAT_ram_00a5955b = '\x01';
		  }
		  uVar1 = Gameplay_Aprs_Model_AprData__set_SaleMarkersDic(param3,0);
		  func_ii_2946(param2,StringLiteral_19894,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x1c) + 0x10) + 0xc);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param2,StringLiteral_19893,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_00 = *(int *)(*(int *)(*(int *)(param3 + 0x14) + 0x10) + 0x24);
		  if ((param1_00 != 0) && (param4 != 0)) {
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (param1_00,param2,param1_00,StringLiteral_26155,param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007201")]
		[Address(RVA = "0xBC0A", Offset = "0xBC0A", VA = "0xBC0A")]
		private void AppendAprProperties(Dictionary<string, object> properties, AprData aprData, bool includePrice)
		{
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007202")]
		[Address(RVA = "0xBC0B", Offset = "0xBC0B", VA = "0xBC0B")]
		public AprsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_AprsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5955c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20002);
		    DAT_ram_00a5955c = '\x01';
		  }
		  return StringLiteral_20002;
		}
		*/

		}

		// Token: 0x04003BBD RID: 15293
		[Token(Token = "0x4003BBD")]
		private const string BUY_APR = "buy_apr";

		// Token: 0x04003BBE RID: 15294
		[Token(Token = "0x4003BBE")]
		private const string NEW_APR = "new_apr";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AprsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59557 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AprsAnalyticsListener_BuyAprEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AprsAnalyticsListener_NewAprEvent__);
		    DAT_ram_00a59557 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AprsAnalyticsListener_BuyAprEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AprsAnalyticsListener_NewAprEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AprsScope_AprsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AprsScope_AprsEventArgs__TypeInfo);
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
