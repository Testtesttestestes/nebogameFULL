using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Duel.Controller;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Duel
{
	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	public class DuelCombat : AbstractCombat<CombatModel, CombatEvents, DuelCombatController, DuelCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x170009E3")]
		public bool IsWaiting
		{
			[Token(Token = "0x6003228")]
			[Address(RVA = "0x827E", Offset = "0x827E", VA = "0x827E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003229")]
		[Address(RVA = "0x827F", Offset = "0x827F", VA = "0x827F", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_Duel_DuelCombat__InitMVC
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a57bc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a57bc1 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(undefined1 *)(param1 + 0x28) = (undefined1)param6;
		  return;
		}
		*/

		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x8280", Offset = "0x8280", VA = "0x8280")]
		public DuelCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, bool isDefender)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Duel_DuelCombat___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bc2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12612);
		    DAT_ram_00a57bc2 = '\x01';
		  }
		  return StringLiteral_12612;
		}
		*/

		}

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x4001B68")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _isDefender;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsWaiting ---
		void Gameplay_Duel_DuelCombat__get_IsWaiting(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  uint uVar2;
		  undefined4 param4;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 param6;
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
		  
		  if (DAT_ram_00a57bc0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Events_CombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Controller_DuelCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Controller_DuelCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_DuelService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a57bc0 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_Combat_Events_CombatEvents_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar4 = unnamed_function_1417(Gameplay_Combat_Factories_CombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80e315ed;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e315ed:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar2 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e31675;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e31675:
		  uVar2 = 0;
		  param6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80e316fa;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e316fa:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar2 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80e31782;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80e31782:
		  uVar2 = 0;
		  param8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e31807;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e31807:
		  uVar2 = 0;
		  param9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80e3188c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80e3188c:
		  uVar2 = 0;
		  param10 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80e31911;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e31911:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  uVar2 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80e31991;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80e31991:
		  uVar2 = 0;
		  param11 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80e31a16;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e31a16:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  param12 = *(undefined4 *)(iVar7 + 0x10);
		  iVar7 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar7,param1,uVar3,uVar4,uVar8,param6,param7,param8,param9,param10,param11,param12,0);
		  uVar3 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar3,StringLiteral_11974,StringLiteral_1773,0);
		  uVar3 = Utils_LocalProps___ctor(uVar3,0);
		  *(undefined4 *)(iVar7 + 0x34) = uVar3;
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  uVar4 = *(undefined4 *)(param1 + 8);
		  uVar8 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_CombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(param1_00,iVar7,uVar8,uVar4,uVar3,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 2;
		  *(int *)(param1_00 + 0x50) = iVar7;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar7 + 0x10) = 10;
		  *(int *)(param1_00 + 0x54) = iVar7;
		  *(int *)(param1 + 0x18) = param1_00;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_DuelService___);
		  uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  bVar1 = *(byte *)(param1 + 0x28);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  iVar7 = unnamed_function_1417(Gameplay_Duel_Controller_DuelCombatController_TypeInfo);
		  if (DAT_ram_00a57bd9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents___ctor__);
		    DAT_ram_00a57bd9 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar7,uVar4,uVar8,param4,
		             Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents___ctor__);
		  *(undefined4 *)(iVar7 + 0x24) = uVar3;
		  *(byte *)(iVar7 + 0x20) = bVar1 ^ 1;
		  *(int *)(param1 + 0x10) = iVar7;
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_Duel_Controller_DuelCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a57bdf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_CombatModel__CombatEvents__DuelCombatController___ctor__
		              );
		    DAT_ram_00a57bdf = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar3,uVar4,param4,iVar7,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_CombatModel__CombatEvents__DuelCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

}
