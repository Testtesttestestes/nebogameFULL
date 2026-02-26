using System;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Discounts.Controller
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public class DiscountsViewMediator : AbstractViewMediator<DiscountsModel, DiscountsEvents, DiscountsController, DiscountsWindow>
	{
		// Token: 0x06003401 RID: 13313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x842E", Offset = "0x842E", VA = "0x842E")]
		public DiscountsViewMediator(DiscountsModel model, DiscountsEvents events, DiscountsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_Controller_DiscountsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57cc8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow__set_View__
		              );
		    DAT_ram_00a57cc8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Discounts_Controller_DiscountsController__HandleDictChanged(uVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000A4E RID: 2638
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4E")]
		public override DiscountsWindow View
		{
			[Token(Token = "0x6003402")]
			[Address(RVA = "0x842F", Offset = "0x842F", VA = "0x842F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4F")]
		public override DiscountsEvents Events
		{
			[Token(Token = "0x6003403")]
			[Address(RVA = "0x8430", Offset = "0x8430", VA = "0x8430", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x8431", Offset = "0x8431", VA = "0x8431")]
		private void DiscountsRequestedEventHandler()
		{
		/* --- GHIDRA: DiscountsRequestedEventHandler ---
		void Gameplay_Discounts_Controller_DiscountsViewMediator__DiscountsRequestedEventHandler
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ccb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo);
		    DAT_ram_00a57ccb = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Discounts_Controller_DiscountsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57cc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Discounts_Controller_DiscountsViewMediator_DiscountsRequestedEventHandler__
		              );
		    DAT_ram_00a57cc9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Discounts_Controller_DiscountsViewMediator_DiscountsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Discounts_Controller_DiscountsViewMediator_DiscountsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Discounts_Controller_DiscountsViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57cca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_DiscountData__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_DiscountData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Discounts_Controller_DiscountsViewMediator___c__DiscountsRequestedEventHandler_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo);
		    DAT_ram_00a57cca = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1[2] + 0x10) + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 == 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,0,0);
		    return;
		  }
		  uVar2 = *(undefined4 *)(param1[2] + 0x10);
		  if (*(int *)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo);
		  }
		  piVar3 = *(int **)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x5c);
		  param1_01 = piVar3[1];
		  iVar1 = Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo);
		      piVar3 = *(int **)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x5c);
		    }
		    iVar1 = *piVar3;
		    param1_01 = unnamed_function_1417(System_Func_DiscountData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_01,iVar1,
		               Method_Gameplay_Discounts_Controller_DiscountsViewMediator___c__DiscountsRequestedEventHandler_b__5_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Discounts_Controller_DiscountsViewMediator___c_TypeInfo + 0x5c) + 4)
		         = param1_01;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,param1_01,Method_System_Linq_Enumerable_OrderBy_DiscountData__uint___);
		  Gameplay_Discounts_View_DiscountsWindow__OnClose(param1_00,uVar2,iVar1);
		  return;
		}
		*/

}
