using System;
using Gameplay.Combat.Control;
using Gameplay.Portals.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Combat.Control
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	public class PortalCombatController : CombatController<PortalCombatModel, PortalCombatEvents>
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x7618", Offset = "0x7618", VA = "0x7618")]
		public PortalCombatController(ICombatService service, PortalsService portalsService, PortalCombatModel model, PortalCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Combat_Control_PortalCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a57d62 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_HandleRequestCombatService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_OnDropRemoveEventHandler__
		              );
		    DAT_ram_00a57d62 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__HandleRun__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x40) == 0) {
		    Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    uVar3 = ServicesNamespace_PortalsService__BuyShopItem(param1[8],0);
		    uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_HandleRequestCombatService__
		               ,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		        goto code_r0x80e53d4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e53d4d:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		  iVar8 = *(int *)(iVar2 + 0x14);
		  uVar4 = *(undefined4 *)(iVar8 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) ||
		          (*(int **)(iVar8 + 0x20) = piVar7, *piVar7 != iVar2)) {
		    System_Activator__CreateInstance(piVar7,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		        goto code_r0x80e53e58;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e53e58:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		  iVar8 = *(int *)(iVar2 + 0x14);
		  uVar4 = *(undefined4 *)(iVar8 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x24) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) ||
		          (*(int **)(iVar8 + 0x24) = piVar7, *piVar7 != iVar2)) {
		    System_Activator__CreateInstance(piVar7,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		        goto code_r0x80e53f59;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e53f59:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		  iVar8 = *(int *)(iVar2 + 0x14);
		  uVar4 = *(undefined4 *)(iVar8 + 0x28);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) ||
		          (*(int **)(iVar8 + 0x28) = piVar7, *piVar7 != iVar2)) {
		    System_Activator__CreateInstance(piVar7,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		        goto code_r0x80e5405a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e5405a:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		  iVar8 = **(int **)(iVar2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar4 = *(undefined4 *)(iVar2 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatController_OnDropRemoveEventHandler__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar2 + 0x18) = 0;
		    return;
		  }
		  iVar6 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		  if (iVar6 != 0) {
		    *(int *)(iVar2 + 0x18) = iVar6;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar2 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		    if (iVar2 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar8,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar8,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x7619", Offset = "0x7619", VA = "0x7619", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Portals_Combat_Control_PortalCombatController__HandleRun
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57d63 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_OnDropRemoveEventHandler__
		              );
		    DAT_ram_00a57d63 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents__HandleStop__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		        goto code_r0x80e541ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e541ff:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  if (*(int *)(iVar2 + 0x14) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		          goto code_r0x80e542a9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e542a9:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = *(int *)(iVar2 + 0x14);
		    uVar8 = *(undefined4 *)(iVar7 + 0x20);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0)
		    ;
		    piVar6 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar7 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar7 + 0x20) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		          goto code_r0x80e543aa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e543aa:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = *(int *)(iVar2 + 0x14);
		    uVar8 = *(undefined4 *)(iVar7 + 0x24);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0)
		    ;
		    piVar6 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar7 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar7 + 0x24) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		          goto code_r0x80e544ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e544ab:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = *(int *)(iVar2 + 0x14);
		    uVar8 = *(undefined4 *)(iVar7 + 0x28);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_InfoChangedHandler__,0)
		    ;
		    piVar6 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar7 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar7 + 0x28) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x80e545ac;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e545ac:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar7 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatController_OnDropRemoveEventHandler__
		               ,0);
		    iVar7 = func_ii_7048(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__TypeInfo;
		    if (iVar7 == 0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar7,System_Action_DropTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x18) = iVar5;
		    uVar4 = System_Action_DropTypes__TypeInfo;
		    iVar2 = func_ii_1082(iVar7,System_Action_DropTypes__TypeInfo);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x761A", Offset = "0x761A", VA = "0x761A", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Portals_Combat_Control_PortalCombatController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x70);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x761B", Offset = "0x761B", VA = "0x761B")]
		private void InfoChangedHandler()
		{
		/* --- GHIDRA: InfoChangedHandler ---
		void Gameplay_Portals_Combat_Control_PortalCombatController__InfoChangedHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x761C", Offset = "0x761C", VA = "0x761C")]
		private void OnDropRemoveEventHandler(DropTypes obDropType)
		{
		/* --- GHIDRA: OnDropRemoveEventHandler ---
		void Gameplay_Portals_Combat_Control_PortalCombatController__OnDropRemoveEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int *param1_00;
		  int param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57d64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoRequestPortalCombatAns_TypeInfo);
		    DAT_ram_00a57d64 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Portal_ProtoRequestPortalCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoRequestPortalCombatAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01,uVar2,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x761D", Offset = "0x761D", VA = "0x761D")]
		private void HandleRequestCombatService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleRequestCombatService ---
		int Gameplay_Portals_Combat_Control_PortalCombatController__HandleRequestCombatService
		              (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57d65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    DAT_ram_00a57d65 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (uVar2,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,param2_00,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x761E", Offset = "0x761E", VA = "0x761E", Slot = "20")]
		protected override bool TryHandleJoinError(ProtoJoinToCombatAns msg)
		{
		/* --- GHIDRA: TryHandleJoinError ---
		void Gameplay_Portals_Combat_Control_PortalCombatController__TryHandleJoinError
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57d66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d66 = '\x01';
		  }
		  HuaweiMobileServices_Drive_AbstractJsonClientRequest___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView___ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x20")]
		private readonly PortalsService _portalsService;
	}
}
