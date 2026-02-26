using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.BlitzTournament.Controller;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BlitzTournament
{
	// Token: 0x02000BBE RID: 3006
	[Token(Token = "0x2000BBE")]
	public class BlitzTournamentCombat : AbstractCombat<BlitzTournamentCombatModel, BlitzTournamentCombatEvents, BlitzTournamentCombatController, BlitzTournamentCombatMediator, OneOnOneCombatView>
	{
		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060049C1 RID: 18881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE5")]
		public BlitzTournamentCombatEvents Events
		{
			[Token(Token = "0x60049C0")]
			[Address(RVA = "0x9832", Offset = "0x9832", VA = "0x9832")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x9833", Offset = "0x9833", VA = "0x9833")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x17000EE6")]
		public bool IsWaiting
		{
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x9834", Offset = "0x9834", VA = "0x9834")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x9835", Offset = "0x9835", VA = "0x9835", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_BlitzTournament_BlitzTournamentCombat__InitMVC(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__Dispose__
		              );
		    DAT_ram_00a60890 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x9836", Offset = "0x9836", VA = "0x9836", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_BlitzTournament_BlitzTournamentCombat__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a60891 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a60891 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x9837", Offset = "0x9837", VA = "0x9837")]
		public BlitzTournamentCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_BlitzTournament_BlitzTournamentCombat___ctor
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  
		  uVar1 = 1;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (param2 != *(longlong *)(*(int *)(*(int *)(iVar2 + 0x34) + 0xc) + 0x10)) {
		    iVar2 = *(int *)(param1 + 0x14);
		    uVar1 = (uint)(*(longlong *)(*(int *)(*(int *)(iVar2 + 0x34) + 0xc) + 0x10) == param2);
		    if (uVar1 == 0) {
		      iVar2 = 0;
		    }
		  }
		  *param3 = iVar2;
		  return uVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		uint Gameplay_BlitzTournament_BlitzTournamentCombat__set_Events(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  if (DAT_ram_00a6088e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    DAT_ram_00a6088e = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    return 1;
		  }
		  fVar1 = func_ii_7103(*(int *)(param1 + 0x14),0);
		  return (uint)(0.0 < fVar1);
		}
		*/


		/* --- GHIDRA: get_IsWaiting ---
		void Gameplay_BlitzTournament_BlitzTournamentCombat__get_IsWaiting(int param1,undefined4 param2)
		
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
		  
		  if (DAT_ram_00a6088f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Events_BlitzTournamentCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Model_BlitzTournamentCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_ServiceFactory_GetService_BlitzTournamentService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a6088f = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_BlitzTournament_Events_BlitzTournamentCombatEvents_TypeInfo);
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
		        goto code_r0x81cf1c35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x81cf1c35:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x81cf1cbd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf1cbd:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x81cf1d42;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x81cf1d42:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x81cf1dca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x81cf1dca:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x81cf1e4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf1e4f:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x81cf1ed4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x81cf1ed4:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x81cf1f59;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cf1f59:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x81cf1fd9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x81cf1fd9:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x81cf205e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x81cf205e:
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
		  param1_00 = unnamed_function_1417
		                        (Gameplay_BlitzTournament_Model_BlitzTournamentCombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 5;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BlitzTournamentService___);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  iVar7 = unnamed_function_1417
		                    (Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_TypeInfo);
		  if (DAT_ram_00a608b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents___ctor__
		              );
		    DAT_ram_00a608b5 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar3,uVar5,uVar8,
		             Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar2;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_TypeInfo);
		  if (DAT_ram_00a608b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController___ctor__
		              );
		    DAT_ram_00a608b9 = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,uVar8,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

}
