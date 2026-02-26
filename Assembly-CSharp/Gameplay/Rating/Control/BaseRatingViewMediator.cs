using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public abstract class BaseRatingViewMediator : AbstractViewMediator<RatingModel, Gameplay.Rating.Events.RatingEvents, RatingController, RatingWindow>
	{
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063E")]
		protected uint SelectedRatingType
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x737A", Offset = "0x737A", VA = "0x737A")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x737B", Offset = "0x737B", VA = "0x737B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		private protected RatingPeriods SelectedRatingPeriod
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x737C", Offset = "0x737C", VA = "0x737C")]
			[CompilerGenerated]
			protected get
			{
				return RatingPeriods.UnknownRatingPeriod;
			}
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x737D", Offset = "0x737D", VA = "0x737D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x737E", Offset = "0x737E", VA = "0x737E")]
		protected BaseRatingViewMediator(RatingModel model, Gameplay.Rating.Events.RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Control_BaseRatingViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5806b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__set_View__
		              );
		    DAT_ram_00a5806b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_BaseRatingViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_BaseRatingViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000640 RID: 1600
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000640")]
		public override RatingWindow View
		{
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x737F", Offset = "0x737F", VA = "0x737F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x7380", Offset = "0x7380", VA = "0x7380")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined8 uVar5;
		  
		  if (DAT_ram_00a5806d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_PeriodFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_RewardsToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_SubRatingsClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a5806d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_SubRatingsClickedEventHandler__,0
		            );
		  UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x4c);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_PeriodFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x6c) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_RewardsToggleChangedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))(param1,*(undefined4 *)(*param1 + 0x174));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))
		                    (param1,param1[7],*(undefined4 *)(*param1 + 0x17c));
		  param1[9] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x168) * 4))(param1,*(undefined4 *)(*param1 + 0x16c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar1 + 0x4c),0,0);
		  Gameplay_Rating_Control_BaseRatingViewMediator__PeriodFilterSelectedEventHandler
		            (param1,*(undefined4 *)(iVar1 + 0x24),param1);
		  iVar1 = param1[9];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(iVar1,0,0);
		  if (iVar1 == 0) {
		    iVar1 = param1[9];
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                      (*(undefined4 *)(iVar1 + 0x48),0,0);
		    param1[9] = iVar1;
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(iVar1,0,0);
		  param1[9] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		            (param1,iVar1,*(undefined4 *)(*param1 + 0x184));
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(iVar1,1,0);
		  uVar5 = *(undefined8 *)(param1 + 6);
		  iVar4 = param1[8];
		  iVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(int *)(iVar1 + 0x10) = iVar4;
		  *(undefined8 *)(iVar1 + 8) = uVar5;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x188) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x18c));
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),iVar1,*(undefined4 *)(iVar4 + 0x14));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x74);
		    iVar1 = param1[7];
		    iVar4 = param1[8];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x194));
		    uVar2 = Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		                      (param1,iVar1,iVar4,uVar2,param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(uVar3,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x7381", Offset = "0x7381", VA = "0x7381")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5806e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_RatingRequestDto__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_HandleRatingsDataReceivingCompleteEvent__
		              );
		    DAT_ram_00a5806e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_RatingRequestDto__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_HandleRatingsDataReceivingCompleteEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_RatingRequestDto__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_RatingRequestDto__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_RatingRequestDto__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_RatingRequestDto__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_RatingRequestDto__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_HandleRatingsDataReceivingCompleteEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_RatingRequestDto__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_RatingRequestDto__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_RatingRequestDto__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_RatingRequestDto__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000641")]
		public sealed override Gameplay.Rating.Events.RatingEvents Events
		{
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x738C", Offset = "0x738C", VA = "0x738C", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x7382", Offset = "0x7382", VA = "0x7382", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002224")]
		[Address(RVA = "0x7383", Offset = "0x7383", VA = "0x7383")]
		private void HandleRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: HandleRatingsDataReceivingCompleteEvent ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__HandleRatingsDataReceivingCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a5806f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a5806f = '\x01';
		  }
		  Gameplay_Rating_Control_BaseRatingViewMediator__PeriodFilterSelectedEventHandler
		            (param1,param2,param1);
		  uVar4 = *(undefined8 *)(param1 + 6);
		  iVar3 = param1[8];
		  iVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(int *)(iVar1 + 0x10) = iVar3;
		  *(undefined8 *)(iVar1 + 8) = uVar4;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x188) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x18c));
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),iVar1,*(undefined4 *)(iVar3 + 0x14));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x74);
		    iVar1 = param1[7];
		    iVar3 = param1[8];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x194));
		    uVar2 = Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		                      (param1,iVar1,iVar3,uVar2,param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002225 RID: 8741
		[Token(Token = "0x6002225")]
		protected abstract void InitExtraFilters();

		// Token: 0x06002226 RID: 8742
		[Token(Token = "0x6002226")]
		protected abstract void InitPeriodFilters();

		// Token: 0x06002227 RID: 8743
		[Token(Token = "0x6002227")]
		protected abstract SubFilterListElement InitSubRatingsFilters(uint ratingType);

		// Token: 0x06002228 RID: 8744
		[Token(Token = "0x6002228")]
		protected abstract void SelectSubRatings(SubFilterListElement element);

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002229 RID: 8745
		[Token(Token = "0x17000642")]
		protected abstract Action<RatingRequestDto> RequestRatingsAction { [Token(Token = "0x6002229")] get; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600222A RID: 8746
		[Token(Token = "0x17000643")]
		protected abstract IList<RatingPrizeDic> RatingPrizes { [Token(Token = "0x600222A")] get; }

		// Token: 0x0600222B RID: 8747
		[Token(Token = "0x600222B")]
		protected abstract void HandleRewardsToggleChanged(bool active);

		// Token: 0x0600222C RID: 8748
		[Token(Token = "0x600222C")]
		protected abstract void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest);

		// Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x7384", Offset = "0x7384", VA = "0x7384")]
		private void PeriodFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: PeriodFilterSelectedEventHandler ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__PeriodFilterSelectedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 uVar4;
		  undefined8 param1_02;
		  longlong lVar5;
		  undefined4 param1_03;
		  float4 local_4;
		  
		  if (DAT_ram_00a58070 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26304);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24649);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27752);
		    DAT_ram_00a58070 = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[8] = param2[3];
		  param1_02 = Core_Extensions_Dict_DictExt__GetDoubleParameter
		                        (*(undefined4 *)(param1[2] + 0xc),StringLiteral_27752,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar1 = func_ii_7331(param1_02,0);
		  local_4 = (float4)(fVar1 / *(float *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 4));
		  lVar5 = Core_Extensions_Dict_DictExt__GetDoubleParameter
		                    (*(undefined4 *)(param1[2] + 0xc),StringLiteral_26304,0);
		  uVar2 = Utils_TimeUtils__FormatTwoDigits((double)lVar5,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_03 = *(undefined4 *)(iVar3 + 0x54);
		  param1_00 = Core_Extensions_RatingTypesDicExt__GetDescription(param2,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar4 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  uVar4 = System_Single__GetHashCode(&local_4,uVar4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_24649,uVar4,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_27717,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(param1_00,param1_01,0);
		  Gameplay_Inventory_View_Info_ArtifactInfoPropertyItemView__set_Title(param1_03,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x7385", Offset = "0x7385", VA = "0x7385")]
		private void SelectPeriodSilent(object data)
		{
		/* --- GHIDRA: SelectPeriodSilent ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__SelectPeriodSilent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a58071 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a58071 = '\x01';
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param1[9],0,0);
		  param1[9] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0x184));
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  uVar4 = *(undefined8 *)(param1 + 6);
		  iVar3 = param1[8];
		  iVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(int *)(iVar1 + 0x10) = iVar3;
		  *(undefined8 *)(iVar1 + 8) = uVar4;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x188) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x18c));
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),iVar1,*(undefined4 *)(iVar3 + 0x14));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x74);
		    iVar1 = param1[7];
		    iVar3 = param1[8];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x194));
		    uVar2 = Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		                      (param1,iVar1,iVar3,uVar2,param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x7386", Offset = "0x7386", VA = "0x7386")]
		private void SubRatingsClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: SubRatingsClickedEventHandler ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__SubRatingsClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param1[9],0,0);
		  param1[9] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0x184));
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x7387", Offset = "0x7387", VA = "0x7387")]
		private void SelectSubRatingSilent(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubRatingSilent ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__SelectSubRatingSilent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x188) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x18c));
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x7388", Offset = "0x7388", VA = "0x7388")]
		private void RequestRatings(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: RequestRatings ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__RequestRatings
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param3_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x74),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2 ^ 1,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x198) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0x19c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x74);
		    iVar1 = param1[7];
		    param3_00 = param1[8];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x194));
		    uVar2 = Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		                      (param1,iVar1,param3_00,uVar2,param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x7389", Offset = "0x7389", VA = "0x7389")]
		private void RewardsToggleChangedEventHandler(bool active)
		{
		/* --- GHIDRA: RewardsToggleChangedEventHandler ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__RewardsToggleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x74);
		    iVar1 = param1[7];
		    param3 = param1[8];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x194));
		    uVar2 = Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		                      (param1,iVar1,param3,uVar2,param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x738A", Offset = "0x738A", VA = "0x738A")]
		private void UpdateRewards()
		{
		/* --- GHIDRA: UpdateRewards ---
		undefined4
		Gameplay_Rating_Control_BaseRatingViewMediator__UpdateRewards
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58072 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_RatingPrizeDic__RatingRewardsView_RatingRewardArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_RatingRewardsView_RatingRewardArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_RatingPrizeDic__RatingRewardsView_RatingRewardArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0__GetRewards_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0__GetRewards_g__CreateArgs_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0_TypeInfo);
		    DAT_ram_00a58072 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  uVar1 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0__GetRewards_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param4,uVar1,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		  param1_00 = unnamed_function_1417
		                        (System_Func_RatingPrizeDic__RatingRewardsView_RatingRewardArgs__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (param1_00,param2_00,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator___c__DisplayClass35_0__GetRewards_g__CreateArgs_1__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_RatingPrizeDic__RatingRewardsView_RatingRewardArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_RatingRewardsView_RatingRewardArgs___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x738B", Offset = "0x738B", VA = "0x738B")]
		private RatingRewardsView.RatingRewardArgs[] GetRewards(uint ratingType, RatingPeriods ratingPeriod, IEnumerable<RatingPrizeDic> ratingPrizes)
		{
		/* --- GHIDRA: GetRewards ---
		undefined4 Gameplay_Rating_Control_BaseRatingViewMediator__GetRewards(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58073 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Events__
		              );
		    DAT_ram_00a58073 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0xc);
		}
		*/

			return null;
		}

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x18")]
		protected readonly RatingKindTypeDic.Types.RatingKindType RatingKindType;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x24")]
		private SubFilterListElement _selectedSubFilter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5806c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_PeriodFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_RewardsToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_BaseRatingViewMediator_SubRatingsClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a5806c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_SubRatingsClickedEventHandler__,0
		            );
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x4c);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_PeriodFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x6c) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_BaseRatingViewMediator_RewardsToggleChangedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Rating_Control_BaseRatingViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if ((*(int *)(param2 + 0xc) == param1[7]) && (*(int *)(param2 + 0x10) == param1[8])) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x1a0) * 4))
		              (param1,param2,*(undefined4 *)(*param1 + 0x1a4));
		  }
		  return;
		}
		*/

}
