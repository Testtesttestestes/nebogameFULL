using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C3 RID: 4803
	[Token(Token = "0x20012C3")]
	public class BankAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001727")]
		protected override string Theme
		{
			[Token(Token = "0x6007215")]
			[Address(RVA = "0xBC1E", Offset = "0xBC1E", VA = "0xBC1E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007216")]
		[Address(RVA = "0xBC1F", Offset = "0xBC1F", VA = "0xBC1F", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_BankAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5956f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BankAnalyticsListener_ExchangeSuccessEvent__);
		    DAT_ram_00a5956f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x48);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BankAnalyticsListener_ExchangeSuccessEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_BankScope_ExchangeEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_BankScope_ExchangeEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_BankScope_ExchangeEventArgs__TypeInfo);
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

		// Token: 0x06007217 RID: 29207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007217")]
		[Address(RVA = "0xBC20", Offset = "0xBC20", VA = "0xBC20", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_BankAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59570 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23048);
		    DAT_ram_00a59570 = '\x01';
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
		  uVar1 = 0;
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (0,param1_00,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x38) + 0x18),
		             StringLiteral_26155,0);
		  local_4 = Com_TheFallenGames_OSA_Core_OSA_object__object___get_Parameters
		                      (*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_25868,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23048;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102b283;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102b283:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007218")]
		[Address(RVA = "0xBC21", Offset = "0xBC21", VA = "0xBC21")]
		private void ExchangeSuccessEvent(BankScope.ExchangeEventArgs e)
		{
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007219")]
		[Address(RVA = "0xBC22", Offset = "0xBC22", VA = "0xBC22")]
		public BankAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_BankAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59571 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20522);
		    DAT_ram_00a59571 = '\x01';
		  }
		  return StringLiteral_20522;
		}
		*/

		}

		// Token: 0x04003BCA RID: 15306
		[Token(Token = "0x4003BCA")]
		private const string EXCHANGE_SUCCESS = "exchage_success";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_BankAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5956e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BankAnalyticsListener_ExchangeSuccessEvent__);
		    DAT_ram_00a5956e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x48);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BankAnalyticsListener_ExchangeSuccessEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_BankScope_ExchangeEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BankScope_ExchangeEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_BankScope_ExchangeEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_BankScope_ExchangeEventArgs__TypeInfo);
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
