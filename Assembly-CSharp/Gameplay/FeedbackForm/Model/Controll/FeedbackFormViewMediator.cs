using System;
using Cysharp.Threading.Tasks;
using Gameplay.FeedbackForm.View;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.FeedbackForm.Model.Controll
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public class FeedbackFormViewMediator : AbstractViewMediator<FeedbackFormModel, FeedbackFormEvents, FeedbackFormController, FeedbackFormView>
	{
		// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x8189", Offset = "0x8189", VA = "0x8189")]
		public FeedbackFormViewMediator(FeedbackFormModel model, FeedbackFormEvents events, FeedbackFormController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5760e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFinishRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFormErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleStartRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteSuccessEvent__
		              );
		    DAT_ram_00a5760e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleInitEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFormErrorEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_string__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar5;
		      uVar3 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_string__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteSuccessEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleStartRequestEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x10) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x10) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFinishRequestEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x10) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x10) = piVar4, *piVar4 != iVar1)) {
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
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleInitEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFormErrorEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_string__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar5;
		      uVar3 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_string__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitCompleteSuccessEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0xc);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleStartRequestEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0xc) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleFinishRequestEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x10) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x10) = piVar4, *piVar4 != iVar1))
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

		}

		// Token: 0x170009B0 RID: 2480
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B0")]
		public override FeedbackFormEvents Events
		{
			[Token(Token = "0x6003132")]
			[Address(RVA = "0x818A", Offset = "0x818A", VA = "0x818A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B1")]
		public override FeedbackFormView View
		{
			[Token(Token = "0x6003133")]
			[Address(RVA = "0x818B", Offset = "0x818B", VA = "0x818B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x818C", Offset = "0x818C", VA = "0x818C")]
		private UniTask<bool> HandleCloseFormRequestEvent(FeedbackFormWindow form)
		{
		/* --- GHIDRA: HandleCloseFormRequestEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleCloseFormRequestEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  undefined8 local_10;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57611 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&TMPro_TextMeshProUGUI_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21121);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7792);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57611 = '\x01';
		  }
		  local_8 = 0;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_7792,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_4 = *(int *)(param1[2] + 0xc);
		  iVar4 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  if (iVar4 == 0) {
		    iVar4 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21121,iVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar4 + 0x18) + 0xd0);
		  iVar4 = *piVar6;
		  if (((uint)*(byte *)(iVar4 + 0xb8) < (uint)*(byte *)(TMPro_TextMeshProUGUI_TypeInfo + 0xb8)) ||
		     (*(int *)(*(int *)(iVar4 + 100) + (uint)*(byte *)(TMPro_TextMeshProUGUI_TypeInfo + 0xb8) * 4 +
		              -4) != TMPro_TextMeshProUGUI_TypeInfo)) {
		    System_Activator__CreateInstance(piVar6,TMPro_TextMeshProUGUI_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar6,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x24);
		  local_4 = 0;
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar4 + local_4 * 4 + 0x10);
		      piVar6 = *(int **)(param1[2] + 0x18);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo == *piVar8) {
		            puVar5 = (uint *)(piVar8[1] * 8 + iVar7 + 0xd0);
		            goto code_r0x80db8ef6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar6,
		                                    Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,
		                                    2);
		code_r0x80db8ef6:
		      local_8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		      uVar2 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set
		                        (&local_8,*(undefined4 *)(iVar3 + 0x10),0);
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (iVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,uVar2,0);
		      local_4 = local_4 + 1;
		    } while (local_4 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

			return default(UniTask<bool>);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x818D", Offset = "0x818D", VA = "0x818D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x160);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x160);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__SetCurrentTheme
		            (param1_00,param2_00,param3,*(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x160),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x818E", Offset = "0x818E", VA = "0x818E")]
		private void HandleSubmitClickEvent()
		{
		/* --- GHIDRA: HandleSubmitClickEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleSubmitClickEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57612 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FeedbackThemeOption__get_Item__);
		    DAT_ram_00a57612 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1[2] + 0x1c),param2,
		                     Method_System_Collections_Generic_List_FeedbackThemeOption__get_Item__);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003137 RID: 12599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x818F", Offset = "0x818F", VA = "0x818F")]
		private void HandleThemeValueChangedEvent(int index)
		{
		/* --- GHIDRA: HandleThemeValueChangedEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleThemeValueChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57613 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Cast_TMP_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_TMP_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleInitEvent_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FeedbackThemeOption__FindIndex__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_FeedbackThemeOption__TypeInfo);
		    DAT_ram_00a57613 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_FeedbackForm_Model_FeedbackFormModel__set_CurrentTheme(param1[2],param1);
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(iVar1 + 0x14),uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x20);
		  uVar2 = System_Linq_Enumerable__Cast_DictionaryEntry_
		                    (*(undefined4 *)(param1[2] + 0x1c),
		                     Method_System_Linq_Enumerable_Cast_TMP_Dropdown_OptionData___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_TMP_Dropdown_OptionData___);
		  TMPro_TMP_Dropdown__set_itemImage(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param1[2] + 0x1c);
		  uVar2 = unnamed_function_1417(System_Predicate_FeedbackThemeOption__TypeInfo);
		  func_ii_7297(uVar2,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleInitEvent_b__9_0__
		               ,0);
		  iVar1 = System_Collections_Generic_List_UsageHint___FindAll
		                    (uVar4,uVar2,
		                     Method_System_Collections_Generic_List_FeedbackThemeOption__FindIndex__);
		  if (-1 < iVar1) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    TMPro_TMP_Dropdown__get_value(*(undefined4 *)(iVar3 + 0x20),iVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x8190", Offset = "0x8190", VA = "0x8190")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleInitEvent
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 local_4;
		  
		  if (DAT_ram_00a57614 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Themes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_DialogWindow_DialogWindowArgs__get_CloseButton__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7837);
		    DAT_ram_00a57614 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  local_8 = 0xffffffff;
		  local_c = Gameplay_FeedbackForm_Model_Themes_TypeInfo;
		  local_4 = *(undefined1 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x20);
		  param1_01 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  iVar2 = StringLiteral_5;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (param1_01 == 0) {
		    param1_01 = iVar2;
		  }
		  uVar1 = func_ii_7508(param1_01,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_7837,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  iVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  *(int *)(param1 + 0x18) = iVar2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x8191", Offset = "0x8191", VA = "0x8191")]
		private void HandleStartRequestEvent()
		{
		/* --- GHIDRA: HandleStartRequestEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleStartRequestEvent
		               (int param1,undefined4 param2)
		
		{
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x8192", Offset = "0x8192", VA = "0x8192")]
		private void HandleFinishRequestEvent()
		{
		/* --- GHIDRA: HandleFinishRequestEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleFinishRequestEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57615 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    DAT_ram_00a57615 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x8193", Offset = "0x8193", VA = "0x8193")]
		private void HandleFormErrorEvent(string text)
		{
		/* --- GHIDRA: HandleFormErrorEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleFormErrorEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57616 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    DAT_ram_00a57616 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x8194", Offset = "0x8194", VA = "0x8194")]
		private void HandleSubmitCompleteEvent(string text)
		{
		/* --- GHIDRA: HandleSubmitCompleteEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleSubmitCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__get_text
		            (*(undefined4 *)(iVar1 + 0x18),**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  return;
		}
		*/

		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x8195", Offset = "0x8195", VA = "0x8195")]
		private void HandleSubmitCompleteSuccessEvent()
		{
		/* --- GHIDRA: HandleSubmitCompleteSuccessEvent ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleSubmitCompleteSuccessEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param1_01;
		  int iVar3;
		  uint uVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a57617 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0__ShowCloseWarning_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0__ShowCloseWarning_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_DialogWindow_DialogWindowArgs__get_CloseButton__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4354);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2765);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7790);
		    DAT_ram_00a57617 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param3;
		  iVar1 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2765,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_7790,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_4354,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,param2_00,
		             Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0__ShowCloseWarning_b__1__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar1 + 0x24) = param1_00;
		  iVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar1,0);
		  param1_02 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param2_00,
		             Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0__ShowCloseWarning_b__0__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_02,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x8196", Offset = "0x8196", VA = "0x8196")]
		private void ShowCloseWarning(FeedbackFormWindow feedbackFormWindow, UniTaskCompletionSource<bool> completionSource)
		{
		/* --- GHIDRA: ShowCloseWarning ---
		uint Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__ShowCloseWarning
		               (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  int iVar2;
		  
		  cVar1 = *(char *)(param2 + 0x20);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  return (uint)(cVar1 == *(char *)(iVar2 + 0x2c));
		}
		*/

		}

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x18")]
		private DialogWindow _submitDialogWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a5760f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleCloseFormRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleThemeValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		    DAT_ram_00a5760f = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x1c) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar4,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x20) + 0xd8);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		    UnityEngine_Events_UnityAction_Color___Invoke
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleThemeValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar7,uVar4,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		    System_Func_object__Nullable_ulong____Invoke
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleCloseFormRequestEvent__
		               ,0);
		    if (DAT_ram_00a575e8 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		      DAT_ram_00a575e8 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x28);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar7 = System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo),
		         iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x28,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x1c) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleSubmitClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar4,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x20) + 0xd8);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		    UnityEngine_Events_UnityAction_Color___Invoke
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleThemeValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar7,uVar4,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		    System_Func_object__Nullable_ulong____Invoke
		              (uVar4,param1,
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_HandleCloseFormRequestEvent__
		               ,0);
		    if (DAT_ram_00a575e7 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		      DAT_ram_00a575e7 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x28);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar7 = System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo),
		         iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x28,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleCloseFormRequestEvent
		              (param1,iVar3);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__set_View
		               (undefined8 *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57610 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__get_Task__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TypeInfo);
		    DAT_ram_00a57610 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TypeInfo);
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(*(int *)(*(int *)(param3 + 0x3c) + 0x18) + 0x160),0);
		  if (iVar1 == 0) {
		    Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator__HandleSubmitCompleteSuccessEvent
		              (auStack_10,auStack_10,param1_00,auStack_10);
		  }
		  else {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		              (param1_00,1,
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		  }
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		            (&local_8,param1_00,
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__get_Task__);
		  *param1 = local_8;
		  return;
		}
		*/

}
