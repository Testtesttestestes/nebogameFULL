using System;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ArenaCombat.Control;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D40 RID: 3392
	[Token(Token = "0x2000D40")]
	public class ArenaCombat : AbstractCombat<ArenaCombatModel, ArenaCombatEvents, ArenaCombatController, ArenaCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x06005316 RID: 21270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005316")]
		[Address(RVA = "0xA0EB", Offset = "0xA0EB", VA = "0xA0EB")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ArenaCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a593bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a593bd = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80ff834f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80ff834f:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff83d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff83d7:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80ff845c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80ff845c:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80ff84e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80ff84e4:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff8569;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff8569:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80ff85ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80ff85ee:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8673;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8673:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80ff86f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80ff86f3:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80ff8778;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ff8778:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param12 = *(undefined4 *)(iVar7 + 0x10);
		  iVar7 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar7,param1,uVar2,uVar3,uVar8,uVar5,param7,param8,param9,param10,param11,param12,0);
		  uVar2 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar2,StringLiteral_11974,StringLiteral_1773,0);
		  uVar2 = Utils_LocalProps___ctor(uVar2,0);
		  *(undefined4 *)(iVar7 + 0x34) = uVar2;
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar8 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		  if (DAT_ram_00a593cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		    DAT_ram_00a593cd = '\x01';
		  }
		  uVar5 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x60) = uVar5;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 3;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(param1 + 0x2c) != 0) {
		    *(int *)(param1_00 + 0x60) = *(int *)(param1 + 0x2c);
		  }
		  *(undefined4 *)(param1_00 + 0x5c) = *(undefined4 *)(param1 + 0x28);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8911;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8911:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		  Gameplay_ArenaCombat_ArenaCombat__Run(uVar3,param2_00,uVar2,uVar8,uVar2);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  iVar7 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		  if (DAT_ram_00a593d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		              );
		    DAT_ram_00a593d4 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar2,uVar8,param2_00,
		             Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar3;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a593dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		              );
		    DAT_ram_00a593dc = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,param2_00,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ArenaCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a593bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a593bd = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80ff834f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80ff834f:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff83d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff83d7:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80ff845c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80ff845c:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80ff84e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80ff84e4:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff8569;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff8569:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80ff85ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80ff85ee:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8673;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8673:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80ff86f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80ff86f3:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80ff8778;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ff8778:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param12 = *(undefined4 *)(iVar7 + 0x10);
		  iVar7 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar7,param1,uVar2,uVar3,uVar8,uVar5,param7,param8,param9,param10,param11,param12,0);
		  uVar2 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar2,StringLiteral_11974,StringLiteral_1773,0);
		  uVar2 = Utils_LocalProps___ctor(uVar2,0);
		  *(undefined4 *)(iVar7 + 0x34) = uVar2;
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar8 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		  if (DAT_ram_00a593cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		    DAT_ram_00a593cd = '\x01';
		  }
		  uVar5 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x60) = uVar5;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 3;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(param1 + 0x2c) != 0) {
		    *(int *)(param1_00 + 0x60) = *(int *)(param1 + 0x2c);
		  }
		  *(undefined4 *)(param1_00 + 0x5c) = *(undefined4 *)(param1 + 0x28);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8911;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8911:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		  Gameplay_ArenaCombat_ArenaCombat__Run(uVar3,param2_00,uVar2,uVar8,uVar2);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  iVar7 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		  if (DAT_ram_00a593d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		              );
		    DAT_ram_00a593d4 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar2,uVar8,param2_00,
		             Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar3;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a593dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		              );
		    DAT_ram_00a593dc = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,param2_00,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ArenaCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a593bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a593bd = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80ff834f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80ff834f:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff83d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff83d7:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80ff845c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80ff845c:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80ff84e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80ff84e4:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ff8569;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff8569:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80ff85ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80ff85ee:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8673;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8673:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80ff86f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80ff86f3:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80ff8778;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ff8778:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param12 = *(undefined4 *)(iVar7 + 0x10);
		  iVar7 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar7,param1,uVar2,uVar3,uVar8,uVar5,param7,param8,param9,param10,param11,param12,0);
		  uVar2 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar2,StringLiteral_11974,StringLiteral_1773,0);
		  uVar2 = Utils_LocalProps___ctor(uVar2,0);
		  *(undefined4 *)(iVar7 + 0x34) = uVar2;
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar8 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_ArenaCombat_Model_ArenaCombatModel_TypeInfo);
		  if (DAT_ram_00a593cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		    DAT_ram_00a593cd = '\x01';
		  }
		  uVar5 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x60) = uVar5;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 3;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(param1 + 0x2c) != 0) {
		    *(int *)(param1_00 + 0x60) = *(int *)(param1 + 0x2c);
		  }
		  *(undefined4 *)(param1_00 + 0x5c) = *(undefined4 *)(param1 + 0x28);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80ff8911;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff8911:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_TypeInfo);
		  Gameplay_ArenaCombat_ArenaCombat__Run(uVar3,param2_00,uVar2,uVar8,uVar2);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  iVar7 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatController_TypeInfo);
		  if (DAT_ram_00a593d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		              );
		    DAT_ram_00a593d4 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar2,uVar8,param2_00,
		             Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar3;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_ArenaCombat_Control_ArenaCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a593dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		              );
		    DAT_ram_00a593dc = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,param2_00,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005317")]
		[Address(RVA = "0xA0EC", Offset = "0xA0EC", VA = "0xA0EC")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, ArenaCombatModel.AttackRequestedMonster monsterRequest)
		{
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005318")]
		[Address(RVA = "0xA0ED", Offset = "0xA0ED", VA = "0xA0ED")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, ArenaCombatModel.ArenaCombatRequested arenaRequest)
		{
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005319")]
		[Address(RVA = "0xA0EE", Offset = "0xA0EE", VA = "0xA0EE", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_ArenaCombat_ArenaCombat__InitMVC(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a593be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__Dispose__
		              );
		    DAT_ram_00a593be = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x28) = 0;
		  piVar1 = *(int **)(param1 + 0x30);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531A")]
		[Address(RVA = "0xA0EF", Offset = "0xA0EF", VA = "0xA0EF", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_ArenaCombat_ArenaCombat__Dispose(int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a593bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593bf = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff8cdf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff8cdf:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff8d67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff8d67:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  param1_01 = (int *)unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		  if (DAT_ram_00a593bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a593bc = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_01,param1,uVar3,uVar4,param1_00,
		             Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  param1_01[10] = (int)param2;
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x80ff8e4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80ff8e4f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,*(undefined4 *)(iVar5 + 0x28),*(undefined4 *)(*param2 + 0xf4));
		  iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                    (param1_01,uVar3,
		                     Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__TryRun__
		                    );
		  if (iVar5 == 0) {
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (param1_01,
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView__Stop__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x118) * 4))
		              (param1_01,*(undefined4 *)(*param1_01 + 0x11c));
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x600531B")]
		[Address(RVA = "0xA0F0", Offset = "0xA0F0", VA = "0xA0F0")]
		public static bool TryRun(IGame game, ArenaCombatModel.AttackRequestedMonster request)
		{
		/* --- GHIDRA: TryRun ---
		undefined4 Gameplay_ArenaCombat_ArenaCombat__TryRun(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a593c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593c1 = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff931b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff931b:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff93a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff93a3:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		  if (DAT_ram_00a593bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a593bc = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,param2,
		             Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  return param1_00;
		}
		*/

		/* --- GHIDRA: TryRun ---
		undefined4 Gameplay_ArenaCombat_ArenaCombat__TryRun(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a593c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593c1 = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff931b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff931b:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80ff93a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff93a3:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_ArenaCombat_ArenaCombat_TypeInfo);
		  if (DAT_ram_00a593bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a593bc = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,param2,
		             Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x600531C")]
		[Address(RVA = "0xA0F1", Offset = "0xA0F1", VA = "0xA0F1")]
		public static bool TryRun(IGame game, ProtoRequestCombatCmd.Types.ArenaCombatTypes type, bool fromArena, [Optional] BackTime awaitBackTime)
		{
			return default(bool);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600531D")]
		[Address(RVA = "0xA0F2", Offset = "0xA0F2", VA = "0xA0F2")]
		public static ICombat Run(IGame game, BackTime awaitBackTime)
		{
		/* --- GHIDRA: Run ---
		void Gameplay_ArenaCombat_ArenaCombat__Run
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__StonesTypes__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnMatchStonesHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseElixirHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseSpellHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnMatchStones__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnUseElixir__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnUseSpell__
		              );
		    DAT_ram_00a593c2 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___get_CombatService
		            (param1,param2,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param4;
		  *(undefined4 *)(param1 + 0x28) = param3;
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseSpellHandler__,0
		               );
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___add_OnUseElixir
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnUseSpell__
		            );
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseElixirHandler__,
		                0);
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___add_OnTurn
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnUseElixir__
		            );
		  uVar1 = unnamed_function_1417(System_Action_int__StonesTypes__bool__TypeInfo);
		  System_Action_InputUser__Int32Enum__object___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnMatchStonesHandler__,0
		            );
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___UnlistenEvents
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__add_OnMatchStones__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArenaCombatModel.AttackRequestedMonster _monsterRequest;

		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ArenaCombatModel.ArenaCombatRequested _arenaRequest;

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ArenaCombatEventStatisticsObserver _eventStatisticsObserver;
	}
}
