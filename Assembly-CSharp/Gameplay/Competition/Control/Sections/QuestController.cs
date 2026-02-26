using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2000907")]
	public class QuestController : AbstractController<QuestModel, QuestEvents>
	{
		// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x8664", Offset = "0x8664", VA = "0x8664")]
		public QuestController(QuestModel model, QuestEvents events)
		{
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x8665", Offset = "0x8665", VA = "0x8665", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Competition_Control_Sections_QuestController__HandleRun
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63aee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_QuestModel__QuestEvents__QuestController__QuestsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Sorting_QuestComparer_TypeInfo);
		    DAT_ram_00a63aee = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Sorting_QuestComparer_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_QuestModel__QuestEvents__QuestController__QuestsView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
