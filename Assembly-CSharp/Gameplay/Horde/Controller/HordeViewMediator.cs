using System;
using Gameplay.Horde.Events;
using Gameplay.Horde.Model;
using Gameplay.Horde.View;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Horde.Controller
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	public class HordeViewMediator : AbstractViewMediator<HordeModel, HordeEvents, HordeController, HordeView>
	{
		// Token: 0x06002AF7 RID: 10999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x7B92", Offset = "0x7B92", VA = "0x7B92")]
		public HordeViewMediator(HordeModel model, HordeEvents events, HordeController controller)
		{
		/* --- GHIDRA: <ShowExitHordeConfirmationWindow>b__16_0 ---
		void Gameplay_Horde_Controller_HordeViewMediator___ShowExitHordeConfirmationWindow_b__16_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a219 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Controller_HordeViewMediator___c_TypeInfo);
		    DAT_ram_00a5a219 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Horde_Controller_HordeViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Horde_Controller_HordeViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Horde_Controller_HordeViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a20d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_HordeExitedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_HordeRequestedEventHandler__);
		    DAT_ram_00a5a20d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_HordeRequestedEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_HordeExitedEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_HordeRequestedEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_HordeExitedEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700082A RID: 2090
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082A")]
		public override HordeEvents Events
		{
			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x7B93", Offset = "0x7B93", VA = "0x7B93", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082B")]
		public override HordeView View
		{
			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x7B94", Offset = "0x7B94", VA = "0x7B94", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x7B95", Offset = "0x7B95", VA = "0x7B95")]
		private void RequestHordeInfoEventHandler(uint mainMonsterId)
		{
		/* --- GHIDRA: RequestHordeInfoEventHandler ---
		void Gameplay_Horde_Controller_HordeViewMediator__RequestHordeInfoEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param3;
		  undefined4 param2_00;
		  int *piVar5;
		  
		  if (DAT_ram_00a5a210 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_HordeMonsterAprView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_MonsterAprClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IWindowWithCloseBackButtons_TypeInfo);
		    DAT_ram_00a5a210 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *(undefined4 *)(param1[2] + 0x28);
		  param2_00 = *(undefined4 *)(param1[2] + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_HordeMonsterAprView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Horde_Controller_HordeViewMediator_MonsterAprClickedEventHandler__,0);
		  iVar3 = Gameplay_Horde_View_HordeView__InitMasterWindowStatus(uVar2,param2_00,param3,param1_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  Gameplay_Horde_Controller_HordeViewMediator__MonsterAprClickedEventHandler
		            (param1,*(undefined4 *)(iVar3 + *(int *)(param1[2] + 0x28) * 4 + 0x10),iVar3);
		  if (*(int *)(param1[2] + 0x28) < 1) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined1 *)(iVar3 + 0x3d) = 1;
		  }
		  else {
		    Gameplay_Horde_Controller_HordeViewMediator__HordeRequestedEventHandler(param1,iVar3);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar3 + 0x44);
		  iVar3 = *piVar5;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e7f91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,0);
		code_r0x811e7f91:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  System_Linq_Enumerable__First_object_(uVar2,1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar3 + 0x44);
		  iVar3 = *piVar5;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x811e8034;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,1);
		code_r0x811e8034:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  System_Linq_Enumerable__First_object_(uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x7B96", Offset = "0x7B96", VA = "0x7B96")]
		private void HordeRequestedEventHandler()
		{
		/* --- GHIDRA: HordeRequestedEventHandler ---
		void Gameplay_Horde_Controller_HordeViewMediator__HordeRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a211 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_ShowExitHordeConfirmationWindow__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_IWindowWithCloseBackButtons_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a211 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined1 *)(iVar2 + 0x3d) = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar2 + 0x44);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e8228;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,0);
		code_r0x811e8228:
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  func_ii_14558(*(undefined4 *)(iVar2 + 0xb4),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar2 + 0x44);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x811e82cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,1);
		code_r0x811e82cd:
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  func_ii_14558(*(undefined4 *)(iVar2 + 0xb4),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar2 + 0x44);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e8372;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,0);
		code_r0x811e8372:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar2 + 0xb4);
		  uVar1 = 0;
		  uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar4,param1,
		             Method_Gameplay_Horde_Controller_HordeViewMediator_ShowExitHordeConfirmationWindow__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar2 + 0x44);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x811e843a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,1);
		code_r0x811e843a:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar2 + 0xb4);
		  uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar4,param1,
		             Method_Gameplay_Horde_Controller_HordeViewMediator_ShowExitHordeConfirmationWindow__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x7B97", Offset = "0x7B97", VA = "0x7B97")]
		private void OverrideCloseMasterWindow()
		{
		/* --- GHIDRA: OverrideCloseMasterWindow ---
		void Gameplay_Horde_Controller_HordeViewMediator__OverrideCloseMasterWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a212 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_BaseWindow_TypeInfo);
		    DAT_ram_00a5a212 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(int **)(iVar1 + 0x44);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) < (uint)*(byte *)(UI_Windows_BaseWindow_TypeInfo + 0xb8)
		        ) || (*(int *)(*(int *)(*param1_00 + 100) +
		                       (uint)*(byte *)(UI_Windows_BaseWindow_TypeInfo + 0xb8) * 4 + -4) !=
		              UI_Windows_BaseWindow_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,UI_Windows_BaseWindow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x7B98", Offset = "0x7B98", VA = "0x7B98")]
		private void HordeExitedEventHandler()
		{
		/* --- GHIDRA: HordeExitedEventHandler ---
		void Gameplay_Horde_Controller_HordeViewMediator__HordeExitedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint *param3;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a213 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_IMonsterSource_TypeInfo);
		    DAT_ram_00a5a213 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(int **)(iVar3 + 0x40);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Isles_User_IMonsterSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        param3 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e85c9;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  param3 = (uint *)func_ii_1080(param1_01,Gameplay_Isles_User_IMonsterSource_TypeInfo,0);
		code_r0x811e85c9:
		  lVar1 = (**(code **)((ulonglong)*param3 * 4))(param1_01,param3[1]);
		  Gameplay_Horde_Controller_HordeController__GetHordeInfoResultHandler
		            (param1_00,(uint)(lVar1 == 0),param3);
		  return;
		}
		*/

		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x7B99", Offset = "0x7B99", VA = "0x7B99")]
		private void ExitHorde()
		{
		/* --- GHIDRA: ExitHorde ---
		void Gameplay_Horde_Controller_HordeViewMediator__ExitHorde(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Gameplay_Horde_Controller_HordeViewMediator__AttackMonster(param1,param1);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Horde_Controller_HordeViewMediator__AttackButtonClickedEventHandler
		              (param1,*(undefined4 *)(iVar1 + 0x40),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x7B9A", Offset = "0x7B9A", VA = "0x7B9A")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_Horde_Controller_HordeViewMediator__AttackButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param3_00;
		  undefined4 param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a5a214 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_AttackRequestedHordeMonster_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IWindowWithCloseBackButtons_TypeInfo);
		    DAT_ram_00a5a214 = '\x01';
		  }
		  iVar3 = param1[2];
		  param3_00 = *(undefined4 *)(*(int *)(iVar3 + 0x20) + *(int *)(iVar3 + 0x28) * 4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar3 + 0xc);
		  param1_00 = unnamed_function_1417(Gameplay_Horde_Model_AttackRequestedHordeMonster_TypeInfo);
		  Gameplay_Horde_Model_AttackRequestedHordeMonster__get_Monster(param1_00,param2,param3_00,0);
		  iVar3 = Gameplay_ArenaCombat_ArenaCombat__Dispose(param1_01,param1_00,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = 0;
		    param1_02 = *(int **)(iVar3 + 0x44);
		    iVar3 = *param1_02;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (UI_Windows_IWindowWithCloseBackButtons_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811e882f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_02,UI_Windows_IWindowWithCloseBackButtons_TypeInfo,2);
		code_r0x811e882f:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_02,2,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0x7B9B", Offset = "0x7B9B", VA = "0x7B9B")]
		private void AttackMonster(IMonsterSource source)
		{
		/* --- GHIDRA: AttackMonster ---
		undefined4 Gameplay_Horde_Controller_HordeViewMediator__AttackMonster(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a215 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Horde_Controller_HordeViewMediator___c__DisplayClass13_0__CheckItemsDurability_g__RepairArtifactsAndCheckOthers_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Horde_Controller_HordeViewMediator___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a5a215 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Horde_Controller_HordeViewMediator___c__DisplayClass13_0_TypeInfo)
		  ;
		  *(int *)(param2_00 + 8) = param1;
		  uVar1 = 1;
		  if (*(int *)(*(int *)(param1 + 8) + 0x28) == 0) {
		    uVar2 = func_ii_7504(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		    iVar3 = Core_Data_UserData__get_Accounts(uVar2,1,&local_4,0);
		    if (iVar3 == 0) {
		      uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0x10);
		      uVar4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0xc);
		      iVar3 = Gameplay_Inventory_Model_InventoryModel__GetExtraSlotsCount(uVar2,uVar4,0);
		      param1_00 = Gameplay_Inventory_Model_InventoryModel__GetArtifactsToRepairForHorde
		                            (uVar2,uVar4,0);
		      *(int *)(param2_00 + 0xc) = param1_00;
		      if (*(int *)(iVar3 + 0xc) == 0) {
		        if (*(int *)(param1_00 + 0xc) != 0) {
		          uVar1 = 0;
		          Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow__get_WindowId(param1_00,0);
		        }
		      }
		      else {
		        uVar4 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		        uVar1 = 0;
		        uVar2 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar2,param2_00,
		                   Method_Gameplay_Horde_Controller_HordeViewMediator___c__DisplayClass13_0__CheckItemsDurability_g__RepairArtifactsAndCheckOthers_0__
		                   ,0);
		        Gameplay_Horde_View_ConfirmRepairUserArtifactWindow__get_WindowId(uVar4,uVar2,iVar3,0);
		      }
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0x7B9C", Offset = "0x7B9C", VA = "0x7B9C")]
		private bool CheckItemsDurability()
		{
		/* --- GHIDRA: CheckItemsDurability ---
		void Gameplay_Horde_Controller_HordeViewMediator__CheckItemsDurability
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a216 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a216 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    Gameplay_Horde_View_HordeMonsterAprView__get_Data(*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  Gameplay_Horde_Controller_HordeViewMediator__MonsterAprClickedEventHandler(param1,param2,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x7B9D", Offset = "0x7B9D", VA = "0x7B9D")]
		private void MonsterAprClickedEventHandler(HordeMonsterAprView view)
		{
		/* --- GHIDRA: MonsterAprClickedEventHandler ---
		void Gameplay_Horde_Controller_HordeViewMediator__MonsterAprClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param5;
		  int iVar2;
		  uint param2_01;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5a217 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_HordeMonsterAprView_HordeMonsterAprViewArgs__get_args__
		              );
		    DAT_ram_00a5a217 = '\x01';
		  }
		  param1[6] = param2;
		  Gameplay_Horde_View_HordeMonsterAprView__get_Data(param2,1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = Core_Extensions_Dict_GameEventExt__GetEntryPointIconAssetId
		                        (*(undefined4 *)(param1[2] + 0x1c),0);
		  param3_00 = Core_Extensions_Dict_HordeDicExt__GetTitle(*(undefined4 *)(param1[2] + 0x1c),0);
		  param4 = *(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x28);
		  param5 = Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__DisplayClass4_0___Show_b__0
		                     (param2,0);
		  Gameplay_Horde_View_HordeView__SpawnMonsterApr
		            (uVar1,param2_00,param3_00,param4,param5,*(undefined4 *)(param1[2] + 8),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(*(int *)(param2 + 0x18) + 8) == *(int *)(param1[2] + 0x28)),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x20),0);
		  if (*(int *)(param1[2] + 0x28) == 0) {
		    param2_01 = (uint)(*(int *)(*(int *)(param2 + 0x18) + 8) == 0);
		  }
		  else {
		    param2_01 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x7B9E", Offset = "0x7B9E", VA = "0x7B9E")]
		private void SelectMonsterView(HordeMonsterAprView view)
		{
		/* --- GHIDRA: SelectMonsterView ---
		void Gameplay_Horde_Controller_HordeViewMediator__SelectMonsterView
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a218 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Horde_Controller_HordeViewMediator__ShowExitHordeConfirmationWindow_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_2765);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8719);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11304);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a5a218 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2765,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8719,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Horde_Controller_HordeViewMediator__ShowExitHordeConfirmationWindow_b__16_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11304,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x7B9F", Offset = "0x7B9F", VA = "0x7B9F")]
		private void ShowExitHordeConfirmationWindow()
		{
		/* --- GHIDRA: ShowExitHordeConfirmationWindow ---
		void Gameplay_Horde_Controller_HordeViewMediator__ShowExitHordeConfirmationWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Horde_Controller_HordeViewMediator__HordeExitedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x18")]
		private HordeMonsterAprView _selectedView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Horde_Controller_HordeViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a20e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_AttackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeViewMediator_RequestHordeInfoEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a20e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Horde_Controller_HordeViewMediator_RequestHordeInfoEventHandler__,
		                  0);
		    Gameplay_Horde_View_HordeView__add_RequestHordeInfoEvent(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_AttackButtonClickedEventHandler__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Horde_Controller_HordeViewMediator_RequestHordeInfoEventHandler__,
		                  0);
		    Gameplay_Horde_View_HordeView__get_KickButton(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Horde_Controller_HordeViewMediator_AttackButtonClickedEventHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Horde_Controller_HordeViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint *param3_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a20f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_IMonsterSource_TypeInfo);
		    DAT_ram_00a5a20f = '\x01';
		  }
		  *(undefined4 *)(param1[2] + 0x24) = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(int **)(iVar3 + 0x40);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Isles_User_IMonsterSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        param3_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e7de6;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_01,Gameplay_Isles_User_IMonsterSource_TypeInfo,0);
		code_r0x811e7de6:
		  lVar1 = (**(code **)((ulonglong)*param3_00 * 4))(param1_01,param3_00[1]);
		  Gameplay_Horde_Controller_HordeController__HandleRun(param1_00,(uint)(lVar1 == 0),param3_00);
		  return;
		}
		*/

}
