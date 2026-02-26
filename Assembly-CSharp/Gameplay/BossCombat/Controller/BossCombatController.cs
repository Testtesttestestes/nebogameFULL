using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using ServicesNamespace;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	public class BossCombatController : CombatController<BossCombatModel, BossCombatEvents>
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0x947F", Offset = "0x947F", VA = "0x947F")]
		public BossCombatController(ICombatService service, BossCombatModel model, BossCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_Controller_BossCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5798d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossCombatModel__BossCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    DAT_ram_00a5798d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_BossCombatModel__BossCombatEvents__StartAwaitJumpToCombatEvent__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x9480", Offset = "0x9480", VA = "0x9480", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_BossCombat_Controller_BossCombatController__HandleRun
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5798e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController___ctor__
		              );
		    DAT_ram_00a5798e = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
