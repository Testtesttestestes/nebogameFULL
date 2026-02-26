using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C67 RID: 3175
	[Token(Token = "0x2000C67")]
	public class BankPromotionsViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankPromotionsView>
	{
		// Token: 0x06004D93 RID: 19859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x9BCB", Offset = "0x9BCB", VA = "0x9BCB")]
		public BankPromotionsViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankPromotionsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59801 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView__get_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ViewOnShowInfoEvent__);
		    DAT_ram_00a59801 = '\x01';
		  }
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[5],0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = unnamed_function_1417(System_Action_PromotionsDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar6,param1,
		               Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ViewOnShowInfoEvent__,0);
		    if (DAT_ram_00a597a0 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		      DAT_ram_00a597a0 = '\x01';
		    }
		    iVar3 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar4 = 0;
		      iVar7 = func_ii_7048(iVar3,uVar6,0);
		      uVar2 = System_Action_PromotionsDic__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_PromotionsDic__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar5 + 0x1c,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param2,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = unnamed_function_1417(System_Action_PromotionsDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar6,param1,
		               Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ViewOnShowInfoEvent__,0);
		    if (DAT_ram_00a5979f == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		      DAT_ram_00a5979f = '\x01';
		    }
		    iVar3 = *(int *)(iVar5 + 0x1c);
		    do {
		      iVar4 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar6,0);
		      uVar2 = System_Action_PromotionsDic__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_PromotionsDic__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar5 + 0x1c,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    iVar5 = *param1;
		    uVar6 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x14c));
		    Gameplay_Bank_Controller_BankController__SetOptionsRewards(uVar6,iVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB7 RID: 4023
		// (set) Token: 0x06004D94 RID: 19860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB7")]
		public override BankPromotionsView View
		{
			[Token(Token = "0x6004D94")]
			[Address(RVA = "0x9BCC", Offset = "0x9BCC", VA = "0x9BCC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB8")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D95")]
			[Address(RVA = "0x9BCD", Offset = "0x9BCD", VA = "0x9BCD", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x9BCE", Offset = "0x9BCE", VA = "0x9BCE")]
		private void ActivePromotionsReceivedEvent()
		{
		/* --- GHIDRA: ActivePromotionsReceivedEvent ---
		void Gameplay_Bank_Controller_BankPromotionsViewMediator__ActivePromotionsReceivedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Bank_View_BankPromotionInfoWindow__get_WindowId(param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x9BCF", Offset = "0x9BCF", VA = "0x9BCF")]
		private void ViewOnShowInfoEvent(PromotionsDic promotionsDic)
		{
		/* --- GHIDRA: ViewOnShowInfoEvent ---
		void Gameplay_Bank_Controller_BankPromotionsViewMediator__ViewOnShowInfoEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59804 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__get_Model__
		              );
		    DAT_ram_00a59804 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (DAT_ram_00a597b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		    DAT_ram_00a597b7 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(iVar1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__Dispose__
		            );
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x18),0);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankPromotionsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59802 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ActivePromotionsReceivedEvent__
		              );
		    DAT_ram_00a59802 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ActivePromotionsReceivedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankPromotionsViewMediator_ActivePromotionsReceivedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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
		void Gameplay_Bank_Controller_BankPromotionsViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59803 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView__get_Model__
		              );
		    DAT_ram_00a59803 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Bank_View_BankPromotionsView__OnDestroy
		            (param1_00,*(undefined4 *)(param1[2] + 0x14),param1);
		  return;
		}
		*/

}
