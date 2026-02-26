using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C1 RID: 4801
	[Token(Token = "0x20012C1")]
	public class AuchanAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001725")]
		protected override string Theme
		{
			[Token(Token = "0x6007203")]
			[Address(RVA = "0xBC0C", Offset = "0xBC0C", VA = "0xBC0C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007204")]
		[Address(RVA = "0xBC0D", Offset = "0xBC0D", VA = "0xBC0D", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AuchanAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5955e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuchanAnalyticsListener_AuchanBuyArtifactEvent__);
		    DAT_ram_00a5955e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x74);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuchanAnalyticsListener_AuchanBuyArtifactEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_AuchanScope_AuchanEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_AuchanScope_AuchanEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
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

		// Token: 0x06007205 RID: 29189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007205")]
		[Address(RVA = "0xBC0E", Offset = "0xBC0E", VA = "0xBC0E", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AuchanAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a5955f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19945);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27379);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20805);
		    DAT_ram_00a5955f = '\x01';
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
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x10) + 0xc);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_19944,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = Core_Extensions_Dict_DictExt__GetArtikul
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x10),0);
		  func_ii_2946(param1_00,StringLiteral_19945,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar4 = **(int **)(param2 + 0x10);
		  local_8 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf8) * 4))
		                      (*(int **)(param2 + 0x10),*(undefined4 *)(iVar4 + 0xfc));
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27379,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = func_ii_7954(*(undefined4 *)(param2 + 0x10),0);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (0,param1_00,uVar1,StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_20805;
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81028925;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81028925:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,uVar1,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007206 RID: 29190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007206")]
		[Address(RVA = "0xBC0F", Offset = "0xBC0F", VA = "0xBC0F")]
		private void AuchanBuyArtifactEvent(AuchanScope.AuchanEventArgs e)
		{
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007207")]
		[Address(RVA = "0xBC10", Offset = "0xBC10", VA = "0xBC10")]
		public AuchanAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_AuchanAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59560 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20014);
		    DAT_ram_00a59560 = '\x01';
		  }
		  return StringLiteral_20014;
		}
		*/

		}

		// Token: 0x04003BBF RID: 15295
		[Token(Token = "0x4003BBF")]
		private const string BUY_ARTIFACT = "buy_artifact";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AuchanAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5955d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuchanAnalyticsListener_AuchanBuyArtifactEvent__);
		    DAT_ram_00a5955d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x74);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuchanAnalyticsListener_AuchanBuyArtifactEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_AuchanScope_AuchanEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_AuchanScope_AuchanEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_AuchanScope_AuchanEventArgs__TypeInfo);
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
