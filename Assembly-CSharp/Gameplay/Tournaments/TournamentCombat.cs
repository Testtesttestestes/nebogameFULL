using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Gameplay.Tournaments.Controller;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Tournaments
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public class TournamentCombat : AbstractCombat<TournamentCombatModel, TournamentCombatEvents, TournamentCombatController, TournamentCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EC")]
		public TournamentCombatEvents Events
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x6D7E", Offset = "0x6D7E", VA = "0x6D7E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x6D7F", Offset = "0x6D7F", VA = "0x6D7F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x170004ED")]
		public bool IsWaiting
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x6D80", Offset = "0x6D80", VA = "0x6D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x6D81", Offset = "0x6D81", VA = "0x6D81", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_Tournaments_TournamentCombat__InitMVC(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__Dispose__
		              );
		    DAT_ram_00a584e3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x6D82", Offset = "0x6D82", VA = "0x6D82", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tournaments_TournamentCombat__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a584e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a584e4 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x6D83", Offset = "0x6D83", VA = "0x6D83")]
		public TournamentCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		uint Gameplay_Tournaments_TournamentCombat__set_Events(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  if (DAT_ram_00a584e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    DAT_ram_00a584e1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    return 1;
		  }
		  fVar1 = func_ii_7103(*(int *)(param1 + 0x14),0);
		  return (uint)(0.0 < fVar1);
		}
		*/


		/* --- GHIDRA: get_IsWaiting ---
		void Gameplay_Tournaments_TournamentCombat__get_IsWaiting(int param1,undefined4 param2)
		
		{
		  uint uVar1;
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
		  
		  if (DAT_ram_00a584e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TournamentsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Events_TournamentCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Model_TournamentCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a584e2 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Tournaments_Events_TournamentCombatEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80efa426;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80efa426:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80efa4ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80efa4ae:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80efa533;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80efa533:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80efa5bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80efa5bb:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80efa640;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80efa640:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80efa6c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80efa6c5:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80efa74a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80efa74a:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80efa7ca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80efa7ca:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80efa84f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80efa84f:
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
		  param1_00 = unnamed_function_1417(Gameplay_Tournaments_Model_TournamentCombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 6;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TournamentsService___);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  iVar7 = unnamed_function_1417(Gameplay_Tournaments_Controller_TournamentCombatController_TypeInfo)
		  ;
		  if (DAT_ram_00a58515 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents___ctor__
		              );
		    DAT_ram_00a58515 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar3,uVar5,uVar8,
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar2;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Tournaments_Controller_TournamentCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a5851d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController___ctor__
		              );
		    DAT_ram_00a5851d = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,uVar8,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

}
