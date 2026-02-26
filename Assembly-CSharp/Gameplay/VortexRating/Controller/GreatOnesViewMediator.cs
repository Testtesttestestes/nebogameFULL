using System;
using System.Runtime.CompilerServices;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatOnesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	public class GreatOnesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, GreatOnesView>, IHideableMediator
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x6728", Offset = "0x6728", VA = "0x6728")]
		public GreatOnesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		/* --- GHIDRA: <CheckForMaxVotes>g__DisableAllLikeButtons|11_0 ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator___CheckForMaxVotes_g__DisableAllLikeButtons_11_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo);
		    DAT_ram_00a581d7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo)
		  ;
		  **(undefined4 **)(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a581d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_LikeButtonClickedEventHandler__
		              );
		    DAT_ram_00a581d0 = '\x01';
		  }
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_GreatUserView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_LikeButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a581c1 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		      DAT_ram_00a581c1 = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x18);
		    do {
		      iVar4 = 0;
		      iVar7 = func_ii_7048(iVar3,uVar5,0);
		      uVar2 = System_Action_GreatUserView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_GreatUserView__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x18,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_GreatUserView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_LikeButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a581c0 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		      DAT_ram_00a581c0 = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x18);
		    do {
		      iVar4 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar2 = System_Action_GreatUserView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_GreatUserView__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x18,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    iVar6 = *param1;
		    uVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x14c));
		    Gameplay_VortexRating_Controller_VortexRatingController___ctor(uVar5,iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700038C RID: 908
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038C")]
		public override GreatOnesView View
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x6729", Offset = "0x6729", VA = "0x6729", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		public override VortexRatingEvents Events
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x672A", Offset = "0x672A", VA = "0x672A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x672B", Offset = "0x672B", VA = "0x672B")]
		private void VotedEventHandler(ulong userId)
		{
		/* --- GHIDRA: VotedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__VotedEventHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a581d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_GreatUserView___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass7_0__GreatUserSetChangedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass7_0_TypeInfo
		              );
		    DAT_ram_00a581d3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass7_0_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 8) = param2;
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_GreatUserView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass7_0__GreatUserSetChangedEventHandler_b__0__
		             ,0);
		  param1_00 = System_Func_object__bool____ctor
		                        (uVar5,uVar2,Method_System_Linq_Enumerable_FirstOrDefault_GreatUserView___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = func_ii_3812(param1_00,0,0);
		  if (iVar3 == 0) {
		    uVar5 = *(undefined4 *)(param1_00 + 0x20);
		    param2_00 = *(undefined8 *)(iVar1 + 8);
		    iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0x14),param2_00,
		                       Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__
		                      );
		    uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    piVar4 = (int *)func_ii_7307(uVar5,*(undefined4 *)(iVar1 + 0x10),0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))
		              (piVar4,CONCAT44(uVar2,*(undefined4 *)(*piVar4 + 0xf4)));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x672C", Offset = "0x672C", VA = "0x672C")]
		private void GreatUserSetChangedEventHandler(ulong userId)
		{
		/* --- GHIDRA: GreatUserSetChangedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__GreatUserSetChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a581d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_24240);
		    DAT_ram_00a581d4 = '\x01';
		  }
		  param2_00 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                        (*(undefined4 *)(param1[2] + 0xc),StringLiteral_24240,0);
		  uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1[2] + 8),0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  if ((longlong)(ulonglong)uVar1 < (longlong)param2_00) {
		    Gameplay_VortexRating_Controller_VortexRatingController__UnsubscribeFromEvents
		              (param1_00,param2_00,param1_00);
		    return;
		  }
		  Gameplay_VortexRating_Controller_VortexRatingController__SetGreatSetIdResultHandler
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(*(int *)(param2 + 0x30) + 8) + 0xc) + 0x10)
		             ,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x672D", Offset = "0x672D", VA = "0x672D")]
		private void LikeButtonClickedEventHandler(GreatUserView user)
		{
		/* --- GHIDRA: LikeButtonClickedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__LikeButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  Gameplay_VortexRating_Controller_GreatOnesViewMediator__GreatTopRequestedEventHandler
		            (param1,param1);
		  Gameplay_VortexRating_Controller_GreatOnesViewMediator__RenderUsers(param1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x672E", Offset = "0x672E", VA = "0x672E")]
		private void GreatTopRequestedEventHandler()
		{
		/* --- GHIDRA: GreatTopRequestedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__GreatTopRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_GreatUserData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_GreatUserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__RenderUsers_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo);
		    DAT_ram_00a581d5 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x14),
		                     Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Values__
		                    );
		  if (*(int *)(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_GreatUserData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar2,
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__RenderUsers_b__10_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_VortexRating_Controller_GreatOnesViewMediator___c_TypeInfo + 0x5c) +
		            4) = iVar4;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar4,
		                     Method_System_Linq_Enumerable_OrderByDescending_GreatUserData__uint___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_GreatUserData___);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Gameplay_VortexRating_View_GreatOnesTab_GreatOnesView__LikeButtonClickedEventHandler
		                    (uVar2,uVar1,param1);
		  param1[6] = iVar4;
		  return;
		}
		*/

		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x672F", Offset = "0x672F", VA = "0x672F")]
		private void RenderUsers()
		{
		/* --- GHIDRA: RenderUsers ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__RenderUsers
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_01;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a581d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25295);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17541);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24239);
		    DAT_ram_00a581d6 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x24) + 0xc);
		  local_4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                      (*(undefined4 *)(param1[2] + 0xc),StringLiteral_24239,0);
		  local_8 = local_4 - iVar4;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x14);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  iVar1 = 0;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17541,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = func_ii_4443(&local_8,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_22118,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_25295,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar2,0);
		  if ((local_4 <= iVar4) && (iVar4 = param1[6], 0 < *(int *)(iVar4 + 0xc))) {
		    do {
		      System_Linq_Enumerable__First_object_
		                (*(undefined4 *)(*(int *)(iVar4 + iVar1 * 4 + 0x10) + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x6730", Offset = "0x6730", VA = "0x6730")]
		private void CheckForMaxVotes()
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x6731", Offset = "0x6731", VA = "0x6731", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__Hide(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      System_Linq_Enumerable__First_object_
		                (*(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x6732", Offset = "0x6732", VA = "0x6732")]
		[CompilerGenerated]
		private void <CheckForMaxVotes>g__DisableAllLikeButtons|11_0()
		{
		}

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x18")]
		private GreatUserView[] _userViews;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a581d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatTopRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatUserSetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_RenderUsers__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_VotedEventHandler__);
		    DAT_ram_00a581d1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatTopRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_VotedEventHandler__,0
		                );
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
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
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_RenderUsers__,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatUserSetChangedEventHandler__
		                 ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatTopRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_VotedEventHandler__,0
		                );
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
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
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_RenderUsers__,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator_GreatUserSetChangedEventHandler__
		                 ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x20) = iVar5;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_VortexRating_Controller_GreatOnesViewMediator__set_Events
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a581d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatOnesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_GreatUserView___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass6_0__VotedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass6_0_TypeInfo
		              );
		    DAT_ram_00a581d2 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass6_0_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 8) = param2;
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_GreatUserView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_VortexRating_Controller_GreatOnesViewMediator___c__DisplayClass6_0__VotedEventHandler_b__0__
		             ,0);
		  iVar3 = func_ii_7423(uVar4,uVar2,Method_System_Linq_Enumerable_First_GreatUserView___);
		  iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x14),*(undefined8 *)(iVar1 + 8),
		                     Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__);
		  local_4 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x14);
		  uVar4 = *(undefined4 *)(iVar3 + 0x18);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x10),0,0);
		  Gameplay_VortexRating_Controller_GreatOnesViewMediator__RenderUsers(param1,param1);
		  return;
		}
		*/

}
