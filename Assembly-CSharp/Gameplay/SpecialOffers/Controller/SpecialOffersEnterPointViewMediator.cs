using System;
using DG.Tweening;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x2000510")]
	public class SpecialOffersEnterPointViewMediator : AbstractViewMediator<SpecialOffersModel, SpecialOffersEvents, SpecialOffersController, SpecialOffersButtonView>
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x7047", Offset = "0x7047", VA = "0x7047")]
		public SpecialOffersEnterPointViewMediator(SpecialOffersModel model, SpecialOffersEvents events, SpecialOffersController controller)
		{
		/* --- GHIDRA: <UpdateView>b__11_1 ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___UpdateView_b__11_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58652 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo);
		    DAT_ram_00a58652 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58649 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58649 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (param1[7] != 0) {
		      func_ii_7891(param1[7],0,0);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_ButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_ButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__SpecialOffersRequestedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700059D RID: 1437
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059D")]
		public override SpecialOffersButtonView View
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x7048", Offset = "0x7048", VA = "0x7048", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700059E RID: 1438
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059E")]
		public override SpecialOffersEvents Events
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x7049", Offset = "0x7049", VA = "0x7049", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x704A", Offset = "0x704A", VA = "0x704A")]
		private void HandleNeedValidateEntryPointEvent()
		{
		/* --- GHIDRA: HandleNeedValidateEntryPointEvent ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__HandleNeedValidateEntryPointEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5864b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    DAT_ram_00a5864b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  piVar2 = (int *)param1[2];
		  if (DAT_ram_00a58633 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a58633 = '\x01';
		  }
		  if ((char)piVar2[8] == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		    param2_00 = *(undefined4 *)(iVar1 + 0xc);
		  }
		  else {
		    param2_00 = 0;
		  }
		  System_Collections_Generic_Dictionary_int__object___get_Count(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x704B", Offset = "0x704B", VA = "0x704B")]
		private void UnseenOptionsCountChangedEventHandler()
		{
		/* --- GHIDRA: UnseenOptionsCountChangedEventHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UnseenOptionsCountChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__SpecialOffersRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x704C", Offset = "0x704C", VA = "0x704C")]
		private void SpecialOffersRequestedEventHandler()
		{
		/* --- GHIDRA: SpecialOffersRequestedEventHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__SpecialOffersRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float param2_00;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5864c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__float__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IEnumerableExt_MinOrDefault_BankOptionData__float___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateView_b__11_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c__UpdateView_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo);
		    DAT_ram_00a5864c = '\x01';
		  }
		  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateView(param1,param1);
		  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__ValidateEp(param1,param1);
		  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__ScheduleTween
		            (param1,param1);
		  iVar5 = *(int *)param1[2];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar5 + 0xf4));
		  if (*(int *)(Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                  );
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo +
		            0x5c);
		  iVar5 = puVar2[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                    );
		      puVar2 = *(undefined4 **)
		                (Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                + 0x5c);
		    }
		    uVar3 = *puVar2;
		    iVar5 = unnamed_function_1417(System_Func_BankOptionData__float__TypeInfo);
		    System_Func_object__SerializableProjectConfiguration___Invoke
		              (iVar5,uVar3,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c__UpdateView_b__11_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator___c_TypeInfo
		                     + 0x5c) + 4) = iVar5;
		  }
		  param2_00 = Core_Extensions_ICollectionExt__ContainsAny___Il2CppFullySharedGenericType_
		                        (uVar1,iVar5,
		                         Method_Core_Extensions_IEnumerableExt_MinOrDefault_BankOptionData__float___
		                        );
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar5 + 0x14);
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar5 + 0x1c);
		  piVar4 = (int *)param1[2];
		  if (DAT_ram_00a58633 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a58633 = '\x01';
		  }
		  if ((char)piVar4[8] == '\0') {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		    uVar3 = *(undefined4 *)(iVar5 + 0xc);
		  }
		  else {
		    uVar3 = 0;
		  }
		  System_Collections_Generic_Dictionary_int__object___get_Count(uVar1,uVar3,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar5 + 0x20);
		  iVar5 = *(int *)param1[2];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar5 + 0xf4));
		  uVar3 = unnamed_function_1417(System_Func_BankOptionData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateView_b__11_1__
		             ,0);
		  uVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (uVar1,uVar3,Method_System_Linq_Enumerable_Any_BankOptionData___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x704D", Offset = "0x704D", VA = "0x704D")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5864d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a5864d = '\x01';
		  }
		  iVar4 = *(int *)param1[2];
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar4 + 0xf4));
		  if (*(int *)(iVar4 + 0xc) != 0) {
		    param1_00 = *(int **)(param1[2] + 0x10);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x298);
		          goto code_r0x80f187e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f187e1:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar5 = **(int **)(iVar4 + 0x14);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                      (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		    uVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_LastList
		                      (uVar3,0);
		    uVar1 = uVar1 ^ 1;
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x704E", Offset = "0x704E", VA = "0x704E")]
		private void ValidateEp()
		{
		/* --- GHIDRA: ValidateEp ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__ValidateEp
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  undefined4 param1_00;
		  float fVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  int *param1_01;
		  uint uVar6;
		  
		  if (DAT_ram_00a5864e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_UpdateBanner__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Tween___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27341);
		    DAT_ram_00a5864e = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x1c),0,0);
		  }
		  iVar5 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5862d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5862d = '\x01';
		  }
		  param1_01 = *(int **)(iVar5 + 0xc);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f1893e;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f1893e:
		  uVar4 = CONCAT44(in_register_20000004,param1_01);
		  param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(uVar4,puVar1[1]);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar4 = Core_Extensions_Dict_DictExt__GetDoubleParameter(param1_00,StringLiteral_27341,0);
		  iVar5 = **(int **)(param1 + 8);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                    (CONCAT44(uVar3,*(int **)(param1 + 8)),*(undefined4 *)(iVar5 + 0xf4));
		  iVar5 = *(int *)(iVar5 + 0xc);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar2 = func_ii_7331(uVar4,0);
		  fVar2 = UnityEngine_Camera__set_orthographicSize((float)iVar5,fVar2,0);
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_UpdateBanner__
		             ,0);
		  if (fVar2 <= 60.0) {
		    fVar2 = 60.0;
		  }
		  uVar3 = DG_Tweening_DOVirtual__EasedValue(fVar2,uVar3,1,0);
		  uVar3 = DG_Tweening_TweenSettingsExtensions__SetLink_object_
		                    (uVar3,0xffffffff,Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Tween___);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x704F", Offset = "0x704F", VA = "0x704F")]
		private void ScheduleTween()
		{
		/* --- GHIDRA: ScheduleTween ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__ScheduleTween
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5864f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__get_Item__)
		    ;
		    DAT_ram_00a5864f = '\x01';
		  }
		  iVar2 = *(int *)param1[2];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar2 + 0xf4));
		  if (*(int *)(iVar2 + 0xc) == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x10);
		    param2_00 = 0;
		  }
		  else {
		    param1[6] = (param1[6] + 1) % *(int *)(iVar2 + 0xc);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x10);
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (iVar2,param1[6],
		                       Method_System_Collections_Generic_List_BankOptionData__get_Item__);
		    param2_00 = *(undefined4 *)(iVar2 + 0x54);
		  }
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x7050", Offset = "0x7050", VA = "0x7050")]
		private void UpdateBanner()
		{
		/* --- GHIDRA: UpdateBanner ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateBanner
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58650 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58650 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x200);
		        goto code_r0x80f18fb4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x28);
		code_r0x80f18fb4:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_SpecialOffersManager__ShowSpecialOffersWindowScheduled(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x7051", Offset = "0x7051", VA = "0x7051")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		undefined4
		Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__ButtonClickedEventHandler
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58651 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    DAT_ram_00a58651 = '\x01';
		  }
		  iVar2 = System_Xml_Serialization_TypeTranslator__GetTypeData(param2,0);
		  if (iVar2 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    param1_00 = *(int **)(*(int *)(param1 + 8) + 0x14);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_Model_IOptionValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f19077;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		code_r0x80f19077:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param2,puVar3[1]);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		private const float MIN_REFRESH_INTERVAL = 60f;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _tween;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5864a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_HandleNeedValidateEntryPointEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_SpecialOffersRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_UnseenOptionsCountChangedEventHandler__
		              );
		    DAT_ram_00a5864a = '\x01';
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
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_SpecialOffersRequestedEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_UnseenOptionsCountChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_HandleNeedValidateEntryPointEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_SpecialOffersRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_UnseenOptionsCountChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_HandleNeedValidateEntryPointEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1))
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
		void Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator__UpdateView(param1,param1);
		  return;
		}
		*/

}
