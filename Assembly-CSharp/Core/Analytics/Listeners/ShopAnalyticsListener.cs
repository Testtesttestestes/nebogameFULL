using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DE RID: 4830
	[Token(Token = "0x20012DE")]
	public class ShopAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001742")]
		protected override string Theme
		{
			[Token(Token = "0x60072EA")]
			[Address(RVA = "0xBCF3", Offset = "0xBCF3", VA = "0xBCF3", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0xBCF4", Offset = "0xBCF4", VA = "0xBCF4", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_ShopAnalyticsListener__Init(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59627 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19945);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19943);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20805);
		    DAT_ram_00a59627 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x10) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_19944,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = Core_Extensions_Dict_DictExt__GetArtikul
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x10),0);
		  func_ii_2946(param1_00,StringLiteral_19945,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = func_ii_7957(*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_19943,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = Core_Data_ArtifactData__get_IsTemporaryWithExpiredLifetime
		                    (*(undefined4 *)(param2 + 0x10),0);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,uVar2,StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_20805;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103e6bd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103e6bd:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0xBCF5", Offset = "0xBCF5", VA = "0xBCF5")]
		private void BuyShopArtifactEvent(ShopScope.ShopEventArgs e)
		{
		/* --- GHIDRA: BuyShopArtifactEvent ---
		void Core_Analytics_Listeners_ShopAnalyticsListener__BuyShopArtifactEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59628 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ShopScope_ShopEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ShopAnalyticsListener_BuyShopArtifactEvent__);
		    DAT_ram_00a59628 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x68);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ShopScope_ShopEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ShopAnalyticsListener_BuyShopArtifactEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_ShopScope_ShopEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ShopScope_ShopEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ShopScope_ShopEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ShopScope_ShopEventArgs__TypeInfo);
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

		// Token: 0x060072ED RID: 29421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072ED")]
		[Address(RVA = "0xBCF6", Offset = "0xBCF6", VA = "0xBCF6", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EE")]
		[Address(RVA = "0xBCF7", Offset = "0xBCF7", VA = "0xBCF7")]
		public ShopAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_ShopAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59629 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27294);
		    DAT_ram_00a59629 = '\x01';
		  }
		  return StringLiteral_27294;
		}
		*/

		}

		// Token: 0x04003C2C RID: 15404
		[Token(Token = "0x4003C2C")]
		private const string BUY_SHOP_ARTIFACT = "buy_artifact";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_ShopAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59626 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ShopScope_ShopEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ShopAnalyticsListener_BuyShopArtifactEvent__);
		    DAT_ram_00a59626 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x68);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ShopScope_ShopEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ShopAnalyticsListener_BuyShopArtifactEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_ShopScope_ShopEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ShopScope_ShopEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ShopScope_ShopEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ShopScope_ShopEventArgs__TypeInfo);
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
