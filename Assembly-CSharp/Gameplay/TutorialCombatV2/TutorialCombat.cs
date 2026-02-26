using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Gameplay.TutorialCombatV2.Control;
using Gameplay.TutorialCombatV2.Model;
using Gameplay.TutorialV2.Controller;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.TutorialCombatV2
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	public class TutorialCombat : AbstractCombat<TutorialCombatModel, TutorialCombatEvents, TutorialCombatController, TutorialCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		public TutorialCombatEvents Events
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x6B59", Offset = "0x6B59", VA = "0x6B59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x6B5A", Offset = "0x6B5A", VA = "0x6B5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x6B5B", Offset = "0x6B5B", VA = "0x6B5B", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialCombatV2_TutorialCombat__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  int param1_01;
		  undefined8 param4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param7;
		  uint uVar8;
		  
		  if (DAT_ram_00a583e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialCombatV2_Control_TutorialCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialCombatV2_TutorialCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialCombatV2_Model_TutorialCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_UserSettingsStub_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a583e6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_TutorialCombatV2_TutorialCombatEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x80ee1e8b;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80ee1e8b:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar8 = 0;
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80ee1f13;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ee1f13:
		  uVar8 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x220);
		        goto code_r0x80ee1f98;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80ee1f98:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  param7 = *(undefined4 *)(iVar6 + 0x18);
		  uVar8 = 0;
		  param1_00 = unnamed_function_1417(Core_Data_User_UserSettingsStub_TypeInfo);
		  Core_Data_User_UserSettingsStub__CommitSettings(param1_00,0);
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80ee2033;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ee2033:
		  uVar8 = 0;
		  param9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x188);
		        goto code_r0x80ee20b8;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80ee20b8:
		  uVar8 = 0;
		  param10 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = *(int **)(param1 + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80ee213d;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ee213d:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar8 = 0;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x80ee21bf;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x80ee21bf:
		  param11 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  param1_01 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies___ctor
		            (param1_01,param1,uVar1,uVar2,uVar7,uVar4,param7,param1_00,param9,param10,param11,0);
		  uVar1 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar1,StringLiteral_11974,StringLiteral_1773,0);
		  uVar1 = Utils_LocalProps___ctor(uVar1,0);
		  *(undefined4 *)(param1_01 + 0x34) = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 8);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar7 = *(undefined4 *)(param1 + 0x14);
		  iVar6 = unnamed_function_1417(Gameplay_TutorialCombatV2_Model_TutorialCombatModel_TypeInfo);
		  *(undefined1 *)(iVar6 + 0x5c) = 1;
		  Gameplay_Combat_Model_CombatModel__Dispose(iVar6,param1_01,uVar7,uVar2,uVar1,0);
		  uVar1 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,0);
		  *(undefined4 *)(iVar6 + 0x50) = uVar1;
		  uVar1 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,0);
		  *(undefined4 *)(iVar6 + 0x54) = uVar1;
		  *(int *)(param1 + 0x18) = iVar6;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    iVar6 = *(int *)(param1 + 0x18);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  uVar7 = **(undefined4 **)(Core_Net_ServiceFactory_TypeInfo + 0x5c);
		  param4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                     (*(undefined4 *)(iVar6 + 8),0);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService_TypeInfo)
		  ;
		  Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__RewardsGot
		            (uVar1,uVar7,uVar2,param4,iVar6);
		  uVar7 = *(undefined4 *)(param1 + 0x28);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_TutorialCombatV2_Control_TutorialCombatController_TypeInfo)
		  ;
		  if (DAT_ram_00a58427 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents___ctor__
		              );
		    DAT_ram_00a58427 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (uVar2,uVar1,uVar4,uVar7,
		             Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a5842b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController___ctor__
		              );
		    DAT_ram_00a5842b = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar1,uVar7,uVar4,uVar2,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x6B5C", Offset = "0x6B5C", VA = "0x6B5C", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_TutorialCombatV2_TutorialCombat__InitMVC
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a583e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a583e7 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param3,param4,param5,param6,
		             Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x6B5D", Offset = "0x6B5D", VA = "0x6B5D")]
		public TutorialCombat(TutorialStepsConveyor conveyor, IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x2C")]
		public TutorialStepsConveyor _guideStepsConveyor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_TutorialCombatV2_TutorialCombat__set_Events(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a583e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__Dispose__
		              );
		    DAT_ram_00a583e5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  return;
		}
		*/

}
