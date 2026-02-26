using System;
using System.Collections;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.TutorialCombatV2.Model;
using Il2CppDummyDll;
using ServicesNamespace;
using UnityEngine;

namespace Gameplay.TutorialCombatV2.Control
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	public class TutorialCombatController : CombatController<TutorialCombatModel, TutorialCombatEvents>
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x6BCA", Offset = "0x6BCA", VA = "0x6BCA", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58427 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents___ctor__
		              );
		    DAT_ram_00a58427 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x6BCB", Offset = "0x6BCB", VA = "0x6BCB")]
		public TutorialCombatController(ICombatService service, TutorialCombatModel model, TutorialCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58428 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58428 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents__StartAwaitJumpToCombatEvent__
		            );
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		  ServicesNamespace_TutorialService__LogTutorialStep(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x6BCC", Offset = "0x6BCC", VA = "0x6BCC", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x6BCD", Offset = "0x6BCD", VA = "0x6BCD", Slot = "14")]
		protected override void HandleSetDrop(GameOverData data)
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x6BCE", Offset = "0x6BCE", VA = "0x6BCE", Slot = "13")]
		protected override void HandleRewardsGot()
		{
		/* --- GHIDRA: HandleRewardsGot ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatController__HandleRewardsGot
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58429 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		              );
		    DAT_ram_00a58429 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = 0x40200000;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x6BCF", Offset = "0x6BCF", VA = "0x6BCF")]
		public void RunComplete()
		{
		/* --- GHIDRA: RunComplete ---
		int Gameplay_TutorialCombatV2_Control_TutorialCombatController__RunComplete
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58429 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		              );
		    DAT_ram_00a58429 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x6BD0", Offset = "0x6BD0", VA = "0x6BD0")]
		private IEnumerator CombatCompleteCoroutine(float delay)
		{
			return null;
		}

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		public const float COMBAT_COMPLETE_DELAY = 2.5f;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _runCompleteCoroutine;
	}
}
