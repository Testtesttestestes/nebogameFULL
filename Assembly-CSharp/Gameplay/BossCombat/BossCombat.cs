using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Boss.Model;
using Gameplay.BossCombat.Controller;
using Gameplay.BossCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BossCombat
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public class BossCombat : AbstractCombat<BossCombatModel, BossCombatEvents, BossCombatController, BossCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x945C", Offset = "0x945C", VA = "0x945C", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBE")]
		public BossInstanceModel BossInstanceModel
		{
			[Token(Token = "0x60045BB")]
			[Address(RVA = "0x945D", Offset = "0x945D", VA = "0x945D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045BC")]
			[Address(RVA = "0x945E", Offset = "0x945E", VA = "0x945E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBF")]
		public BossCombatEvents Events
		{
			[Token(Token = "0x60045BD")]
			[Address(RVA = "0x945F", Offset = "0x945F", VA = "0x945F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045BE")]
			[Address(RVA = "0x9460", Offset = "0x9460", VA = "0x9460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x9461", Offset = "0x9461", VA = "0x9461", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_BossCombat_BossCombat__InitMVC
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a57980 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a57980 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param4,param5,param6,
		             Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param3;
		  return;
		}
		*/

		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x9462", Offset = "0x9462", VA = "0x9462")]
		public BossCombat(IGame game, BossInstanceModel bossInstanceModel, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_BossCombat_BossCombat__set_Events(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param12;
		  
		  if (DAT_ram_00a5797f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Controller_BossCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Model_BossCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Factories_BossCombatSpellDataFactory_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Controller_BossCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11974);
		    DAT_ram_00a5797f = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_BossCombat_BossCombatEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Factories_CombatPlayerFactory_TypeInfo);
		  uVar6 = *(undefined4 *)(param1 + 0x28);
		  iVar3 = unnamed_function_1417(Gameplay_BossCombat_Factories_BossCombatSpellDataFactory_TypeInfo);
		  *(undefined4 *)(iVar3 + 8) = uVar6;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x158);
		        goto code_r0x80e0acfc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e0acfc:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar6 = *(undefined4 *)(iVar8 + 0x14);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80e0ad84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0ad84:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x220);
		        goto code_r0x80e0ae09;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e0ae09:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar9 = *(undefined4 *)(iVar8 + 0x18);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x148);
		        goto code_r0x80e0ae91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80e0ae91:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80e0af16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0af16:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x188);
		        goto code_r0x80e0af9b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80e0af9b:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x80e0b020;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e0b020:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		        goto code_r0x80e0b0a0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,5);
		code_r0x80e0b0a0:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x150);
		        goto code_r0x80e0b125;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80e0b125:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param12 = *(undefined4 *)(iVar8 + 0x10);
		  iVar8 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (iVar8,param1,uVar2,iVar3,uVar6,uVar5,uVar9,param8,param9,param10,param11,param12,0);
		  uVar2 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar2,StringLiteral_11974,StringLiteral_1773,0);
		  uVar2 = Utils_LocalProps___ctor(uVar2,0);
		  *(undefined4 *)(iVar8 + 0x34) = uVar2;
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar6 = *(undefined4 *)(param1 + 8);
		  uVar5 = *(undefined4 *)(param1 + 0x14);
		  iVar3 = unnamed_function_1417(Gameplay_BossCombat_Model_BossCombatModel_TypeInfo);
		  Gameplay_Combat_Model_CombatModel__Dispose(iVar3,iVar8,uVar5,uVar6,uVar2,0);
		  iVar8 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar8 + 0x10) = 2;
		  *(int *)(iVar3 + 0x50) = iVar8;
		  iVar8 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar8 + 0x10) = 7;
		  *(int *)(iVar3 + 0x54) = iVar8;
		  *(int *)(param1 + 0x18) = iVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar5 = *(undefined4 *)(param1 + 0x2c);
		  uVar9 = *(undefined4 *)(param1 + 0x18);
		  uVar6 = unnamed_function_1417(Gameplay_BossCombat_Controller_BossCombatController_TypeInfo);
		  if (DAT_ram_00a5798c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossCombatModel__BossCombatEvents___ctor__
		              );
		    DAT_ram_00a5798c = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (uVar6,uVar2,uVar9,uVar5,
		             Method_Gameplay_Combat_Control_CombatController_BossCombatModel__BossCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar6;
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar9 = *(undefined4 *)(param1 + 0x2c);
		  uVar2 = unnamed_function_1417(Gameplay_BossCombat_Controller_BossCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a5798e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController___ctor__
		              );
		    DAT_ram_00a5798e = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (uVar2,uVar5,uVar9,uVar6,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

}
