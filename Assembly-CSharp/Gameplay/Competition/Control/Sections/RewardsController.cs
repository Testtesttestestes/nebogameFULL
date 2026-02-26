using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090D RID: 2317
	[Token(Token = "0x200090D")]
	public class RewardsController : AbstractController<RewardsModel, RewardsEvents>
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x8687", Offset = "0x8687", VA = "0x8687")]
		public RewardsController(RewardsModel model, RewardsEvents events)
		{
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x8688", Offset = "0x8688", VA = "0x8688", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Competition_Control_Sections_RewardsController__HandleRun
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63b06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_RewardsModel__RewardsEvents__RewardsController__RewardsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_PrizeListElement___);
		    DAT_ram_00a63b06 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_PrizeListElement___;
		  iVar1 = *(int *)(Method_System_Array_Empty_PrizeListElement___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_PrizeListElement___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  *(undefined4 *)(param1 + 0x1c) = **(undefined4 **)(iVar2 + 0x5c);
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_RewardsModel__RewardsEvents__RewardsController__RewardsView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
