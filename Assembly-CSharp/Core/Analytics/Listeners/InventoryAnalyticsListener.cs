using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D4 RID: 4820
	[Token(Token = "0x20012D4")]
	public class InventoryAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06007296 RID: 29334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001738")]
		protected override string Theme
		{
			[Token(Token = "0x6007296")]
			[Address(RVA = "0xBC9F", Offset = "0xBC9F", VA = "0xBC9F", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007297")]
		[Address(RVA = "0xBCA0", Offset = "0xBCA0", VA = "0xBCA0", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_InventoryAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_InventoryAnalyticsListener_BuySlotEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_InventoryAnalyticsListener_SplitArtifactWthNumpadEvent__
		              );
		    DAT_ram_00a595dd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x40);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_InventoryAnalyticsListener_BuySlotEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_InventoryScope_BuySlotEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_InventoryScope_BuySlotEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x40);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_InventoryAnalyticsListener_SplitArtifactWthNumpadEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
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

		// Token: 0x06007298 RID: 29336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007298")]
		[Address(RVA = "0xBCA1", Offset = "0xBCA1", VA = "0xBCA1", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_InventoryAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28186);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19939);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19940);
		    DAT_ram_00a595de = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  func_ii_2946(param1_00,StringLiteral_19940,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  func_ii_2946(param1_00,StringLiteral_19939,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = *(undefined4 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  func_ii_2946(param1_00,StringLiteral_19795,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  func_ii_2946(param1_00,StringLiteral_28217,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28186;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81036938;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81036938:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007299 RID: 29337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007299")]
		[Address(RVA = "0xBCA2", Offset = "0xBCA2", VA = "0xBCA2")]
		private void SplitArtifactWthNumpadEvent(InventoryScope.UsingNumpadEventArgs e)
		{
		/* --- GHIDRA: SplitArtifactWthNumpadEvent ---
		void Core_Analytics_Listeners_InventoryAnalyticsListener__SplitArtifactWthNumpadEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20808);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22881);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20027);
		    DAT_ram_00a595df = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param2_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param2_00,StringLiteral_21978,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x81036a76;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81036a76:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  local_10 = Gameplay_Inventory_Model_InventoryBaseModel__get_EquipSlotsIds
		                       (*(undefined4 *)(iVar6 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  func_ii_2946(param2_00,StringLiteral_20027,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x81036b31;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81036b31:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  local_18 = Gameplay_Inventory_Model_InventoryBaseModel__get_ChestTotalSlotsNum
		                       (*(undefined4 *)(iVar6 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_18);
		  func_ii_2946(param2_00,StringLiteral_22881,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_20808;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81036c14;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81036c14:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,uVar2,param2_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729A")]
		[Address(RVA = "0xBCA3", Offset = "0xBCA3", VA = "0xBCA3")]
		private void BuySlotEvent(InventoryScope.BuySlotEventArgs e)
		{
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729B")]
		[Address(RVA = "0xBCA4", Offset = "0xBCA4", VA = "0xBCA4")]
		public InventoryAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_InventoryAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_24823);
		    DAT_ram_00a595e0 = '\x01';
		  }
		  return StringLiteral_24823;
		}
		*/

		}

		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		private const string BUY_SLOT = "buy_slot";

		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		private const string USING_NUMPAD = "using_numpad";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_InventoryAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_InventoryAnalyticsListener_BuySlotEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_InventoryAnalyticsListener_SplitArtifactWthNumpadEvent__
		              );
		    DAT_ram_00a595dc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x40);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_InventoryAnalyticsListener_BuySlotEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_InventoryScope_BuySlotEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_InventoryScope_BuySlotEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_InventoryScope_BuySlotEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x40);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_InventoryAnalyticsListener_SplitArtifactWthNumpadEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_InventoryScope_UsingNumpadEventArgs__TypeInfo);
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
