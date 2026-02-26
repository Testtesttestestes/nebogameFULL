using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	public class EndlessPaymentOptionListTitleLayoutView : MonoBehaviourWithStates<EndlessPaymentOptionListTitleLayoutView.States>
	{
		// Token: 0x06003152 RID: 12626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x81AA", Offset = "0x81AA", VA = "0x81AA")]
		public EndlessPaymentOptionListTitleLayoutView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionListTitleLayoutView___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xd],0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(*(double *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8) <= 0.0),0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xc],0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(0.0 < *(double *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8)),0);
		    iVar3 = param1[0xe];
		    uVar2 = Core_Extensions_Dict_EndlessPaymentOptionListDicExt__GetDiscountChanceDescription
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x70),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar3,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0x15],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(*(int *)(*(int *)(iVar1 + 0xc) + 0xc) != 0),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0x14],0);
		    if (*(int *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x70) + 0x10) == 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar4 = (uint)(0.0 < *(double *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x18) + 8));
		    }
		    else {
		      uVar4 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,uVar4,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawNextArrow
		              (param1,uVar2,param1);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawLock(param1,uVar2,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0x10],0);
		    if (*(int *)(*(int *)(iVar1 + 0xc) + 8) == 0) {
		      uVar4 = (uint)(*(char *)(iVar1 + 0x18) != '\0');
		    }
		    else {
		      uVar4 = 1;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,uVar4,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawVipPoints
		              (param1,uVar2,param1);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__HandleDataChanged
		              (param1,uVar2,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (*(char *)(iVar1 + 0x20) != '\0') {
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x134));
		      Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawResourceAmount
		                (param1,param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x02000830 RID: 2096
		[Token(Token = "0x2000830")]
		public enum States
		{
			// Token: 0x04001AEF RID: 6895
			[Token(Token = "0x4001AEF")]
			None,
			// Token: 0x04001AF0 RID: 6896
			[Token(Token = "0x4001AF0")]
			Default,
			// Token: 0x04001AF1 RID: 6897
			[Token(Token = "0x4001AF1")]
			Discount
		}
	}
}
