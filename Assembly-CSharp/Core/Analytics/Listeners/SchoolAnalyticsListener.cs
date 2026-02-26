using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DC RID: 4828
	[Token(Token = "0x20012DC")]
	public class SchoolAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x060072DB RID: 29403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001740")]
		protected override string Theme
		{
			[Token(Token = "0x60072DB")]
			[Address(RVA = "0xBCE4", Offset = "0xBCE4", VA = "0xBCE4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DC")]
		[Address(RVA = "0xBCE5", Offset = "0xBCE5", VA = "0xBCE5", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5961b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_AccelerateLearnEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_CancelLearnEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_StartLearnEvent__);
		    DAT_ram_00a5961b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_SchoolAnalyticsListener_StartLearnEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SchoolAnalyticsListener_AccelerateLearnEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_SchoolAnalyticsListener_CancelLearnEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
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

		// Token: 0x060072DD RID: 29405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DD")]
		[Address(RVA = "0xBCE6", Offset = "0xBCE6", VA = "0xBCE6", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__Deinit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5961c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21042);
		    DAT_ram_00a5961c = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_SchoolAnalyticsListener__StartLearnEvent(param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_21042;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103d7e4;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103d7e4:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072DE RID: 29406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DE")]
		[Address(RVA = "0xBCE7", Offset = "0xBCE7", VA = "0xBCE7")]
		private void CancelLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		/* --- GHIDRA: CancelLearnEvent ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__CancelLearnEvent
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
		  if (DAT_ram_00a5961d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26576);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19666);
		    DAT_ram_00a5961d = '\x01';
		  }
		  local_8 = 0;
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_SchoolAnalyticsListener__StartLearnEvent(0,param2_00,param2,0);
		  lVar8 = *(longlong *)(param2 + 0x18);
		  piVar6 = *(int **)(param2 + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8103d9c6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8103d9c6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar3,0);
		  if (lVar5 != lVar8) {
		    local_8 = *(undefined8 *)(param2 + 0x18);
		    uVar3 = func_ii_8783(&local_8,0);
		    func_ii_2946(param2_00,StringLiteral_26576,uVar3,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  piVar6 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_19666;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x8103dab2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103dab2:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar4,uVar3,param2_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DF")]
		[Address(RVA = "0xBCE8", Offset = "0xBCE8", VA = "0xBCE8")]
		private void AccelerateLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		/* --- GHIDRA: AccelerateLearnEvent ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__AccelerateLearnEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5961e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27417);
		    DAT_ram_00a5961e = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_SchoolAnalyticsListener__StartLearnEvent(param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27417;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103dba0;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103dba0:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E0")]
		[Address(RVA = "0xBCE9", Offset = "0xBCE9", VA = "0xBCE9")]
		private void StartLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		/* --- GHIDRA: StartLearnEvent ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__StartLearnEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5961f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27348);
		    DAT_ram_00a5961f = '\x01';
		  }
		  iVar2 = **(int **)(param3 + 0x10);
		  local_4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                      (*(int **)(param3 + 0x10),*(undefined4 *)(iVar2 + 0xf4));
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param2,StringLiteral_27348,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(param3 + 0x10),0);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param2,StringLiteral_27347,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId
		                    (*(undefined4 *)(*(int *)(param3 + 0x10) + 0xc),0);
		  func_ii_2946(param2,StringLiteral_27349,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E1")]
		[Address(RVA = "0xBCEA", Offset = "0xBCEA", VA = "0xBCEA")]
		private void AppendSpellProperties(Dictionary<string, object> properties, SchoolScope.SchoolEventArgs e)
		{
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E2")]
		[Address(RVA = "0xBCEB", Offset = "0xBCEB", VA = "0xBCEB")]
		public SchoolAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_SchoolAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59620 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27125);
		    DAT_ram_00a59620 = '\x01';
		  }
		  return StringLiteral_27125;
		}
		*/

		}

		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		private const string START_LEARN = "start_learn";

		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		private const string CANCEL_LEARN = "cancel_learn";

		// Token: 0x04003C2A RID: 15402
		[Token(Token = "0x4003C2A")]
		private const string ACCELERATE_LEARN = "accelerate_learn";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_SchoolAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5961a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_AccelerateLearnEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_CancelLearnEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SchoolAnalyticsListener_StartLearnEvent__);
		    DAT_ram_00a5961a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_SchoolAnalyticsListener_StartLearnEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SchoolAnalyticsListener_AccelerateLearnEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x6c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_SchoolAnalyticsListener_CancelLearnEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SchoolScope_SchoolEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SchoolScope_SchoolEventArgs__TypeInfo);
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
