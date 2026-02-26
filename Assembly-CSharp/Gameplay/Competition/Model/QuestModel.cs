using System;
using Core.Data;
using Core.Dict;
using Gameplay.DailyQuests;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	public class QuestModel : AbstractModel
	{
		// Token: 0x0600360D RID: 13837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x861A", Offset = "0x861A", VA = "0x861A")]
		public QuestModel(CompetitionModel model, IDailyQuestExtInfoPresenter infoPresenter, IDailyQuestProvider questProvider, IDictProvider dictProvider, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Model_QuestModel___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63ac1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RatingModel_RatingRecord___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_RatingModel_RatingRecord__TypeInfo);
		    DAT_ram_00a63ac1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_RatingModel_RatingRecord__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RatingModel_RatingRecord___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDailyQuestExtInfoPresenter InfoPresenter;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDailyQuestProvider QuestProvider;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		[FieldOffset(Offset = "0x18")]
		public readonly CompetitionModel CompetitionModel;
	}
}
