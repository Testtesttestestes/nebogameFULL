using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Boss;
using ServicesNamespace;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x2000B44")]
	public class BossMinionCombatController : CombatController<BossMinionCombatModel, BossMinionCombatEvents>
	{
		// Token: 0x060045E3 RID: 17891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x9485", Offset = "0x9485", VA = "0x9485", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_BossCombat_Controller_BossMinionCombatController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57993 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents___ctor__
		              );
		    DAT_ram_00a57993 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x9486", Offset = "0x9486", VA = "0x9486")]
		public BossMinionCombatController(BossService bossService, ICombatService service, BossMinionCombatModel model, BossMinionCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_Controller_BossMinionCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57994 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BossCombat_Controller_BossMinionCombatController_BossServiceOnMinionAttackServerCancelationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    DAT_ram_00a57994 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) == 0) {
		    Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  iVar1 = param1[8];
		  param1_00 = unnamed_function_1417(System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_BossCombat_Controller_BossMinionCombatController_BossServiceOnMinionAttackServerCancelationEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_MinionAttackEvent(iVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x9487", Offset = "0x9487", VA = "0x9487", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_BossCombat_Controller_BossMinionCombatController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57995 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BossCombat_Controller_BossMinionCombatController_BossServiceOnMinionAttackServerCancelationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__HandleStop__
		              );
		    DAT_ram_00a57995 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__HandleStop__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_BossCombat_Controller_BossMinionCombatController_BossServiceOnMinionAttackServerCancelationEvent__
		             ,0);
		  ServicesNamespace_BossService__add_MinionAttackServerCancelationEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x9488", Offset = "0x9488", VA = "0x9488", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_BossCombat_Controller_BossMinionCombatController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar4;
		  
		  if (DAT_ram_00a57996 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3964);
		    DAT_ram_00a57996 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar1 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_3964,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar2 + 0x50);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80e0c8b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80e0c8b8:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e0c956;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80e0c956:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x9489", Offset = "0x9489", VA = "0x9489")]
		private void BossServiceOnMinionAttackServerCancelationEvent(MinionAttackServerCancelationEvt evt)
		{
		/* --- GHIDRA: BossServiceOnMinionAttackServerCancelationEvent ---
		void Gameplay_BossCombat_Controller_BossMinionCombatController__BossServiceOnMinionAttackServerCancelationEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57997 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController___ctor__
		              );
		    DAT_ram_00a57997 = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x20")]
		private BossService _bossService;
	}
}
