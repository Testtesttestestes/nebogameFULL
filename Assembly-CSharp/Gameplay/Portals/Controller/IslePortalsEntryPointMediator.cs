using System;
using Gameplay.Isles.User;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	public class IslePortalsEntryPointMediator : AbstractViewMediator<PortalsModel, PortalsEvents, PortalsController, PortalsEntryPointView>
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x7554", Offset = "0x7554", VA = "0x7554")]
		public IslePortalsEntryPointMediator(PortalsModel model, PortalsEvents events, PortalsController controller, UserIsle isle)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5813b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_PortalStateChangedHandler__
		              );
		    DAT_ram_00a5813b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_PortalStateChangedHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x50) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x50) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_PortalStateChangedHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x50) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x50) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x170006CE RID: 1742
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CE")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002404")]
			[Address(RVA = "0x7555", Offset = "0x7555", VA = "0x7555", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CF")]
		public override PortalsEntryPointView View
		{
			[Token(Token = "0x6002405")]
			[Address(RVA = "0x7556", Offset = "0x7556", VA = "0x7556", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x7557", Offset = "0x7557", VA = "0x7557")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5813e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_OnPortalClick__);
		    DAT_ram_00a5813e = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_OnPortalClick__,0);
		  if (DAT_ram_00a580da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580da = '\x01';
		  }
		  iVar9 = *(int *)(iVar3 + 0x30);
		  do {
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar9,uVar4,0);
		    if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		      System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar6 = func_ii_4329(iVar3 + 0x30,piVar5,iVar9);
		    bVar1 = iVar6 != iVar9;
		    iVar9 = iVar6;
		  } while (bVar1);
		  iVar3 = param1[2];
		  if ((*(int *)(iVar3 + 0x10) == 0) ||
		     (*(int *)(*(int *)(param1[6] + 0x10) + 8) != *(int *)(iVar3 + 8))) {
		    iVar3 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x15c));
		    Gameplay_Portals_View_PortalsEntryPointView__Hide(uVar4,*(undefined4 *)(param1[2] + 0x30),iVar3)
		    ;
		  }
		  else {
		    uVar2 = 0;
		    piVar5 = *(int **)(iVar3 + 0x24);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x160);
		          goto code_r0x80ea7e0c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80ea7e0c:
		    uVar4 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		    iVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                      (uVar4,*(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x1c),
		                       *(undefined4 *)(param1[2] + 8),0);
		    iVar9 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar9 + 0x15c));
		    Gameplay_Portals_View_PortalsEntryPointView__Hide(uVar4,*(undefined4 *)(param1[2] + 0x30),iVar9)
		    ;
		    uVar4 = 1;
		    if (iVar3 != 0) goto code_r0x80ea7e91;
		  }
		  uVar4 = 0;
		code_r0x80ea7e91:
		  uVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar8,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar8,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x7558", Offset = "0x7558", VA = "0x7558")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_IslePortalsEntryPointMediator__ResetView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x7559", Offset = "0x7559", VA = "0x7559")]
		private void PortalStateChangedHandler()
		{
		/* --- GHIDRA: PortalStateChangedHandler ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator__PortalStateChangedHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5813f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5813f = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0x24);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80ea7f6b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ea7f6b:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x14) + 0x20);
		  if (iVar3 != 0) {
		    Gameplay_Isles_User_UserIsle__ShowMonsterWindow(iVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x755A", Offset = "0x755A", VA = "0x755A")]
		private void OnPortalClick()
		{
		}

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x18")]
		private readonly UserIsle _isle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5813c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5813c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,param2,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		    if (iVar2 != 0) {
		      Gameplay_Portals_Controller_IslePortalsEntryPointMediator__set_View(param1,param1);
		    }
		    param1[5] = param2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		    if (iVar2 != 0) {
		      Gameplay_Portals_Controller_IslePortalsEntryPointMediator__ResetView(param1,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Portals_Controller_IslePortalsEntryPointMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5813d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_OnPortalClick__);
		    DAT_ram_00a5813d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Gameplay_Portals_Controller_IslePortalsEntryPointMediator_OnPortalClick__,0);
		  if (DAT_ram_00a580db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580db = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x30);
		  while ((param1_02 = (int *)func_ii_7048(param1_00,param1_01,0), param1_02 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_02))) {
		    iVar3 = func_ii_4329(iVar2 + 0x30,param1_02,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
