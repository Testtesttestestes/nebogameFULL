using System;
using Gameplay.Antiq.Model;
using Gameplay.Antiq.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x2000D9D")]
	internal class GroupReviewViewMediator : AbstractCozyViewMediator<AntiqModel, AntiqEvents, AntiqController, GroupReviewView>
	{
		// Token: 0x06005533 RID: 21811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005533")]
		[Address(RVA = "0xA2D4", Offset = "0xA2D4", VA = "0xA2D4")]
		public GroupReviewViewMediator(GroupReviewView view, AntiqModel model, AntiqEvents events, AntiqController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58818 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentArtifactChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentGroupChangedEvent__
		              );
		    DAT_ram_00a58818 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_GroupData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentGroupChangedEvent__,
		             0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_GroupData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GroupData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x1c) = iVar3;
		    uVar1 = System_Action_GroupData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GroupData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentArtifactChangedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_ArtifactData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_ArtifactData__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_ArtifactData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ArtifactData__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005534")]
		[Address(RVA = "0xA2D5", Offset = "0xA2D5", VA = "0xA2D5", Slot = "21")]
		protected override void ResetEvents(AntiqEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58819 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentArtifactChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentGroupChangedEvent__
		              );
		    DAT_ram_00a58819 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_GroupData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentGroupChangedEvent__,
		             0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_GroupData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GroupData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x1c) = iVar3;
		    uVar1 = System_Action_GroupData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GroupData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleCurrentArtifactChangedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_ArtifactData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_ArtifactData__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_ArtifactData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ArtifactData__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005535")]
		[Address(RVA = "0xA2D6", Offset = "0xA2D6", VA = "0xA2D6", Slot = "22")]
		protected override void SetupEvents(AntiqEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5881a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListBack__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListBack__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListNext__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5881a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListBack__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0xc) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListNext__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 8) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListBack__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListNext__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005536")]
		[Address(RVA = "0xA2D7", Offset = "0xA2D7", VA = "0xA2D7", Slot = "23")]
		protected override void ResetView(GroupReviewView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5881b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListBack__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListBack__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListNext__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5881b = '\x01';
		  }
		  uVar1 = Gameplay_Antiq_Model_AntiqModel___ctor(*(undefined4 *)(param1 + 8),0);
		  param2_00 = Gameplay_Antiq_Model_AntiqModel__GetIsGroupsScrollEnabled
		                        (*(undefined4 *)(param1 + 8),0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListBack__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0xc) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleGroupListNext__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 8) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListBack__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupReviewViewMediator_HandleArtifactListNext__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  Gameplay_Antiq_Control_GroupReviewViewMediator__HandleGroupListBack
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x28),param1);
		  Gameplay_Antiq_Control_GroupReviewViewMediator__DisplayGroup
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x2c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005537 RID: 21815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005537")]
		[Address(RVA = "0xA2D8", Offset = "0xA2D8", VA = "0xA2D8", Slot = "24")]
		protected override void SetupView(GroupReviewView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Antiq_Control_GroupReviewViewMediator__HandleGroupListBack(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005538")]
		[Address(RVA = "0xA2D9", Offset = "0xA2D9", VA = "0xA2D9")]
		private void HandleCurrentGroupChangedEvent(GroupData data)
		{
		/* --- GHIDRA: HandleCurrentGroupChangedEvent ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleCurrentGroupChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Antiq_Control_GroupReviewViewMediator__DisplayGroup(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005539")]
		[Address(RVA = "0xA2DA", Offset = "0xA2DA", VA = "0xA2DA")]
		private void HandleCurrentArtifactChangedEvent(ArtifactData data)
		{
		/* --- GHIDRA: HandleCurrentArtifactChangedEvent ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleCurrentArtifactChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5881c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    DAT_ram_00a5881c = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Antiq_Control_AntiqController__SelectGroupBack
		            (param1_00,*(undefined4 *)(param1[2] + 0x2c),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553A")]
		[Address(RVA = "0xA2DB", Offset = "0xA2DB", VA = "0xA2DB")]
		private void HandleArtifactListNext()
		{
		/* --- GHIDRA: HandleArtifactListNext ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleArtifactListNext
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5881d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    DAT_ram_00a5881d = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Antiq_Control_AntiqController__SelectArtifactNext
		            (param1_00,*(undefined4 *)(param1[2] + 0x2c),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553B")]
		[Address(RVA = "0xA2DC", Offset = "0xA2DC", VA = "0xA2DC")]
		private void HandleArtifactListBack()
		{
		/* --- GHIDRA: HandleArtifactListBack ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleArtifactListBack
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5881e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    DAT_ram_00a5881e = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Antiq_Control_AntiqController__SetCurrentArtifact
		            (param1_00,*(undefined4 *)(param1[2] + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553C")]
		[Address(RVA = "0xA2DD", Offset = "0xA2DD", VA = "0xA2DD")]
		private void HandleGroupListNext()
		{
		/* --- GHIDRA: HandleGroupListNext ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleGroupListNext
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5881f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    DAT_ram_00a5881f = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Antiq_Control_AntiqController__SelectGroupNext
		            (param1_00,*(undefined4 *)(param1[2] + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553D")]
		[Address(RVA = "0xA2DE", Offset = "0xA2DE", VA = "0xA2DE")]
		private void HandleGroupListBack()
		{
		/* --- GHIDRA: HandleGroupListBack ---
		void Gameplay_Antiq_Control_GroupReviewViewMediator__HandleGroupListBack
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  undefined8 uVar8;
		  int iVar9;
		  int iVar10;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar8 = 0;
		  if (DAT_ram_00a58820 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2561);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2562);
		    DAT_ram_00a58820 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar5 = *(undefined4 *)(iVar2 + 0x2c);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Core_Extensions_Dict_Antiq_ArtifactDicExt__GetImage(*(undefined4 *)(param2 + 0xc),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar3,0);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x18) + 0x18);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageThumbnailAssetId
		                    (*(undefined4 *)(param2 + 0xc),0);
		  iVar2 = *piVar6;
		  uVar1 = CONCAT44(uVar7,uVar3);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x18) + 0x14);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetTitle(*(undefined4 *)(param2 + 0xc),0)
		  ;
		  iVar2 = *piVar6;
		  uVar1 = CONCAT44(uVar7,uVar3);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar6 = *(int **)(*(int *)(iVar2 + 0x18) + 0xc);
		  if ((*(int *)(param2 + 0x18) != 0) &&
		     (iVar2 = *(int *)(*(int *)(param2 + 0x18) + 0xc), iVar2 != 0)) {
		    uVar8 = *(undefined8 *)(iVar2 + 0x20);
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,uVar8,Method_System_Nullable_ulong___ctor__);
		    uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    uVar8 = local_8;
		  }
		  iVar2 = 0;
		  local_10 = uVar8;
		  uVar3 = func_ii_8783(&local_10,0);
		  iVar9 = *piVar6;
		  uVar8 = CONCAT44(uVar7,uVar3);
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		            (piVar6,uVar8,*(undefined4 *)(iVar9 + 0x2d4));
		  uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  iVar9 = *(int *)(*(int *)(iVar9 + 0x18) + 0x1c);
		  if (0 < *(int *)(iVar9 + 0xc)) {
		    do {
		      piVar6 = *(int **)(iVar9 + iVar2 * 4 + 0x10);
		      local_10 = *(undefined8 *)(*(int *)(param2 + 0xc) + 0x20);
		      uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      uVar3 = func_ii_8783(&local_10,0);
		      iVar10 = *piVar6;
		      uVar8 = CONCAT44(uVar7,uVar3);
		      (**(code **)((ulonglong)*(uint *)(iVar10 + 0x2d0) * 4))
		                (piVar6,uVar8,*(undefined4 *)(iVar10 + 0x2d4));
		      uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar9 + 0xc));
		  }
		  iVar9 = *param1;
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(iVar9 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x20),0);
		  uVar5 = Gameplay_Antiq_View_EffectView__SetData(param2,iVar9);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar5,0);
		  iVar9 = *param1;
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(iVar9 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x24),0);
		  uVar4 = Gameplay_Antiq_View_EffectView__SetData(param2,iVar9);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(int *)(param2 + 0x18) != 0),0);
		  iVar9 = *param1;
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(iVar9 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x18) + 8),0);
		  uVar4 = Gameplay_Antiq_View_EffectView__SetData(param2,iVar9);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  iVar9 = *param1;
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(iVar9 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc),0);
		  uVar4 = Gameplay_Antiq_View_EffectView__SetData(param2,iVar9);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  iVar9 = *param1;
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(iVar9 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 8),0);
		  uVar4 = Gameplay_Antiq_View_EffectView__SetData(param2,iVar9);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  if (*(int *)(param2 + 0x18) != 0) {
		    uVar8 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		    uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    piVar6 = *(int **)(*(int *)(iVar2 + 0x18) + 0x10);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_2561,1,0,1,0,0,0,0);
		    uVar8 = CONCAT44(uVar7,uVar3);
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		              (piVar6,uVar8,*(undefined4 *)(*piVar6 + 0x2d4));
		    uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    iVar2 = Gameplay_Antiq_View_EffectView__SetData(param2,piVar6);
		    if (iVar2 != 0) {
		      uVar8 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		      uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      piVar6 = *(int **)(*(int *)(iVar2 + 0x18) + 0x10);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_2562,1,0,1,0,0,0,0);
		      iVar2 = *piVar6;
		      uVar8 = CONCAT44(uVar7,uVar3);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                (piVar6,uVar8,*(undefined4 *)(iVar2 + 0x2d4));
		      uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    }
		  }
		  uVar8 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  if (DAT_ram_00a587fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__);
		    DAT_ram_00a587fd = '\x01';
		  }
		  uVar4 = System_Collections_ObjectModel_ReadOnlyCollection_ushort___get_Item
		                    (*(undefined4 *)(param2 + 8),*(undefined4 *)(param2 + 0x18),
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                    );
		  Gameplay_Antiq_View_GroupReviewView__get_MaxLevelCounter(uVar3,uVar4 ^ 1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c)));
		  uVar7 = *(undefined4 *)(iVar2 + 0x34);
		  if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		  }
		  UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar7,0);
		  return;
		}
		*/

		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553E")]
		[Address(RVA = "0xA2DF", Offset = "0xA2DF", VA = "0xA2DF")]
		private void DisplayGroup(GroupData data)
		{
		/* --- GHIDRA: DisplayGroup ---
		/* WARNING: Removing unreachable block (ram,0x80f3153b) */
		
		void Gameplay_Antiq_Control_GroupReviewViewMediator__DisplayGroup
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 param2_00;
		  int iVar11;
		  int *piVar12;
		  longlong local_18;
		  int *local_c;
		  undefined8 local_8;
		  
		  iVar11 = 0;
		  if (DAT_ram_00a58821 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupReviewView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_EffectData___);
		    Mono_Security_ASN1__get_Item(&System_Func_EffectData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_EffectData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_GroupReviewViewMediator___c__DisplayClass12_0__DisplayEffect_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Antiq_Control_GroupReviewViewMediator___c__DisplayClass12_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    DAT_ram_00a58821 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar8 = *(int **)(*(int *)(iVar2 + 0x18) + 8);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_10310,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0xc) + 0x20);
		  uVar4 = func_ii_8783(&local_8,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(longlong *)(iVar2 + 0x10) = local_18;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar2,0);
		  iVar2 = *piVar8;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar8,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Antiq_View_GroupReviewView__SetEnableGrayscale(uVar3,0);
		  local_c = (int *)LunarConsolePluginInternal_Iterator___Il2CppFullySharedGenericType___TrySkip
		                             (*(undefined4 *)(param2 + 0x10),
		                              Method_System_Collections_ObjectModel_ReadOnlyCollection_EffectData__GetEnumerator__
		                             );
		  local_18 = ZEXT48(&local_c) << 0x20;
		  do {
		    piVar8 = local_c;
		    iVar2 = *local_c;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar2 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80f31497;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f31857:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		code_r0x80f31497:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f31857;
		    if (iVar2 == 0) {
		      iVar11 = 0;
		      goto code_r0x80f318a8;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Antiq_Control_GroupReviewViewMediator___c__DisplayClass12_0_TypeInfo
		                      );
		    piVar8 = local_c;
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		    iVar9 = *local_c;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_EffectData__TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80f315d6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_Generic_IEnumerator_EffectData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f316be:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		code_r0x80f315d6:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f316be;
		    *(undefined4 *)(iVar2 + 8) = uVar3;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a0,uVar3,0)
		    ;
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		    iVar10 = *(int *)(*(int *)(param1[2] + 0x28) + 0x18);
		    iVar9 = iVar10;
		    if (iVar10 == 0) {
		      iVar9 = iVar11;
		    }
		    iVar11 = iVar9;
		    uVar4 = *(undefined4 *)(iVar2 + 8);
		    if (iVar10 != 0) {
		      param2_00 = *(undefined4 *)(iVar11 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_EffectData__bool__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar6,iVar2,
		                   Method_Gameplay_Antiq_Control_GroupReviewViewMediator___c__DisplayClass12_0__DisplayEffect_b__0__
		                   ,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33e,param2_00,uVar6
		                             ,Method_System_Linq_Enumerable_Single_EffectData___);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) goto code_r0x80f31788;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f3185f;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		    uVar6 = 0;
		code_r0x80f31788:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a1,uVar3,uVar4,uVar6,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3185f;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a2,
		                       *(undefined4 *)(param1[2] + 0x28),*(undefined4 *)(param1[2] + 0x28));
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a3,uVar3,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3185f:
		  iVar11 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar2) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar11 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_18 = CONCAT44(local_18._4_4_,iVar11);
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80f318a8:
		      piVar8 = local_c;
		      DAT_ram_009d3e38 = 0;
		      if (local_c != (int *)0x0) {
		        uVar1 = 0;
		        iVar2 = *local_c;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f31920;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x80f31920:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar8,puVar7[1]);
		      }
		      if (iVar11 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a4,&local_18);
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553F")]
		[Address(RVA = "0xA2E0", Offset = "0xA2E0", VA = "0xA2E0")]
		private void DisplayEffect(ArtifactData artifact)
		{
		}
	}
}
