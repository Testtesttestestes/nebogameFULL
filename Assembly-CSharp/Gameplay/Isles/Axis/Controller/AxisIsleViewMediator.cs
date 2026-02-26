using System;
using Core.Data;
using Gameplay.Isles.Axis.Events;
using Gameplay.Isles.Axis.Model;
using Gameplay.Isles.Axis.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Axis.Controller
{
	// Token: 0x02000D0A RID: 3338
	[Token(Token = "0x2000D0A")]
	public class AxisIsleViewMediator : AbstractViewMediator<AxisIsleModel, AxisIsleEvents, AxisIsleController, AxisIsleView>
	{
		// Token: 0x0600516E RID: 20846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x9F4D", Offset = "0x9F4D", VA = "0x9F4D")]
		public AxisIsleViewMediator(AxisIsleModel model, AxisIsleEvents events, AxisIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58d08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView__set_View__
		              );
		    DAT_ram_00a58d08 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700107C RID: 4220
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107C")]
		public override AxisIsleView View
		{
			[Token(Token = "0x600516F")]
			[Address(RVA = "0x9F4E", Offset = "0x9F4E", VA = "0x9F4E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x9F4F", Offset = "0x9F4F", VA = "0x9F4F")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int param1_00;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a58d0a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_BgClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_ColossusClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_17767);
		    DAT_ram_00a58d0a = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar3 + 0x10);
		  iVar3 = param1[2];
		  if (DAT_ram_00a58cea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58cea = '\x01';
		  }
		  uVar2 = 0;
		  piVar8 = *(int **)(iVar3 + 0x1c);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f9d119;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f9d119:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar5 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar5,StringLiteral_17767,0);
		  AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(uVar7,uVar5,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar7,param1,
		             Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_BgClickedEventHandler__,0);
		  if (DAT_ram_00a58cee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58cee = '\x01';
		  }
		  iVar9 = *(int *)(iVar3 + 0x20);
		  while ((piVar8 = (int *)UnityEngine_UI_Image__set_sprite(iVar9,uVar7,0), piVar8 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar8))) {
		    iVar6 = func_ii_4329(iVar3 + 0x20,piVar8,iVar9);
		    bVar1 = iVar6 == iVar9;
		    iVar9 = iVar6;
		    if (bVar1) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar7,param1,
		                 Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_ColossusClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a58cf0 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf0 = '\x01';
		      }
		      iVar9 = *(int *)(iVar3 + 0x24);
		      while( true ) {
		        iVar6 = 0;
		        param1_00 = UnityEngine_UI_Image__set_sprite(iVar9,uVar7,0);
		        uVar5 = System_Action_ColossusBattleData__TypeInfo;
		        if ((param1_00 != 0) &&
		           (iVar6 = func_ii_1082(param1_00,System_Action_ColossusBattleData__TypeInfo), iVar6 == 0))
		        break;
		        iVar6 = func_ii_4329(iVar3 + 0x24,iVar6,iVar9);
		        bVar1 = iVar6 == iVar9;
		        iVar9 = iVar6;
		        if (bVar1) {
		          if (DAT_ram_00a58d0e == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView__get_Model__
		                      );
		            DAT_ram_00a58d0e = '\x01';
		          }
		          uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          iVar9 = *(int *)(param1[2] + 0x30);
		          uVar5 = *(undefined4 *)(iVar9 + 0x18);
		          iVar3 = UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor
		                            (iVar9,0);
		          Gameplay_Isles_Axis_View_AxisIsleView__ColossusClickedEventHandler
		                    (uVar7,uVar5,*(undefined4 *)(iVar3 + 0x1ec),iVar9);
		          return;
		        }
		      }
		      System_Activator__CreateInstance(param1_00,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar8,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x9F50", Offset = "0x9F50", VA = "0x9F50")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58d0b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d0b = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80f9d3fd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9d3fd:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldAxisManager__ShowWorldAxisWindow(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x9F51", Offset = "0x9F51", VA = "0x9F51")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		/* --- GHIDRA: ColossusClickedEventHandler ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__ColossusClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58d0c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d0c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80f9d4d3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9d4d3:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldAxisManager___ctor(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x9F52", Offset = "0x9F52", VA = "0x9F52")]
		private void BgClickedEventHandler()
		{
		/* --- GHIDRA: BgClickedEventHandler ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__BgClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58d0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_IsleInformationChangedEventHandler__
		              );
		    DAT_ram_00a58d0d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_IsleInformationChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_IsleInformationChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x1700107D RID: 4221
		// (set) Token: 0x06005174 RID: 20852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107D")]
		public override AxisIsleEvents Events
		{
			[Token(Token = "0x6005174")]
			[Address(RVA = "0x9F53", Offset = "0x9F53", VA = "0x9F53", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005175")]
		[Address(RVA = "0x9F54", Offset = "0x9F54", VA = "0x9F54")]
		private void IsleInformationChangedEventHandler()
		{
		/* --- GHIDRA: IsleInformationChangedEventHandler ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__IsleInformationChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView__get_Model__
		              );
		    DAT_ram_00a58d0e = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(int *)(param1[2] + 0x30);
		  param2_00 = *(undefined4 *)(param1_01 + 0x18);
		  iVar1 = UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor
		                    (param1_01,0);
		  Gameplay_Isles_Axis_View_AxisIsleView__ColossusClickedEventHandler
		            (param1_00,param2_00,*(undefined4 *)(iVar1 + 0x1ec),param1_01);
		  return;
		}
		*/

		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x9F55", Offset = "0x9F55", VA = "0x9F55")]
		private void UpdateColossus()
		{
		/* --- GHIDRA: UpdateColossus ---
		undefined4
		Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__UpdateColossus(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_18905);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18906);
		    DAT_ram_00a58d0f = '\x01';
		  }
		  uVar1 = StringLiteral_18905;
		  if (*(int *)(param1 + 0x10) != 0) {
		    local_8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1 + 0x10) + 8),0);
		    uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar1 = func_ii_4419(StringLiteral_18906,uVar1,0);
		  }
		  return uVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_Axis_Controller_AxisIsleViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  int param1_01;
		  
		  if (DAT_ram_00a58d09 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_BgClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_ColossusClickedEventHandler__
		              );
		    DAT_ram_00a58d09 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_BgClickedEventHandler__,0);
		  if (DAT_ram_00a58cef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58cef = '\x01';
		  }
		  iVar2 = *(int *)(iVar3 + 0x20);
		  while ((param1_00 = (int *)func_ii_7048(iVar2,uVar4,0), param1_00 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_00))) {
		    iVar5 = func_ii_4329(iVar3 + 0x20,param1_00,iVar2);
		    bVar1 = iVar5 == iVar2;
		    iVar2 = iVar5;
		    if (bVar1) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_ColossusClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a58cf1 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf1 = '\x01';
		      }
		      iVar2 = *(int *)(iVar3 + 0x24);
		      while( true ) {
		        iVar5 = 0;
		        param1_01 = func_ii_7048(iVar2,uVar4,0);
		        param2_00 = System_Action_ColossusBattleData__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar5 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar5 == 0))
		        break;
		        iVar5 = func_ii_4329(iVar3 + 0x24,iVar5,iVar2);
		        bVar1 = iVar5 == iVar2;
		        iVar2 = iVar5;
		        if (bVar1) {
		          return;
		        }
		      }
		      System_Activator__CreateInstance(param1_01,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(param1_00,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
