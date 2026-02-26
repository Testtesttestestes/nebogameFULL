using System;
using System.Collections;
using Gameplay.MageSchool.Events;
using Gameplay.School.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.School;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.School.Controller
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	public class SchoolController : AbstractController<SchoolModel, Gameplay.MageSchool.Events.SchoolEvents>
	{
		// Token: 0x06002706 RID: 9990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x783A", Offset = "0x783A", VA = "0x783A", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <OnSchoolInfoLoaded>b__22_1 ---
		void Gameplay_School_Controller_SchoolController___OnSchoolInfoLoaded_b__22_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a06a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolController___c_TypeInfo);
		    DAT_ram_00a5a06a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_School_Controller_SchoolController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_School_Controller_SchoolController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a05a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_SchoolModel__SchoolEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SchoolService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a05a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_SchoolModel__SchoolEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SchoolService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar2 = unnamed_function_1417(System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__,0);
		  ServicesNamespace_SchoolService__remove_LearnSpellCanceled(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__,0);
		  ServicesNamespace_SchoolService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__,0);
		  ServicesNamespace_SchoolService__remove_LearnSpellAccelerated(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__,0);
		  ServicesNamespace_SchoolService__remove_LearnSpellFinished(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x783B", Offset = "0x783B", VA = "0x783B")]
		public SchoolController(SchoolModel model, Gameplay.MageSchool.Events.SchoolEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_School_Controller_SchoolController___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  float param2_00;
		  undefined4 param1_00;
		  longlong lVar4;
		  longlong lVar5;
		  ulonglong param1_01;
		  
		  if (DAT_ram_00a5a05b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    DAT_ram_00a5a05b = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x10);
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 8),0);
		  if (lVar5 == lVar4) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    param1_01 = (ulonglong)*(uint *)(param2 + 0x18);
		    if (DAT_ram_00a5a053 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a5a053 = '\x01';
		    }
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(param1_01,0);
		    uVar2 = (undefined4)(param1_01 >> 0x20);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(iVar3 + 0x38) = param1_00;
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x24);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x783C", Offset = "0x783C", VA = "0x783C")]
		private void OnLearnSpellStartedEvent(ProtoLearnSpellStartedEvt msg)
		{
		/* --- GHIDRA: OnLearnSpellStartedEvent ---
		void Gameplay_School_Controller_SchoolController__OnLearnSpellStartedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  float param2_00;
		  undefined4 param1_00;
		  longlong lVar4;
		  longlong lVar5;
		  ulonglong param1_01;
		  
		  if (DAT_ram_00a5a05c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    DAT_ram_00a5a05c = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x10);
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 8),0);
		  if (lVar5 == lVar4) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    param1_01 = (ulonglong)*(uint *)(param2 + 0x18);
		    if (DAT_ram_00a5a053 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a5a053 = '\x01';
		    }
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(param1_01,0);
		    uVar2 = (undefined4)(param1_01 >> 0x20);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(iVar3 + 0x38) = param1_00;
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x24);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x783D", Offset = "0x783D", VA = "0x783D")]
		private void OnLearnSpellAcceleratedEvent(ProtoLearnSpellAcceleratedEvt msg)
		{
		/* --- GHIDRA: OnLearnSpellAcceleratedEvent ---
		void Gameplay_School_Controller_SchoolController__OnLearnSpellAcceleratedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  longlong lVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  longlong lVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a05d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__set_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    DAT_ram_00a5a05d = '\x01';
		  }
		  lVar6 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 8),0);
		  if (lVar6 == lVar3) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    iVar4 = *(int *)(iVar1 + 0x34);
		    iVar1 = *(int *)(iVar1 + 0x30);
		    *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar1 + 0xc);
		    uVar5 = *(undefined4 *)(iVar1 + 0x10);
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    *(undefined4 *)(iVar4 + 0x10) = uVar5;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a5a050 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a5a050 = '\x01';
		    }
		    param1_00 = *(int **)(iVar1 + 0x10);
		    iVar1 = *param1_00;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0xd0);
		          goto code_r0x811bacb5;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811bacb5:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar1 = unnamed_function_1417(Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    Gameplay_School_Model_SchoolSpellData__get_PriceCoef(iVar1,iVar4,uVar5,iVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(param2 + 0xc),iVar1,
		               Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__set_Item__);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc),iVar1,
		               Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__set_Item__);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(iVar4 + 0x20);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(param2 + 0xc),
		                 *(undefined4 *)(iVar4 + 0x14));
		    }
		    lVar6 = *(longlong *)(param2 + 0x10);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x14),0);
		    if (lVar6 == lVar3) {
		      Gameplay_School_Controller_SchoolController__OnLearnSpellFinishedEvent(iVar1,iVar1,iVar1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x783E", Offset = "0x783E", VA = "0x783E")]
		private void OnLearnSpellFinishedEvent(ProtoLearnSpellFinishedEvt msg)
		{
		/* --- GHIDRA: OnLearnSpellFinishedEvent ---
		void Gameplay_School_Controller_SchoolController__OnLearnSpellFinishedEvent
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a05e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13884);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a05e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13884,1,0,1,0,0,0,0);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2[3],0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_27734,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xf4));
		  uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_25096,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,uVar2,0);
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		  uVar1 = UI_Toast_ToastController_ToastData__Create(9,uVar1,param2,0);
		  UI_Toast_ToastController__OnReleaseToast(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x783F", Offset = "0x783F", VA = "0x783F")]
		private void ShowCompleteLearnSpellToast(SchoolSpellData spellData)
		{
		/* --- GHIDRA: ShowCompleteLearnSpellToast ---
		void Gameplay_School_Controller_SchoolController__ShowCompleteLearnSpellToast
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  float param2_00;
		  undefined4 param1_00;
		  longlong lVar4;
		  longlong lVar5;
		  
		  if (DAT_ram_00a5a05f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    DAT_ram_00a5a05f = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x10);
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 8),0);
		  if (lVar5 == lVar4) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    if (DAT_ram_00a5a053 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a5a053 = '\x01';
		    }
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    uVar2 = 0;
		    param2_00 = func_ii_7331(0,0);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(iVar3 + 0x38) = param1_00;
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x18);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x24);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x7840", Offset = "0x7840", VA = "0x7840")]
		private void OnLearnSpellCanceledEvent(ProtoLearnSpellCanceledEvt msg)
		{
		/* --- GHIDRA: OnLearnSpellCanceledEvent ---
		void Gameplay_School_Controller_SchoolController__OnLearnSpellCanceledEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a060 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_HandleStartLearnSpellService__);
		    DAT_ram_00a5a060 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(byte *)(iVar1 + 0x18) & 1) == 0) {
		    uVar2 = ServicesNamespace_SchoolService__GetUserSpells(param1[6],param2,0);
		    local_4 = param2;
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_School_Controller_SchoolController_HandleStartLearnSpellService__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x18) = *(int *)(iVar1 + 0x18) + 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x7841", Offset = "0x7841", VA = "0x7841")]
		public void LearnSpell(uint selectedSpell)
		{
		/* --- GHIDRA: LearnSpell ---
		void Gameplay_School_Controller_SchoolController__LearnSpell
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined8 param5;
		  int *piVar6;
		  int *param1_00;
		  undefined4 uVar7;
		  int *param1_01;
		  undefined4 uVar8;
		  undefined4 param5_00;
		  undefined4 param4;
		  uint uVar9;
		  
		  if (DAT_ram_00a5a061 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors__ExpectedBillingErrors__ExpectedSchoolErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoStartLearnSpellAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		    DAT_ram_00a5a061 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x18) = *(int *)(iVar1 + 0x18) + -1;
		  piVar6 = *(int **)(param2 + 0xc);
		  if (piVar6 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar6 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		    System_Activator__CreateInstance(piVar6,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  puVar2 = (undefined4 *)func_ii_15774(piVar6);
		  uVar7 = *puVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar1 + 0x20),uVar7,
		                             Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *param1_01;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x160);
		        goto code_r0x811bb2bf;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x811bb2bf:
		  uVar7 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		                    (uVar7,*(undefined4 *)(piVar6[0xc] + 0x2c),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar4 + 8);
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x110) * 4))
		                    (piVar6,*(undefined4 *)(*piVar6 + 0x114));
		  param5_00 = *(undefined4 *)(iVar1 + 0x14);
		  param4 = *(undefined4 *)(iVar1 + 0x18);
		  uVar5 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                    );
		  Unity_Services_Core_Internal_DependencyTree___ctor(uVar5,uVar8,uVar7,param4,param5_00,0);
		  if ((param1_00 != (int *)0x0) && (Protocol_School_ProtoStartLearnSpellAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_School_ProtoStartLearnSpellAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		                    (param1_00[3],uVar5,0,uVar5,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors__ExpectedBillingErrors__ExpectedSchoolErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x6c) + 8);
		    if (iVar1 != 0) {
		      uVar7 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar8 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                         (*(undefined4 *)(iVar4 + 8),0);
		      uVar5 = unnamed_function_1417(Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		      Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId(uVar5,uVar7,uVar8,piVar6,param5,0)
		      ;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar5,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x7842", Offset = "0x7842", VA = "0x7842")]
		private void HandleStartLearnSpellService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleStartLearnSpellService ---
		undefined4
		Gameplay_School_Controller_SchoolController__HandleStartLearnSpellService
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  float fVar3;
		  undefined4 uVar4;
		  undefined8 param3_00;
		  int iVar5;
		  undefined4 local_8;
		  int local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a062 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolController_HandleAccelerateLearnSpellService__
		              );
		    DAT_ram_00a5a062 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(iVar2 + 0x20),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    fVar3 = func_ii_7103(*(undefined4 *)(local_4 + 0x38),0);
		    fVar3 = CEIL(fVar3);
		    if (fVar3 < 4.2949673e+09 && 0.0 <= fVar3) {
		      iVar2 = (int)fVar3;
		    }
		    else {
		      iVar2 = 0;
		    }
		    if (ABS(fVar3) < 2.1474836e+09) {
		      iVar5 = (int)fVar3;
		    }
		    else {
		      iVar5 = -0x80000000;
		    }
		    if (0.0 <= fVar3) {
		      iVar5 = iVar2;
		    }
		    if (iVar5 != 0) {
		      iVar5 = param1[6];
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                            (*(undefined4 *)(iVar2 + 8),0);
		      uVar1 = ServicesNamespace_SchoolService__CancelLearnSpell(iVar5,param2,param3_00,0);
		      local_8 = param2;
		      uVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		      uVar1 = DG_Tweening_TweenParams__SetId
		                        (uVar1,uVar4,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		      uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_School_Controller_SchoolController_HandleAccelerateLearnSpellService__
		                 ,0);
		      uVar1 = ServicesNamespace_MainService__GetUserStats
		                        (uVar1,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		      Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		      uVar1 = 1;
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x7843", Offset = "0x7843", VA = "0x7843")]
		public bool TryAccelerateSpell(uint spellId)
		{
		/* --- GHIDRA: TryAccelerateSpell ---
		void Gameplay_School_Controller_SchoolController__TryAccelerateSpell
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined4 param1_00;
		  undefined8 param5;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a063 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoAccelerateLearnSpellAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		    DAT_ram_00a5a063 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_School_ProtoAccelerateLearnSpellAns_TypeInfo != *piVar4))
		  {
		    System_Activator__CreateInstance(piVar4,Protocol_School_ProtoAccelerateLearnSpellAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar4 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(piVar4,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined4 *)func_ii_15774(piVar4);
		    uVar5 = *puVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0x20),uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x6c) + 0x10);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                         (*(undefined4 *)(iVar3 + 8),0);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		      Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                (param1_00,param2_00,param3_00,uVar5,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x7844", Offset = "0x7844", VA = "0x7844")]
		private void HandleAccelerateLearnSpellService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleAccelerateLearnSpellService ---
		void Gameplay_School_Controller_SchoolController__HandleAccelerateLearnSpellService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a064 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_School_Controller_SchoolController_Handler__);
		    DAT_ram_00a5a064 = '\x01';
		  }
		  uVar1 = ServicesNamespace_SchoolService__StartLearnSpell(*(undefined4 *)(param1 + 0x18),param2,0);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_School_Controller_SchoolController_Handler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x7845", Offset = "0x7845", VA = "0x7845")]
		public void CancelSpell(uint selectedSpell)
		{
		/* --- GHIDRA: CancelSpell ---
		void Gameplay_School_Controller_SchoolController__CancelSpell
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined4 param1_00;
		  undefined8 param5;
		  int *param1_01;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a065 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		    DAT_ram_00a5a065 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (*(int *)(*param1_01 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		      puVar1 = (undefined4 *)func_ii_15774(param1_01);
		      uVar4 = *puVar1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar2 + 0x20),uVar4,
		                         Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                        );
		      iVar2 = System_Uri___ctor(0);
		      iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x6c) + 0xc);
		      if (iVar2 != 0) {
		        param2_00 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        param5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                           (*(undefined4 *)(iVar3 + 8),0);
		        param1_00 = unnamed_function_1417(Core_Events_Scopes_SchoolScope_SchoolEventArgs_TypeInfo);
		        Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                  (param1_00,param2_00,param3_00,uVar4,param5,0);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		      }
		      return;
		    }
		    System_Activator__CreateInstance(param1_01,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x7846", Offset = "0x7846", VA = "0x7846")]
		private void Handler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: Handler ---
		undefined4
		Gameplay_School_Controller_SchoolController__Handler(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  double param2_00;
		  
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0x114));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))(param2,uVar1);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = Protocol_Common_ResourceSet___ctor(uVar2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = Gameplay_School_Model_SchoolModel__set_Spells(uVar2,uVar2);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__Round(uVar2,param2_00,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x7847", Offset = "0x7847", VA = "0x7847")]
		public ResourceSet GetCancelImproveMonetBack(SchoolSpellData spell)
		{
		/* --- GHIDRA: GetCancelImproveMonetBack ---
		void Gameplay_School_Controller_SchoolController__GetCancelImproveMonetBack
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a066 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_Controller_SchoolController__HandleRunCoroutine_d__19_TypeInfo);
		    DAT_ram_00a5a066 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_School_Controller_SchoolController__HandleRunCoroutine_d__19_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x10) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x7848", Offset = "0x7848", VA = "0x7848", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x7849", Offset = "0x7849", VA = "0x7849", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		int Gameplay_School_Controller_SchoolController__HandleStop(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a066 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_Controller_SchoolController__HandleRunCoroutine_d__19_TypeInfo);
		    DAT_ram_00a5a066 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_School_Controller_SchoolController__HandleRunCoroutine_d__19_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x784A", Offset = "0x784A", VA = "0x784A")]
		private IEnumerator HandleRunCoroutine()
		{
			return null;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x784B", Offset = "0x784B", VA = "0x784B")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_School_Controller_SchoolController__ValidateInit(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 param2_00;
		  int param1_02;
		  
		  if (DAT_ram_00a5a067 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnSchoolInfoLoaded__);
		    DAT_ram_00a5a067 = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  param1_00 = ServicesNamespace_SchoolService__AccelerateLearnSpell(param1_02,param2_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnSchoolInfoLoaded__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x784C", Offset = "0x784C", VA = "0x784C")]
		public void GetSchoolInfo()
		{
		/* --- GHIDRA: GetSchoolInfo ---
		void Gameplay_School_Controller_SchoolController__GetSchoolInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int param1_01;
		  undefined4 *puVar3;
		  int param1_02;
		  
		  if (DAT_ram_00a5a068 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ShortSpellInfo__uint__SchoolSpellData___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_SpellModifierInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController__OnSchoolInfoLoaded_b__22_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController___c__OnSchoolInfoLoaded_b__22_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolController___c_TypeInfo);
		    DAT_ram_00a5a068 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_School_ProtoGetSchoolInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (param1_00[4],Method_System_Linq_Enumerable_ToList_SpellModifierInfo___);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = param1_00[3];
		  if (*(int *)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_School_Controller_SchoolController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x5c);
		  param1_02 = puVar3[1];
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_School_Controller_SchoolController___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    param1_02 = unnamed_function_1417(System_Func_ShortSpellInfo__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_02,uVar2,
		               Method_Gameplay_School_Controller_SchoolController___c__OnSchoolInfoLoaded_b__22_0__,
		               0);
		    *(int *)(*(int *)(Gameplay_School_Controller_SchoolController___c_TypeInfo + 0x5c) + 4) =
		         param1_02;
		  }
		  uVar2 = unnamed_function_1417(System_Func_ShortSpellInfo__SchoolSpellData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,
		             Method_Gameplay_School_Controller_SchoolController__OnSchoolInfoLoaded_b__22_1__,0);
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__object__object_
		                    (param1_01,param1_02,uVar2,
		                     Method_System_Linq_Enumerable_ToDictionary_ShortSpellInfo__uint__SchoolSpellData___
		                    );
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x784D", Offset = "0x784D", VA = "0x784D")]
		private void OnSchoolInfoLoaded(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnSchoolInfoLoaded ---
		int * Gameplay_School_Controller_SchoolController__OnSchoolInfoLoaded
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a5a069 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    DAT_ram_00a5a069 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined4 *)(iVar2 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x811bbd0d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811bbd0d:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  piVar6 = (int *)unnamed_function_1417(Gameplay_School_Model_SchoolSpellData_TypeInfo);
		  Gameplay_School_Model_SchoolSpellData__get_PriceCoef(piVar6,param2,uVar4,piVar6);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe8) * 4))
		            (piVar6,uVar5,*(undefined4 *)(*piVar6 + 0xec));
		  return piVar6;
		}
		*/

		}

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x18")]
		private SchoolService _schoolService;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _handleRunCoroutineToken;

		// Token: 0x0200064A RID: 1610
		[Token(Token = "0x200064A")]
		public enum RequestFlag
		{
			// Token: 0x04001562 RID: 5474
			[Token(Token = "0x4001562")]
			UNKNOWN,
			// Token: 0x04001563 RID: 5475
			[Token(Token = "0x4001563")]
			LEARN_SPELL
		}
	}
}
