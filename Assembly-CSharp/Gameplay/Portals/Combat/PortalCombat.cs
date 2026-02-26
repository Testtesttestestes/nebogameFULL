using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Portals.Combat.Control;
using Gameplay.Portals.Combat.Model;
using Gameplay.Portals.Combat.View;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Portals.Combat
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public class PortalCombat : AbstractCombat<PortalCombatModel, PortalCombatEvents, PortalCombatController, PortalCombatViewMediator, PortalCombatView>
	{
		// Token: 0x060024BD RID: 9405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x760B", Offset = "0x760B", VA = "0x760B")]
		public PortalCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Combat_PortalCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param4;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param6;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  int param1_00;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 uVar11;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a57d5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_Control_PortalCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_PortalCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_Model_PortalCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_Control_PortalCombatViewMediator_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_PortalsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a57d5b = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_Portals_Combat_PortalCombatEvents_TypeInfo);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x290);
		        goto code_r0x80e52c48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e52c48:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x290);
		        goto code_r0x80e52ccd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e52ccd:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x290);
		        goto code_r0x80e52d52;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e52d52:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar10 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = 0;
		  uVar6 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar7 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x158);
		        goto code_r0x80e52df8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e52df8:
		  iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar11 = *(undefined4 *)(iVar9 + 0x14);
		  uVar1 = 0;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80e52e80;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e52e80:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x220);
		        goto code_r0x80e52f05;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e52f05:
		  iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  param7 = *(undefined4 *)(iVar9 + 0x18);
		  uVar1 = 0;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x148);
		        goto code_r0x80e52f8d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80e52f8d:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80e53012;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e53012:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x188);
		        goto code_r0x80e53097;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80e53097:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		        goto code_r0x80e5311c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e5311c:
		  piVar8 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar1 = 0;
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe8);
		        goto code_r0x80e5319c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,5);
		code_r0x80e5319c:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x150);
		        goto code_r0x80e53221;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e53221:
		  iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  param12 = *(undefined4 *)(iVar9 + 0x10);
		  iVar9 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar9,param1,uVar6,uVar7,uVar11,param6,param7,param8,param9,param10,param11,param12,0);
		  uVar6 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar6,StringLiteral_11974,StringLiteral_1773,0);
		  uVar6 = Utils_LocalProps___ctor(uVar6,0);
		  *(undefined4 *)(iVar9 + 0x34) = uVar6;
		  uVar6 = *(undefined4 *)(param1 + 0xc);
		  uVar7 = *(undefined4 *)(param1 + 8);
		  uVar11 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Portals_Combat_Model_PortalCombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar9,uVar11,uVar7,uVar6,0);
		  *(undefined4 *)(param1_00 + 0x68) = uVar5;
		  *(undefined4 *)(param1_00 + 0x60) = uVar4;
		  *(undefined4 *)(param1_00 + 100) = uVar3;
		  *(undefined4 *)(param1_00 + 0x5c) = uVar10;
		  iVar9 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar9 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar9;
		  iVar9 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar9 + 0x10) = 0xf;
		  *(int *)(param1_00 + 0x54) = iVar9;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_PortalsService___);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  iVar9 = unnamed_function_1417(Gameplay_Portals_Combat_Control_PortalCombatController_TypeInfo);
		  if (DAT_ram_00a57d61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents___ctor__
		              );
		    DAT_ram_00a57d61 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar9,uVar3,uVar5,param4,
		             Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar9 + 0x20) = uVar4;
		  *(int *)(param1 + 0x10) = iVar9;
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Portals_Combat_Control_PortalCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a57d66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d66 = '\x01';
		  }
		  HuaweiMobileServices_Drive_AbstractJsonClientRequest___Il2CppFullySharedGenericType____ctor
		            (uVar3,uVar4,param4,iVar9,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x760C", Offset = "0x760C", VA = "0x760C", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		uint Gameplay_Portals_Combat_PortalCombat__InitMVC(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57d5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		    DAT_ram_00a57d5c = '\x01';
		  }
		  if (param2 != 0) {
		    iVar5 = *param1;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x80e5353d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e5353d:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    iVar5 = *param1;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x80e535c5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e535c5:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    uVar4 = func_ii_7112(uVar4,0);
		    param1_00 = (int *)unnamed_function_1417(Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		    if (DAT_ram_00a57d5a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		                );
		      DAT_ram_00a57d5a = '\x01';
		    }
		    Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		              (param1_00,param1,uVar3,uVar4,0,
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		              );
		    uVar1 = 1;
		    iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                      (param1_00,param2,
		                       Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__TryRun__
		                      );
		    if (iVar5 == 0) {
		      uVar1 = 0;
		      Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		                (param1_00,
		                 Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView__Stop__
		                );
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		                (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x760D", Offset = "0x760D", VA = "0x760D")]
		public static bool TryRun(IGame game, ResourceSet cost)
		{
		/* --- GHIDRA: TryRun ---
		undefined4 Gameplay_Portals_Combat_PortalCombat__TryRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57d5d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		    DAT_ram_00a57d5d = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e536f5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e536f5:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e5377d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e5377d:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		  if (DAT_ram_00a57d5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d5a = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,0,
		             Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		            );
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x760E", Offset = "0x760E", VA = "0x760E")]
		public static ICombat Run(IGame game)
		{
		/* --- GHIDRA: Run ---
		undefined4
		Gameplay_Portals_Combat_PortalCombat__Run(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57d5e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		    DAT_ram_00a57d5e = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e5386e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e5386e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e538f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e538f6:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		  if (DAT_ram_00a57d5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d5a = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,param2,
		             Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		            );
		  return param1_00;
		}
		*/

		/* --- GHIDRA: Run ---
		undefined4
		Gameplay_Portals_Combat_PortalCombat__Run(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57d5e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		    DAT_ram_00a57d5e = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e5386e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e5386e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e538f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e538f6:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_Portals_Combat_PortalCombat_TypeInfo);
		  if (DAT_ram_00a57d5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		              );
		    DAT_ram_00a57d5a = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,param2,
		             Method_Gameplay_Combat_AbstractCombat_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatViewMediator__PortalCombatView___ctor__
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x760F", Offset = "0x760F", VA = "0x760F")]
		public static ICombat Run(IGame game, BackTime backTime)
		{
			return null;
		}
	}
}
