using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Duel;
using ServicesNamespace;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	public class DuelCombatController : CombatController<CombatModel, CombatEvents>
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x82BD", Offset = "0x82BD", VA = "0x82BD")]
		public DuelCombatController(DuelService duelService, ICombatService service, CombatModel model, CombatEvents events, bool showCombatWaitWindow)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Controller_DuelCombatController___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57bda == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    DAT_ram_00a57bda = '\x01';
		  }
		  fVar1 = func_ii_7103(param2,0);
		  if (0.0 < fVar1) {
		    Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    if ((char)param1[8] != '\0') {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x18);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003269")]
		[Address(RVA = "0x82BE", Offset = "0x82BE", VA = "0x82BE", Slot = "17")]
		protected override void HandleAwait(BackTime timeout)
		{
		/* --- GHIDRA: HandleAwait ---
		void Gameplay_Duel_Controller_DuelCombatController__HandleAwait(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57bdb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelCombatController_PaidOffEventHandler__);
		    DAT_ram_00a57bdb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *param1;
		  if (*(int *)(iVar1 + 0x40) == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  iVar1 = param1[9];
		  param1_00 = unnamed_function_1417(System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Duel_Controller_DuelCombatController_PaidOffEventHandler__,0);
		  ServicesNamespace_DuelService__remove_NewDuelEvent(iVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326A")]
		[Address(RVA = "0x82BF", Offset = "0x82BF", VA = "0x82BF", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Duel_Controller_DuelCombatController__HandleRun(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57bdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelCombatController_PaidOffEventHandler__);
		    DAT_ram_00a57bdc = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__HandleStop__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = param1[9];
		  uVar2 = unnamed_function_1417(System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Duel_Controller_DuelCombatController_PaidOffEventHandler__
		             ,0);
		  ServicesNamespace_DuelService__add_PaidOffEvent(iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326B")]
		[Address(RVA = "0x82C0", Offset = "0x82C0", VA = "0x82C0", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Duel_Controller_DuelCombatController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57bdd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a57bdd = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80e33597;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80e33597:
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
		        goto code_r0x80e33635;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80e33635:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600326C RID: 12908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326C")]
		[Address(RVA = "0x82C1", Offset = "0x82C1", VA = "0x82C1")]
		private void PaidOffEventHandler(ProtoDuelPaidOffEvt evt)
		{
		/* --- GHIDRA: PaidOffEventHandler ---
		void Gameplay_Duel_Controller_DuelCombatController__PaidOffEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bde == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__Dispose__
		              );
		    DAT_ram_00a57bde = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x0600326D RID: 12909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326D")]
		[Address(RVA = "0x82C2", Offset = "0x82C2", VA = "0x82C2", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Duel_Controller_DuelCombatController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57bdf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_CombatModel__CombatEvents__DuelCombatController___ctor__
		              );
		    DAT_ram_00a57bdf = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_CombatModel__CombatEvents__DuelCombatController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool _showCombatWait;

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x24")]
		private DuelService _duelService;
	}
}
