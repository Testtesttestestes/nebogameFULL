using System;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ArenaCombat;
using Gameplay.Combat;
using Gameplay.ThemeDuelCombat.Control;
using Gameplay.ThemeDuelCombat.Model;
using Gameplay.ThemeDuelCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ThemeDuelCombat
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public class ThemeDuelCombat : AbstractCombat<ThemeDuelCombatModel, ThemeDuelCombatEvents, ThemeDuelCombatController, ThemeDuelCombatViewMediator, ThemeDuelCombatView>
	{
		// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x6EEF", Offset = "0x6EEF", VA = "0x6EEF")]
		public ThemeDuelCombat(IGame game, UserData loggedUser, UserData user, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, BackTime awaitBackTime)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelCombat_ThemeDuelCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param10;
		  undefined4 param11;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 uVar11;
		  undefined4 param12;
		  int iVar12;
		  int iVar13;
		  
		  if (DAT_ram_00a5859c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelCombat_ThemeDuelCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a5859c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_ThemeDuelCombat_ThemeDuelCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x158);
		        goto code_r0x80f0a25b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f0a25b:
		  iVar9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar10 = *(undefined4 *)(iVar9 + 0x14);
		  uVar1 = 0;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80f0a2e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f0a2e3:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x220);
		        goto code_r0x80f0a368;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80f0a368:
		  iVar9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar11 = *(undefined4 *)(iVar9 + 0x18);
		  uVar1 = 0;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x148);
		        goto code_r0x80f0a3f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80f0a3f0:
		  uVar1 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80f0a475;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f0a475:
		  uVar1 = 0;
		  uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x188);
		        goto code_r0x80f0a4fa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80f0a4fa:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		        goto code_r0x80f0a57f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f0a57f:
		  piVar8 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar1 = 0;
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe8);
		        goto code_r0x80f0a5ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,5);
		code_r0x80f0a5ff:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x150);
		        goto code_r0x80f0a684;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f0a684:
		  iVar9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  param12 = *(undefined4 *)(iVar9 + 0x10);
		  uVar1 = 0;
		  iVar9 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar9,param1,uVar2,uVar3,uVar10,uVar5,uVar11,uVar6,uVar7,param10,param11,param12,0);
		  uVar2 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar2,StringLiteral_11974,StringLiteral_1773,0);
		  uVar2 = Utils_LocalProps___ctor(uVar2,0);
		  *(undefined4 *)(iVar9 + 0x34) = uVar2;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar12 = *piVar8;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x288);
		        goto code_r0x80f0a765;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0a765:
		  iVar12 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar2 = *(undefined4 *)(iVar12 + 0x14);
		  uVar1 = 0;
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar12 = *piVar8;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x288);
		        goto code_r0x80f0a7ed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0a7ed:
		  iVar12 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar3 = *(undefined4 *)(iVar12 + 0x18);
		  uVar1 = 0;
		  uVar10 = *(undefined4 *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(param1 + 8);
		  uVar11 = *(undefined4 *)(param1 + 0x14);
		  uVar6 = *(undefined4 *)(param1 + 0x2c);
		  piVar8 = *(int **)(param1 + 0x24);
		  iVar12 = *piVar8;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x1f8);
		        goto code_r0x80f0a891;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f0a891:
		  iVar12 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  iVar13 = **(int **)(iVar12 + 0x14);
		  iVar12 = (**(code **)((ulonglong)*(uint *)(iVar13 + 0x100) * 4))
		                     (*(int **)(iVar12 + 0x14),*(undefined4 *)(iVar13 + 0x104));
		  uVar7 = *(undefined4 *)(iVar12 + 0x28);
		  iVar12 = unnamed_function_1417(Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel_TypeInfo);
		  Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__Dispose
		            (iVar12,iVar9,uVar2,uVar3,uVar6,uVar11,uVar5,uVar10,uVar7,iVar12);
		  iVar9 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar9 + 0x10) = 2;
		  *(int *)(iVar12 + 0x50) = iVar9;
		  iVar9 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar9 + 0x10) = 0xe;
		  *(int *)(iVar12 + 0x54) = iVar9;
		  *(int *)(param1 + 0x18) = iVar12;
		  uVar2 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_TypeInfo);
		  Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__remove_OnScoreChanged
		            (uVar2,param2_00,0);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar10 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo)
		  ;
		  Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__TryGetCurrentDuel
		            (uVar3,uVar2,uVar5,param2_00,uVar10,uVar3);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  uVar10 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a585af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView___ctor__
		              );
		    DAT_ram_00a585af = '\x01';
		  }
		  HuaweiMobileServices_Drive_AbstractJsonClientRequest___Il2CppFullySharedGenericType____ctor
		            (uVar2,uVar10,param2_00,uVar3,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x6EF0", Offset = "0x6EF0", VA = "0x6EF0", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_ThemeDuelCombat_ThemeDuelCombat__InitMVC(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5859d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__Dispose__
		              );
		    DAT_ram_00a5859d = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x28);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x6EF1", Offset = "0x6EF1", VA = "0x6EF1", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_ThemeDuelCombat_ThemeDuelCombat__Dispose
		              (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5859e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelCombat_ThemeDuelCombat_TypeInfo);
		    DAT_ram_00a5859e = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f0ac9d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0ac9d:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f0ad25;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0ad25:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_ThemeDuelCombat_ThemeDuelCombat_TypeInfo);
		  if (DAT_ram_00a5859b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		              );
		    DAT_ram_00a5859b = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,param3,
		             Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		            );
		  param1_00[0xb] = param2;
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f0adf3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0adf3:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt
		                    (*(undefined4 *)(iVar5 + 0x14),puVar2);
		  iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                    (param1_00,uVar3,
		                     Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__TryRun__
		                    );
		  if (iVar5 == 0) {
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (param1_00,
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView__Stop__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x6EF2", Offset = "0x6EF2", VA = "0x6EF2")]
		public static bool TryRun(IGame game, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, [Optional] BackTime awaitBackTime)
		{
		/* --- GHIDRA: TryRun ---
		int Gameplay_ThemeDuelCombat_ThemeDuelCombat__TryRun
		              (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5859f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelCombat_ThemeDuelCombat_TypeInfo);
		    DAT_ram_00a5859f = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f0aeda;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0aeda:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f0af62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0af62:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar5 = unnamed_function_1417(Gameplay_ThemeDuelCombat_ThemeDuelCombat_TypeInfo);
		  if (DAT_ram_00a5859b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		              );
		    DAT_ram_00a5859b = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (iVar5,param1,uVar3,uVar4,param2,
		             Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		            );
		  *(undefined4 *)(iVar5 + 0x2c) = 0;
		  return iVar5;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x6EF3", Offset = "0x6EF3", VA = "0x6EF3")]
		public static ICombat Run(IGame game, BackTime awaitBackTime)
		{
			return null;
		}

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ThemeDuelCombatEventStatisticsObserver _eventStatisticsObserver;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ProtoRequestCombatCmd.Types.ArenaCombatTypes _matchmakingWay;
	}
}
