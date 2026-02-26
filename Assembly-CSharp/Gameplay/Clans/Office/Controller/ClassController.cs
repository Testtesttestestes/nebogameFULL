using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class ClassController : AbstractController<ClassModel, ClassEvents>
	{
		// Token: 0x06003FAF RID: 16303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x8E69", Offset = "0x8E69", VA = "0x8E69")]
		public ClassController(ClassModel model, ClassEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClassController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassController_DollItemsChangedEventHandler__
		              );
		    DAT_ram_00a576a1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(*(int *)(iVar1 + 0x14) + 0x18);
		  param1_00 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoStackableChangesAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClassController_DollItemsChangedEventHandler__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_ProtoStackableChangesAns__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ProtoStackableChangesAns__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x1c) = iVar3;
		  uVar2 = System_Action_ProtoStackableChangesAns__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ProtoStackableChangesAns__TypeInfo);
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

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x8E6A", Offset = "0x8E6A", VA = "0x8E6A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Office_Controller_ClassController__HandleRun(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassController_DollItemsChangedEventHandler__
		              );
		    DAT_ram_00a576a2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(*(int *)(iVar1 + 0x14) + 0x18);
		  param1_00 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoStackableChangesAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClassController_DollItemsChangedEventHandler__,
		             0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_ProtoStackableChangesAns__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ProtoStackableChangesAns__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x1c) = iVar3;
		  uVar2 = System_Action_ProtoStackableChangesAns__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ProtoStackableChangesAns__TypeInfo);
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

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x8E6B", Offset = "0x8E6B", VA = "0x8E6B", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Office_Controller_ClassController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClassModel__GetTabBarData(param1_00,*(undefined4 *)(param2 + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x8E6C", Offset = "0x8E6C", VA = "0x8E6C")]
		private void DollItemsChangedEventHandler(ProtoStackableChangesAns msg)
		{
		/* --- GHIDRA: DollItemsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassController__DollItemsChangedEventHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 param3_00;
		  int param1_02;
		  
		  if (DAT_ram_00a576a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSlotsResultHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a576a3 = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  param1_00 = ServicesNamespace_ColossusService__BuyPartySlot(param1_02,param2,param3_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSlotsResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x8E6D", Offset = "0x8E6D", VA = "0x8E6D")]
		public void GetDollSlots(ulong dollId)
		{
		/* --- GHIDRA: GetDollSlots ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSlots
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a576a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a576a4 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClassModel__GetTabBarData(param1_00,param1_01[4],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x8E6E", Offset = "0x8E6E", VA = "0x8E6E")]
		private void GetDollSlotsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDollSlotsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSlotsResultHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 param2_00;
		  int param1_02;
		  
		  if (DAT_ram_00a576a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSkillsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a576a5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(iVar1 + 0x2c),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__
		                    );
		  if (*(char *)(iVar1 + 0x10) != '\0') {
		    param1_02 = param1[6];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(iVar1 + 8),0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    param1_00 = ServicesNamespace_ColossusService__FromGolemToDoll(param1_02,param2_00,iVar1,0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSkillsResultHandler__,
		               0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x8E6F", Offset = "0x8E6F", VA = "0x8E6F")]
		public void GetDollSkills(ulong dollId)
		{
		/* --- GHIDRA: GetDollSkills ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSkills
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a576a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetDollsSkillsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDollsSkillsAns_Types_DollSkills__get_Item__
		              );
		    DAT_ram_00a576a6 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Colossus_ProtoGetDollsSkillsAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoGetDollsSkillsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (param1_00[3],0,
		                     Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDollsSkillsAns_Types_DollSkills__get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(undefined8 *)(iVar2 + 0x10);
		  iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(iVar3 + 0x2c),param2_00,
		                     Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__
		                    );
		  param1_01 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar4 = Core_Extensions_Dict_ProtoCastExt__ToUserInfo(*(undefined4 *)(iVar2 + 0x18),0);
		  Core_Data_UserData__get_SkillsData(param1_01,uVar4,0);
		  uVar4 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 8) + 0x44) + 0x18),0);
		  *(undefined1 *)(iVar3 + 0x10) = 0;
		  *(undefined4 *)(iVar3 + 0xc) = uVar4;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		  iVar3 = *(int *)(iVar3 + 0x20);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined8 *)(iVar2 + 0x10),
		               *(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x8E70", Offset = "0x8E70", VA = "0x8E70")]
		private void GetDollSkillsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDollSkillsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSkillsResultHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a576a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSpellsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a576a7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (*(undefined4 *)(iVar1 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = ServicesNamespace_ColossusService__BuyTreasuryItem(param1[6],param2,0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassController_GetDollSpellsResultHandler__,
		               0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_8 = param2;
		    uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    DG_Tweening_TweenParams__SetId
		              (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x8E71", Offset = "0x8E71", VA = "0x8E71")]
		public void GetDollSpells(ulong dollId)
		{
		/* --- GHIDRA: GetDollSpells ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSpells
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined8 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined8 param3_00;
		  
		  if (DAT_ram_00a576a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    DAT_ram_00a576a8 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_School_ProtoGetSchoolInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    puVar1 = (undefined8 *)func_ii_15774(param1_02);
		    param3_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Clans_Office_Model_ClassModel__ParseSlotChanges(param1_00,param1_01,param3_00,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x8E72", Offset = "0x8E72", VA = "0x8E72")]
		private void GetDollSpellsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDollSpellsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClassController__GetDollSpellsResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a576a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView___ctor__
		              );
		    DAT_ram_00a576a9 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
