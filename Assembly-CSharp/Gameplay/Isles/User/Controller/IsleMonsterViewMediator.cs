using System;
using Core;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View.Monster;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3A RID: 3386
	[Token(Token = "0x2000D3A")]
	public class IsleMonsterViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterView>
	{
		// Token: 0x060052D6 RID: 21206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0xA0AC", Offset = "0xA0AC", VA = "0xA0AC", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58dcb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView___ctor__
		              );
		    DAT_ram_00a58dcb = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0xA0AD", Offset = "0xA0AD", VA = "0xA0AD")]
		public IsleMonsterViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58dcc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_HandleDisposeEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_IsCurrentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_MonsterChangedEvent__)
		    ;
		    DAT_ram_00a58dcc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_MonsterChangedEvent__,0
		              );
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_HandleDisposeEvent__,0)
		    ;
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_MonsterChangedEvent__,0
		              );
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_HandleDisposeEvent__,0)
		    ;
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010E3 RID: 4323
		// (set) Token: 0x060052D8 RID: 21208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E3")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052D8")]
			[Address(RVA = "0xA0AE", Offset = "0xA0AE", VA = "0xA0AE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0xA0AF", Offset = "0xA0AF", VA = "0xA0AF")]
		private void HandleDisposeEvent()
		{
		/* --- GHIDRA: HandleDisposeEvent ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__HandleDisposeEvent
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Utils_Trackers_AsyncLoadableContentTracker__StartTracking(*(undefined4 *)(param1_00 + 0x38),0);
		  param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_01,0,0);
		  Gameplay_Isles_User_Controller_IsleMonsterViewMediator__MonsterChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0xA0B0", Offset = "0xA0B0", VA = "0xA0B0")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__IsCurrentChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Isles_User_Controller_IsleMonsterViewMediator__MonsterChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DB")]
		[Address(RVA = "0xA0B1", Offset = "0xA0B1", VA = "0xA0B1")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		/* --- GHIDRA: MonsterChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__MonsterChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *param1_00;
		  
		  if (DAT_ram_00a58dcd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a58dcd = '\x01';
		  }
		  cVar1 = *(char *)(param1[2] + 0x2c);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (cVar1 == '\0') {
		    Utils_Trackers_AsyncLoadableContentTracker__StartTracking(*(undefined4 *)(iVar3 + 0x38),0);
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (iVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    return;
		  }
		  if (iVar3 == 0) {
		    return;
		  }
		  if (*(int *)(param1[2] + 0x40) == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(iVar3 + 0x4c) != 0) {
		      func_ii_7950(*(int *)(iVar3 + 0x4c),0);
		    }
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    *(undefined4 *)(iVar3 + 0x4c) = 0;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar3 + 0x24),0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_ToolTip_ToolTip__get_enabled(*(undefined4 *)(iVar3 + 0x34),0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Utils_Trackers_AsyncLoadableContentTracker__StartTracking(*(undefined4 *)(iVar3 + 0x38),0);
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (iVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    return;
		  }
		  iVar3 = Unity_Hierarchy_HierarchySearchQueryDescriptor___c____ctor_b__33_1
		                    (*(int *)(param1[2] + 0x40),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar3 == 0) {
		    Gameplay_Isles_User_View_Monster_IsleMonsterView__remove_ResolveEvent
		              (iVar4,*(undefined4 *)(*(int *)(param1[2] + 0x40) + 0x10),param1);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *(int *)(iVar3 + 0x3c);
		    if (*(int *)(iVar3 + 0x20) == 0) goto code_r0x80fae238;
		    *(undefined4 *)(iVar3 + 0x20) = 0;
		  }
		  else {
		    if (*(int *)(iVar4 + 0x4c) != 0) {
		      func_ii_7950(*(int *)(iVar4 + 0x4c),0);
		    }
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    *(undefined4 *)(iVar4 + 0x4c) = 0;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *(int *)(iVar3 + 0x3c);
		    iVar4 = *(int *)(*(int *)(param1[2] + 0x40) + 0xc);
		    if (*(int *)(iVar3 + 0x20) == iVar4) goto code_r0x80fae238;
		    *(int *)(iVar3 + 0x20) = iVar4;
		  }
		  Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__AnimateShowAvatar(iVar3,param1);
		code_r0x80fae238:
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a58d6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d6f = '\x01';
		  }
		  param1_00 = *(int **)(iVar3 + 0x40);
		  if (param1_00 == (int *)0x0) {
		    param1_00 = (int *)func_ii_5677(iVar3,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		    ;
		  }
		  *(int **)(iVar3 + 0x40) = param1_00;
		  uVar2 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80fae2ff;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4
		                               );
		code_r0x80fae2ff:
		  uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  uVar6 = Unity_Hierarchy_HierarchySearchQueryDescriptor___c____ctor_b__33_1
		                    (*(undefined4 *)(param1[2] + 0x40),0);
		  UnityEngine_Object__op_Implicit(uVar7,uVar6,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar3 + 0x34);
		  uVar7 = Unity_Hierarchy_HierarchySearchQueryDescriptor___c____ctor_b__33_1
		                    (*(undefined4 *)(param1[2] + 0x40),0);
		  UI_ToolTip_ToolTip__get_enabled(uVar6,uVar7,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Utils_Trackers_AsyncLoadableContentTracker__Init(*(undefined4 *)(iVar3 + 0x38),0);
		  return;
		}
		*/

		}

		// Token: 0x060052DC RID: 21212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DC")]
		[Address(RVA = "0xA0B2", Offset = "0xA0B2", VA = "0xA0B2")]
		private void UpdateMonster()
		{
		/* --- GHIDRA: UpdateMonster ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__UpdateMonster
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58dce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_OnMonsterClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_ReadyEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58dce = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,param2,0);
		  if (iVar4 != 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		    if (iVar4 != 0) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_OnMonsterClick__,0);
		      if (DAT_ram_00a58d72 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a58d72 = '\x01';
		      }
		      iVar2 = *(int *)(iVar4 + 0x50);
		      do {
		        piVar5 = (int *)func_ii_7048(iVar2,uVar3,0);
		        if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar4 + 0x50,piVar5,iVar2);
		        bVar1 = iVar6 != iVar2;
		        iVar2 = iVar6;
		      } while (bVar1);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = *(undefined4 *)(iVar4 + 0x38);
		      uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_ReadyEventHandler__,0
		                );
		      Utils_Trackers_AsyncLoadableContentTracker__add_ReadyEvent(uVar7,uVar3,0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x28) = 0;
		      AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar4 + 0x24),0,0);
		    }
		    param1[5] = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		    if (iVar4 != 0) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_OnMonsterClick__,0);
		      if (DAT_ram_00a58d71 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a58d71 = '\x01';
		      }
		      iVar2 = *(int *)(iVar4 + 0x50);
		      do {
		        piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0);
		        if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar4 + 0x50,piVar5,iVar2);
		        bVar1 = iVar6 != iVar2;
		        iVar2 = iVar6;
		      } while (bVar1);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = *(undefined4 *)(iVar4 + 0x38);
		      uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleMonsterViewMediator_ReadyEventHandler__,0
		                );
		      Utils_Uri_UriUtil__GetQueryParams(uVar7,uVar3,0);
		      Gameplay_Isles_User_Controller_IsleMonsterViewMediator__MonsterChangedEvent(param1,uVar7);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010E4 RID: 4324
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E4")]
		public override IsleMonsterView View
		{
			[Token(Token = "0x60052DD")]
			[Address(RVA = "0xA0B3", Offset = "0xA0B3", VA = "0xA0B3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DE")]
		[Address(RVA = "0xA0B4", Offset = "0xA0B4", VA = "0xA0B4")]
		private void ReadyEventHandler(IAsyncLoadableContent content)
		{
		/* --- GHIDRA: ReadyEventHandler ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__ReadyEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  
		  if (DAT_ram_00a58dcf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58dcf = '\x01';
		  }
		  if (((*(char *)(*(int *)(param1 + 8) + 0x18) == '\0') &&
		      (iVar2 = *(int *)(*(int *)(param1 + 8) + 0x40), iVar2 != 0)) &&
		     (iVar2 = Unity_Hierarchy_HierarchySearchQueryDescriptor___c____ctor_b__33_1(iVar2,0),
		     iVar2 != 0)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110)
		          ;
		          goto code_r0x80fae80c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param2_00 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80fae80c:
		    iVar2 = (**(code **)((ulonglong)*param2_00 * 4))
		                      (param1_01,CONCAT44(in_register_20000014,param2_00[1]));
		    param1_00 = Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel
		                          (*(undefined4 *)(iVar2 + 0x14),
		                           *(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		    Gameplay_Isles_User_UserIsle__CreateMvc(param1_00,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0xA0B5", Offset = "0xA0B5", VA = "0xA0B5")]
		private void OnMonsterClick()
		{
		/* --- GHIDRA: OnMonsterClick ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__OnMonsterClick
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59399 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TreeService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a59399 = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents___ctor__
		            );
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TreeService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_ToolTip_ToolTip__get_enabled(*(undefined4 *)(iVar1 + 0x34),0,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleMonsterViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine(param1_00,param1);
		  return;
		}
		*/

}
