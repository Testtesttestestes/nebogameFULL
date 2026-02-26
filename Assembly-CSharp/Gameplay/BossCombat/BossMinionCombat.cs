using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.BossCombat.Controller;
using Gameplay.BossCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BossCombat
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	public class BossMinionCombat : AbstractCombat<BossMinionCombatModel, BossMinionCombatEvents, BossMinionCombatController, BossMinionCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC0")]
		public BossMinionCombatEvents Events
		{
			[Token(Token = "0x60045C2")]
			[Address(RVA = "0x9464", Offset = "0x9464", VA = "0x9464")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045C3")]
			[Address(RVA = "0x9465", Offset = "0x9465", VA = "0x9465")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x9466", Offset = "0x9466", VA = "0x9466", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_BossCombat_BossMinionCombat__InitMVC
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a57982 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a57982 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x9467", Offset = "0x9467", VA = "0x9467")]
		public BossMinionCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_BossCombat_BossMinionCombat__set_Events(int param1,undefined4 param2)
		
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
		  
		  if (DAT_ram_00a57981 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__BossMinionCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BossCombat_Controller_BossMinionCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossMinionCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Model_BossMinionCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BossCombat_Controller_BossMinionCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BossService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a57981 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_BossCombat_BossMinionCombatEvents_TypeInfo);
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
		        goto code_r0x80e0b4f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e0b4f9:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e0b581;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0b581:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80e0b606;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e0b606:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80e0b68e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80e0b68e:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e0b713;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0b713:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80e0b798;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80e0b798:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80e0b81d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e0b81d:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80e0b89d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80e0b89d:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80e0b922;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e0b922:
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
		  param1_00 = unnamed_function_1417(Gameplay_BossCombat_Model_BossMinionCombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar3,uVar2,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 9;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BossService___);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  iVar7 = unnamed_function_1417(Gameplay_BossCombat_Controller_BossMinionCombatController_TypeInfo);
		  if (DAT_ram_00a57993 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents___ctor__
		              );
		    DAT_ram_00a57993 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar3,uVar5,uVar8,
		             Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar7 + 0x20) = uVar2;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_BossCombat_Controller_BossMinionCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a57997 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController___ctor__
		              );
		    DAT_ram_00a57997 = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar3,uVar8,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

}
