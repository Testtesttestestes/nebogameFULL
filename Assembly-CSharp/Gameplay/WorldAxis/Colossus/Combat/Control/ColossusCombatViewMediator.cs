using System;
using Gameplay.Combat.Control;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Colossus.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.WorldAxis.Colossus.Combat.Control
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public class ColossusCombatViewMediator : AbstractCombatViewMediator<ColossusCombatModel, ColossusCombatEvents, ColossusCombatController, ColossusCombatView>
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x6519", Offset = "0x6519", VA = "0x6519", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a58c26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView___ctor__
		              );
		    DAT_ram_00a58c26 = '\x01';
		  }
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleTitle
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x34) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x651A", Offset = "0x651A", VA = "0x651A")]
		public ColossusCombatViewMediator(VortexCombatViewMediator mediator, ColossusCombatModel model, ColossusCombatEvents events, ColossusCombatController controller)
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator___ctor
		                (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58c27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView_TypeInfo);
		    DAT_ram_00a58c27 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x34);
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                               (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0x15c));
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView_TypeInfo + 0xb8)
		        ) || (*(int *)(*(int *)(*param1_00 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		public override ColossusCombatView View
		{
			[Token(Token = "0x600132A")]
			[Address(RVA = "0x651B", Offset = "0x651B", VA = "0x651B", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x600132B")]
			[Address(RVA = "0x651C", Offset = "0x651C", VA = "0x651C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public override ColossusCombatEvents Events
		{
			[Token(Token = "0x600132C")]
			[Address(RVA = "0x651D", Offset = "0x651D", VA = "0x651D", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x600132D")]
			[Address(RVA = "0x651E", Offset = "0x651E", VA = "0x651E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x34")]
		private VortexCombatViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator__get_View
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x34),param2,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		int * Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator__set_View
		                (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58c28 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo);
		    DAT_ram_00a58c28 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x34);
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		                               (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0x13c));
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param1_00 + 100) +
		                    (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: set_Events ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator__set_Events
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c29 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12685);
		    DAT_ram_00a58c29 = '\x01';
		  }
		  return StringLiteral_12685;
		}
		*/

}
