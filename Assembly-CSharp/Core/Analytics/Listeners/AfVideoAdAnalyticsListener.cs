using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BC RID: 4796
	[Token(Token = "0x20012BC")]
	public class AfVideoAdAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001721")]
		protected override string Theme
		{
			[Token(Token = "0x60071E0")]
			[Address(RVA = "0xBBE9", Offset = "0xBBE9", VA = "0xBBE9", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0xBBEA", Offset = "0xBBEA", VA = "0xBBEA", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AfVideoAdAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5953f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AfVideoAdAnalyticsListener_AdWatchedEvent__);
		    DAT_ram_00a5953f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  param1_00 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AfVideoAdAnalyticsListener_AdWatchedEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x14) = iVar3;
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
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

		// Token: 0x060071E2 RID: 29154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0xBBEB", Offset = "0xBBEB", VA = "0xBBEB", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AfVideoAdAnalyticsListener__Deinit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59540 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2950);
		    DAT_ram_00a59540 = '\x01';
		  }
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar1 = StringLiteral_2950;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81025575;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81025575:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0xBBEC", Offset = "0xBBEC", VA = "0xBBEC")]
		private void AdWatchedEvent(AdScope.AdEventArgs e)
		{
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0xBBED", Offset = "0xBBED", VA = "0xBBED")]
		public AfVideoAdAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_AfVideoAdAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59541 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19805);
		    DAT_ram_00a59541 = '\x01';
		  }
		  return StringLiteral_19805;
		}
		*/

		}

		// Token: 0x04003BAA RID: 15274
		[Token(Token = "0x4003BAA")]
		private const string AF_AD_VIEW = "Af_ad_view";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AfVideoAdAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5953e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AfVideoAdAnalyticsListener_AdWatchedEvent__);
		    DAT_ram_00a5953e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  param1_00 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AfVideoAdAnalyticsListener_AdWatchedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x14) = iVar3;
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
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
