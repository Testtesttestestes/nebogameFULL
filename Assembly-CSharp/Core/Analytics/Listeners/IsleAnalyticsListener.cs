using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D5 RID: 4821
	[Token(Token = "0x20012D5")]
	public class IsleAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001739")]
		protected override string Theme
		{
			[Token(Token = "0x600729C")]
			[Address(RVA = "0xBCA5", Offset = "0xBCA5", VA = "0xBCA5", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729D")]
		[Address(RVA = "0xBCA6", Offset = "0xBCA6", VA = "0xBCA6", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_AccelerateBuildEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_CancelBuildEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleAnimationButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleBonusCollectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_StartBuildEvent__);
		    DAT_ram_00a595e2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleBonusCollectedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_IsleBonusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_IsleScope_IsleBonusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleAnimationButtonClickEvent__,0
		            );
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_IsleAnalyticsListener_StartBuildEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_IsleAnalyticsListener_CancelBuildEvent__,0
		            );
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_AccelerateBuildEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
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

		// Token: 0x0600729E RID: 29342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729E")]
		[Address(RVA = "0xBCA7", Offset = "0xBCA7", VA = "0xBCA7", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  int *piVar6;
		  int iVar7;
		  longlong lVar8;
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a595e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24826);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19665);
		    DAT_ram_00a595e3 = '\x01';
		  }
		  local_8 = 0;
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_IsleAnalyticsListener__StartBuildEvent(0,param2_00,param2,0);
		  lVar8 = *(longlong *)(param2 + 0x18);
		  piVar6 = *(int **)(param2 + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x810373fa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x810373fa:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar3,0);
		  if (lVar5 != lVar8) {
		    local_8 = *(undefined8 *)(param2 + 0x18);
		    uVar3 = func_ii_8783(&local_8,0);
		    func_ii_2946(param2_00,StringLiteral_24826,uVar3,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  piVar6 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_19665;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x810374e6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810374e6:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar4,uVar3,param2_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729F")]
		[Address(RVA = "0xBCA8", Offset = "0xBCA8", VA = "0xBCA8")]
		private void AccelerateBuildEvent(IsleScope.BuildingEventArgs e)
		{
		/* --- GHIDRA: AccelerateBuildEvent ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__AccelerateBuildEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21041);
		    DAT_ram_00a595e4 = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_IsleAnalyticsListener__StartBuildEvent(param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_21041;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81037744;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81037744:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0xBCA9", Offset = "0xBCA9", VA = "0xBCA9")]
		private void CancelBuildEvent(IsleScope.BuildingEventArgs e)
		{
		/* --- GHIDRA: CancelBuildEvent ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__CancelBuildEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27413);
		    DAT_ram_00a595e5 = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_IsleAnalyticsListener__StartBuildEvent(param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27413;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103782b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103782b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A1")]
		[Address(RVA = "0xBCAA", Offset = "0xBCAA", VA = "0xBCAA")]
		private void StartBuildEvent(IsleScope.BuildingEventArgs e)
		{
		/* --- GHIDRA: StartBuildEvent ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__StartBuildEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20791);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20792);
		    DAT_ram_00a595e6 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param3 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param2,StringLiteral_20792,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(param3 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param2,StringLiteral_20790,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_00 = *(int **)(param3 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81037621;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81037621:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetIsleInfoDicByUserId
		                    (uVar2,*(undefined4 *)(param3 + 0x10),0);
		  uVar2 = Core_Extensions_Dict_TutorialUIPointerDicExt__GetView(uVar2,0);
		  func_ii_2946(param2,StringLiteral_20791,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A2")]
		[Address(RVA = "0xBCAB", Offset = "0xBCAB", VA = "0xBCAB")]
		private void AppendBuildingProperties(Dictionary<string, object> properties, IsleScope.BuildingEventArgs e)
		{
		/* --- GHIDRA: AppendBuildingProperties ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__AppendBuildingProperties
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24824);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19831);
		    DAT_ram_00a595e7 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_19831,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8103793d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8103793d:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar6 = Core_Extensions_Dict_DictExt__GetTournamentDic(uVar2,*(undefined4 *)(param2 + 0x10),0);
		  if (iVar6 != 0) {
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (param1,param1_00,*(undefined4 *)(iVar6 + 0x10),StringLiteral_26155,0);
		  }
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_24824;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81037a15;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81037a15:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,uVar2,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A3")]
		[Address(RVA = "0xBCAC", Offset = "0xBCAC", VA = "0xBCAC")]
		private void IsleAnimationButtonClickEvent(IsleScope.IsleAnimationButtonClickEventArgs e)
		{
		/* --- GHIDRA: IsleAnimationButtonClickEvent ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__IsleAnimationButtonClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int *param1_01;
		  undefined8 uVar7;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26441);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25965);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24825);
		    DAT_ram_00a595e8 = '\x01';
		  }
		  iVar3 = System_Collections_Generic_HashSet_ulong___Clear
		                    (param1[4],*(undefined8 *)(param2 + 0x18),
		                     Method_System_Collections_Generic_HashSet_ulong__Contains__);
		  if (iVar3 == 0) {
		    uVar1 = 0;
		    uVar7 = *(undefined8 *)(param2 + 0x18);
		    func_ii_6873(param1[4],uVar7,Method_System_Collections_Generic_HashSet_ulong__Add__);
		    uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		    local_8 = *(undefined8 *)(param2 + 0x18);
		    uVar4 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    func_ii_2946(param1_00,StringLiteral_25965,uVar4,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__GetTs
		                      (param1,*(undefined4 *)(param2 + 0x10),0);
		    func_ii_2946(param1_00,StringLiteral_26441,uVar4,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    param1_01 = (int *)param1[2];
		    uVar7 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0xec));
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,uVar7);
		    uVar2 = StringLiteral_24825;
		    uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		          goto code_r0x81037bb5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81037bb5:
		    (**(code **)((ulonglong)*puVar6 * 4))(param1_01,CONCAT44(uVar4,uVar5),uVar2,param1_00,puVar6[1])
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A4")]
		[Address(RVA = "0xBCAD", Offset = "0xBCAD", VA = "0xBCAD")]
		private void IsleBonusCollectedEvent(IsleScope.IsleBonusEventArgs e)
		{
		/* --- GHIDRA: IsleBonusCollectedEvent ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__IsleBonusCollectedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_ulong__TypeInfo);
		    DAT_ram_00a595e9 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_ulong__TypeInfo);
		  System_Collections_Generic_HashSet_uint___get_Count
		            (param1_00,Method_System_Collections_Generic_HashSet_ulong___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A5")]
		[Address(RVA = "0xBCAE", Offset = "0xBCAE", VA = "0xBCAE")]
		public IsleAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_IsleAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595ea == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25260);
		    DAT_ram_00a595ea = '\x01';
		  }
		  return StringLiteral_25260;
		}
		*/

		}

		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		private const string ISLE_BONUS_COLLECTED = "isle_bonus_collected";

		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		private const string ISLE_ANIMATION_BUTTON_CLICK = "isle_animation_button_click";

		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		private const string START_BUILD = "start_build";

		// Token: 0x04003C0D RID: 15373
		[Token(Token = "0x4003C0D")]
		private const string CANCEL_BUILD = "cancel_build";

		// Token: 0x04003C0E RID: 15374
		[Token(Token = "0x4003C0E")]
		private const string ACCELERATE_BUILD = "accelerate_build";

		// Token: 0x04003C0F RID: 15375
		[Token(Token = "0x4003C0F")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<ulong> _loggedCollectBonusOwners;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_IsleAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_AccelerateBuildEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_CancelBuildEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleAnimationButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleBonusCollectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_IsleAnalyticsListener_StartBuildEvent__);
		    DAT_ram_00a595e1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleBonusCollectedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_IsleBonusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_IsleScope_IsleBonusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_IsleBonusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_IsleAnimationButtonClickEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_IsleAnimationButtonClickEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_IsleAnalyticsListener_StartBuildEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_IsleAnalyticsListener_CancelBuildEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x3c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_IsleAnalyticsListener_AccelerateBuildEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_IsleScope_BuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IsleScope_BuildingEventArgs__TypeInfo);
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
