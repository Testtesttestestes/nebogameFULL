using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using UI.Rewards.Renderers;

namespace Gameplay.ArtifactDrop.Control
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public class ArtifactDropViewMediator : AbstractViewMediator<ArtifactDropModel, ArtifactDropEvents, ArtifactDropController, ArtifactRewardRender>
	{
		// Token: 0x06004FDA RID: 20442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x9DF3", Offset = "0x9DF3", VA = "0x9DF3")]
		public ArtifactDropViewMediator(ArtifactDropModel model, ArtifactDropEvents events, ArtifactDropController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a589fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnDropResetEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnReadyDropEvent__
		              );
		    DAT_ram_00a589fa = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnDropResetEvent__,
		             0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar4;
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnReadyDropEvent__,
		             0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnArtifactDropRemoveEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x1c) = iVar4;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x9DF4", Offset = "0x9DF4", VA = "0x9DF4", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a589fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__get_Item__);
		    DAT_ram_00a589fb = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(iVar2 + 0xc),0,
		                             Method_System_Collections_Generic_List_object__get_Item__);
		  if (piVar1 != (int *)0x0) {
		    if (*(int *)(*piVar1 + 0x20) == *(int *)(Protocol_Main_DropTypes_TypeInfo + 0x20)) {
		      puVar3 = (undefined4 *)func_ii_15774(piVar1);
		      return *puVar3;
		    }
		    System_Activator__CreateInstance(piVar1,Protocol_Main_DropTypes_TypeInfo);
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x17001029")]
		public DropTypes DropType
		{
			[Token(Token = "0x6004FDC")]
			[Address(RVA = "0x9DF5", Offset = "0x9DF5", VA = "0x9DF5")]
			get
			{
				return DropTypes.UnknownDropType;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102A")]
		public override ArtifactRewardRender View
		{
			[Token(Token = "0x6004FDD")]
			[Address(RVA = "0x9DF6", Offset = "0x9DF6", VA = "0x9DF6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x9DF7", Offset = "0x9DF7", VA = "0x9DF7")]
		private void HandleViewChanged()
		{
		/* --- GHIDRA: HandleViewChanged ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleViewChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a589fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a589fe = '\x01';
		  }
		  iVar1 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		  if (iVar1 == param2) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = 0x10;
		    if (*(char *)(param1[2] + 0x18) == '\0') {
		      iVar1 = 0xc;
		    }
		    UI_Rewards_Renderers_ArtifactRewardRender__SetArtifacts
		              (uVar2,*(undefined4 *)(param1[2] + iVar1),0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = Com_TheFallenGames_OSA_Util_PullToRefresh_PullToRefreshBehaviour__get_IsVertical
		                      (uVar2,0);
		    uVar3 = *(undefined4 *)(iVar1 + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UI_Rewards_Renderers_ArtifactRewardRender__get_TakeAllBtn(uVar2,0);
		    uVar3 = *(undefined4 *)(iVar1 + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDF")]
		[Address(RVA = "0x9DF8", Offset = "0x9DF8", VA = "0x9DF8")]
		private void HandleOnDropResetEvent(DropTypes dropType)
		{
		/* --- GHIDRA: HandleOnDropResetEvent ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleOnDropResetEvent
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__get_Model__
		              );
		    DAT_ram_00a589ff = '\x01';
		  }
		  iVar1 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		  if (iVar1 == param2) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = 0x10;
		    if (*(char *)(param1[2] + 0x18) == '\0') {
		      iVar1 = 0xc;
		    }
		    UI_Rewards_Renderers_ArtifactRewardRender__RemoveAllAsync
		              (param1_00,param3,*(undefined4 *)(param1[2] + iVar1),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x9DF9", Offset = "0x9DF9", VA = "0x9DF9")]
		private void HandleOnArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifactData)
		{
		/* --- GHIDRA: HandleOnArtifactDropRemoveEvent ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleOnArtifactDropRemoveEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58a00 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnDropResetEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58a00 = '\x01';
		  }
		  iVar1 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		  if (iVar1 == *(int *)(param2 + 8)) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    UI_Rewards_Renderers_ArtifactRewardRender__HandleOnDestroyEvent(uVar2,uVar3,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = Com_TheFallenGames_OSA_Util_PullToRefresh_PullToRefreshBehaviour__get_IsVertical
		                      (uVar2,0);
		    uVar3 = *(undefined4 *)(iVar1 + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UI_Rewards_Renderers_ArtifactRewardRender__get_TakeAllBtn(uVar2,0);
		    uVar3 = *(undefined4 *)(iVar1 + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnDropResetEvent__
		               ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar3,uVar2,0);
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar4,System_Action_DropTypes__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar2 = System_Action_DropTypes__TypeInfo;
		      iVar1 = func_ii_1082(iVar4,System_Action_DropTypes__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		    System_Action_Int32Enum__Int32Enum___Invoke
		              (uVar2,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnArtifactDropRemoveEvent__
		               ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar3,uVar2,0);
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar4,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar4,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x1c) = iVar5;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar1 = func_ii_1082(iVar4,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar4,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x9DFA", Offset = "0x9DFA", VA = "0x9DFA")]
		private void HandleOnReadyDropEvent(ArtifactDropModel.ArtifactDrop drop)
		{
		/* --- GHIDRA: HandleOnReadyDropEvent ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleOnReadyDropEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeAllDrop(param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x9DFB", Offset = "0x9DFB", VA = "0x9DFB")]
		private void HandleClickSellAllBtn()
		{
		/* --- GHIDRA: HandleClickSellAllBtn ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleClickSellAllBtn
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDrop(param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x9DFC", Offset = "0x9DFC", VA = "0x9DFC")]
		private void HandleClickGetAllBtn()
		{
		/* --- GHIDRA: HandleClickGetAllBtn ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__HandleClickGetAllBtn
		               (int param1,undefined4 param2)
		
		{
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  local_20 = *(undefined8 *)(*(int *)(param1 + 0x24) + 0x50);
		  local_8 = 1;
		  local_18 = 1;
		  local_10 = local_20;
		  func_ii_7564(*(int *)(param1 + 0x24),&local_20,0);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DropType ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__get_DropType
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a589fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__get_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactDropModel__ArtifactDropEvents__ArtifactDropController__ArtifactRewardRender__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a589fc = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,param2,0);
		  if (iVar2 == 0) {
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[5],0);
		    if (iVar2 != 0) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = Com_TheFallenGames_OSA_Util_PullToRefresh_PullToRefreshBehaviour__get_IsVertical
		                        (uVar1,0);
		      uVar3 = *(undefined4 *)(iVar2 + 0xb4);
		      uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar1,param1,
		                 Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickGetAllBtn__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = UI_Rewards_Renderers_ArtifactRewardRender__get_TakeAllBtn(uVar1,0);
		      uVar3 = *(undefined4 *)(iVar2 + 0xb4);
		      uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar1,param1,
		                 Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleClickSellAllBtn__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    }
		    param1[5] = param2;
		    Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnReadyDropEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Cast_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__GetRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__get_Count__);
		    DAT_ram_00a589fd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_HandleOnReadyDropEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar1,0);
		    uVar1 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x14) = iVar4;
		      uVar1 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xf4));
		    iVar3 = *param1;
		    if (*(int *)(*(int *)(iVar2 + 0xc) + 0xc) < 2) {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                                (param1,*(undefined4 *)(iVar3 + 0x14c));
		      uVar1 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		      local_4 = 0;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      if (DAT_ram_00a589da == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                  );
		        DAT_ram_00a589da = '\x01';
		      }
		      iVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                        (*(undefined4 *)(iVar2 + 0x14),uVar1,&local_4,
		                         Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                        );
		      if (iVar2 == 0) {
		        Gameplay_ArtifactDrop_Control_ArtifactDropController__DismantleArtifact(piVar5,uVar1,uVar1);
		      }
		      else {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                          (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x14);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),local_4,*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		    else {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                                (param1,*(undefined4 *)(iVar3 + 0x15c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0xf4));
		      uVar1 = *(undefined4 *)(iVar2 + 0xc);
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0xf4));
		      uVar1 = System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___GetEnumerator
		                        (uVar1,1,*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + -1,
		                         Method_System_Collections_Generic_List_object__GetRange__);
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x14c));
		      uVar6 = Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator__Dispose(param1,param1);
		      uVar1 = System_Linq_Enumerable__Cast_DictionaryEntry_
		                        (uVar1,Method_System_Linq_Enumerable_Cast_ArtifactInfo___);
		      uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		      uVar1 = Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		                        (piVar5,uVar6,uVar1,0,param1);
		      iVar2 = *piVar5;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(iVar2 + 0x104));
		      Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(uVar6,uVar1,iVar2);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

}
