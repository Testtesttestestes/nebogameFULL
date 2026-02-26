using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	public class ThemeDuelRatingViewMediator : AbstractViewMediator<ThemeDuelRatingModel, Gameplay.Rating.Events.RatingEvents, ThemeDuelRatingController, RatingView>, IHideableMediator
	{
		// Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x6F98", Offset = "0x6F98", VA = "0x6F98", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: <UpdateOsaView>b__23_0 ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___UpdateOsaView_b__23_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a585f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a585f4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000579")]
		private RatingPeriods SelectedRatingPeriod
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x6F99", Offset = "0x6F99", VA = "0x6F99")]
			[CompilerGenerated]
			get
			{
				return RatingPeriods.UnknownRatingPeriod;
			}
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x6F9A", Offset = "0x6F9A", VA = "0x6F9A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x6F9B", Offset = "0x6F9B", VA = "0x6F9B")]
		public ThemeDuelRatingViewMediator(ThemeDuelRatingModel model, Gameplay.Rating.Events.RatingEvents events, ThemeDuelRatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a585e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a585e6 = '\x01';
		  }
		  if (DAT_ram_00a585f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585f1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x18);
		  iVar1 = *(int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar1 + 0xf4));
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  iVar1 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__InitPeriodFilters
		                    (param1,*(undefined4 *)(param1[2] + 0x4c),param1);
		  param1[7] = iVar1;
		  if (DAT_ram_00a585f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585f3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x1c);
		  uVar2 = Gameplay_Rating_Model_RatingInfo___c____ctor_b__5_1(param1[2],0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = UI_Elements_Filters_GenericFilter_GenericFilterView__GetElementByIndex
		                    (*(undefined4 *)(iVar1 + 0x18),0);
		  iVar1 = UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndexSilent(uVar4,uVar2,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__PeriodFilterSelectedEventHandler
		            (param1,*(undefined4 *)(iVar1 + 0x24),param1);
		  iVar1 = param1[7];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(iVar1,0,0);
		  if (iVar1 == 0) {
		    iVar1 = param1[7];
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                      (*(undefined4 *)(iVar1 + 0x14),0,0);
		    param1[7] = iVar1;
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(iVar1,0,0);
		  param1[7] = iVar1;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(iVar1,1,0);
		  if (DAT_ram_00a585e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585e8 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = param1[6];
		  param3 = *(undefined4 *)(param1[2] + 0x4c);
		  uVar4 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar4,1,param3,iVar1,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingController___ctor(uVar2,uVar4,param1);
		  if (DAT_ram_00a585e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x30) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		                      (param1,*(undefined4 *)(param1[2] + 0x4c),param1[6],
		                       *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x2ec),param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(uVar4,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x6F9C", Offset = "0x6F9C", VA = "0x6F9C")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__Init
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__PeriodFilterSelectedEventHandler
		            (param1,param2,param1);
		  if (DAT_ram_00a585e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585e8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = param1[6];
		  param3_00 = *(undefined4 *)(param1[2] + 0x4c);
		  uVar2 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar2,1,param3_00,iVar3,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingController___ctor(uVar1,uVar2,param1);
		  if (DAT_ram_00a585e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585e9 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar3 + 0x30) + 0xc4) != '\0') {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar3 + 0x38);
		    uVar1 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		                      (param1,*(undefined4 *)(param1[2] + 0x4c),param1[6],
		                       *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x2ec),param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x6F9D", Offset = "0x6F9D", VA = "0x6F9D")]
		private void PeriodFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: PeriodFilterSelectedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__PeriodFilterSelectedEventHandler
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
		  
		  if (DAT_ram_00a585e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
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
		    DAT_ram_00a585e7 = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_RatingTypesDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_RatingTypesDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[6] = param2[3];
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
		  param1_03 = *(undefined4 *)(iVar3 + 0x20);
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

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x6F9E", Offset = "0x6F9E", VA = "0x6F9E")]
		private void SelectPeriodSilent(object data)
		{
		/* --- GHIDRA: SelectPeriodSilent ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__SelectPeriodSilent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param1[7],0,0);
		  param1[7] = param2;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  if (DAT_ram_00a585e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585e8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = param1[6];
		  param3_00 = *(undefined4 *)(param1[2] + 0x4c);
		  uVar2 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar2,1,param3_00,iVar3,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingController___ctor(uVar1,uVar2,param1);
		  if (DAT_ram_00a585e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585e9 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar3 + 0x30) + 0xc4) != '\0') {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar3 + 0x38);
		    uVar1 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		                      (param1,*(undefined4 *)(param1[2] + 0x4c),param1[6],
		                       *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x2ec),param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x6F9F", Offset = "0x6F9F", VA = "0x6F9F")]
		private void SubRatingsClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: SubRatingsClickedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__SubRatingsClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data
		            (*(undefined4 *)(param1 + 0x1c),0,0);
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x6FA0", Offset = "0x6FA0", VA = "0x6FA0")]
		private void SelectSubRatingSilent(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubRatingSilent ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__SelectSubRatingSilent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a585e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585e8 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param4 = param1[6];
		  param3 = *(undefined4 *)(param1[2] + 0x4c);
		  param1_01 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(param1_01,1,param3,param4,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingController___ctor(param1_00,param1_01,param3);
		  return;
		}
		*/

		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x6FA1", Offset = "0x6FA1", VA = "0x6FA1")]
		private void RequestRatings()
		{
		/* --- GHIDRA: RequestRatings ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__RequestRatings
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2 ^ 1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2 ^ 1,0);
		  if (DAT_ram_00a585e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x30) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		                      (param1,*(undefined4 *)(param1[2] + 0x4c),param1[6],
		                       *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x2ec),param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x6FA2", Offset = "0x6FA2", VA = "0x6FA2")]
		private void RewardsToggleChangedEventHandler(bool active)
		{
		/* --- GHIDRA: RewardsToggleChangedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__RewardsToggleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x30) + 0xc4) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x38);
		    param2_00 = Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		                          (param1,*(undefined4 *)(param1[2] + 0x4c),param1[6],
		                           *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x2ec),param1);
		    Gameplay_Rating_View_MyUserInRatingListElement___ctor(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x6FA3", Offset = "0x6FA3", VA = "0x6FA3")]
		private void UpdateRewards()
		{
		/* --- GHIDRA: UpdateRewards ---
		undefined4
		Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateRewards
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585ea == '\0') {
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
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0__GetRewards_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0__GetRewards_g__CreateArgs_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0_TypeInfo
		              );
		    DAT_ram_00a585ea = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  uVar1 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0__GetRewards_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param4,uVar1,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		  param1_00 = unnamed_function_1417
		                        (System_Func_RatingPrizeDic__RatingRewardsView_RatingRewardArgs__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (param1_00,param2_00,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass15_0__GetRewards_g__CreateArgs_1__
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

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x6FA4", Offset = "0x6FA4", VA = "0x6FA4")]
		private RatingRewardsView.RatingRewardArgs[] GetRewards(uint ratingType, RatingPeriods ratingPeriod, IEnumerable<RatingPrizeDic> ratingPrizes)
		{
		/* --- GHIDRA: GetRewards ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__GetRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  float fVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 *puVar9;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a585eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ThemeRatingKindDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_ThemeRatingKindDic__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_RewardsToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_SubRatingsClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__set_View_b__18_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16095);
		    DAT_ram_00a585eb = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x28) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterDeselectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		              (uVar6,uVar2,0);
		    param1[8] = 0;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_SubRatingsClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x30) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_RewardsToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x28) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_ExtraFilterDeselectedEventHandler__
		               ,0);
		    UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_SubRatingsClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_PeriodFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x30) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_RewardsToggleChangedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___ctor(param1,param1);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x288);
		          goto code_r0x80f1236b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f1236b:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    iVar3 = *(int *)(iVar3 + 0x14);
		    fVar5 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		    if ((0.0 < fVar5) && (iVar3 = *(int *)(iVar3 + 0x10), iVar3 != 0)) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		            goto code_r0x80f12438;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f12438:
		      uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		      uVar2 = *(undefined4 *)(iVar8 + 0x2e8);
		      if (*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		      }
		      puVar9 = *(undefined4 **)
		                (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x5c);
		      iVar8 = puVar9[1];
		      if (iVar8 == 0) {
		        if (*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		          puVar9 = *(undefined4 **)
		                    (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x5c);
		        }
		        uVar6 = *puVar9;
		        iVar8 = unnamed_function_1417(System_Func_ThemeRatingKindDic__ulong__TypeInfo);
		        func_ii_7542(iVar8,uVar6,
		                     Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__set_View_b__18_0__
		                     ,0);
		        *(int *)(*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo +
		                         0x5c) + 4) = iVar8;
		      }
		      iVar8 = Core_Extensions_IListExt__BinarySearch_object__uint_
		                        (uVar2,iVar8,*(undefined8 *)(iVar3 + 0x10),
		                         Method_Core_Extensions_IListExt_BinarySearch_ThemeRatingKindDic__ulong___);
		      if (iVar8 == 0) {
		        local_8 = *(undefined8 *)(iVar3 + 0x10);
		        uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		        uVar2 = func_ii_4419(StringLiteral_16095,uVar2,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7109(uVar2,0);
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = *(undefined4 *)(iVar8 + 0x20);
		        uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetImgForRulesAssetId(iVar3,0);
		        UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		                  (uVar6,uVar2,0);
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = *(undefined4 *)(iVar8 + 0x20);
		        uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetTitle(iVar3,0);
		        Gameplay_Antiq_View_Grid_GridList__SetData(uVar6,uVar2,0);
		      }
		      else {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = *(undefined4 *)(iVar3 + 0x20);
		        uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetDescription(iVar8,0);
		        UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		                  (uVar6,uVar2,0);
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = *(undefined4 *)(iVar3 + 0x20);
		        uVar2 = Core_Extensions_Dict_ThemeRatingKindDicExt__GetTitle(iVar8,0);
		        Gameplay_Antiq_View_Grid_GridList__SetData(uVar6,uVar2,0);
		      }
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar2,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x1700057A RID: 1402
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057A")]
		public override RatingView View
		{
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x6FA5", Offset = "0x6FA5", VA = "0x6FA5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x6FA6", Offset = "0x6FA6", VA = "0x6FA6")]
		private void ExtraFilterToggleChangedEventHandler(bool enabled)
		{
		/* --- GHIDRA: ExtraFilterToggleChangedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterToggleChangedEventHandler
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if ((param2 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(char *)(*(int *)(iVar1 + 0x2c) + 0xc4) != '\0')) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(iVar1 + 0x2c),0,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x6FA7", Offset = "0x6FA7", VA = "0x6FA7")]
		private void PeriodFilterToggleChangedEventHandler(bool enabled)
		{
		/* --- GHIDRA: PeriodFilterToggleChangedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__PeriodFilterToggleChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a585ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585ec = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  param4 = *(undefined4 *)(param1 + 0x18);
		  param3 = *(undefined4 *)(*(int *)(param1 + 8) + 0x4c);
		  param1_00 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(param1_00,1,param3,param4,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x6FA8", Offset = "0x6FA8", VA = "0x6FA8")]
		private void ExtraFilterDeselectedEventHandler()
		{
		/* --- GHIDRA: ExtraFilterDeselectedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterDeselectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a585ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_CultDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a585ed = '\x01';
		  }
		  param2_00 = Protocol_Dic_CultDic_TypeInfo;
		  if (param2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  else if ((Protocol_Dic_CultDic_TypeInfo != *param2) ||
		          (*(int **)(param1 + 0x20) = param2, *param2 != param2_00)) {
		    System_Activator__CreateInstance(param2,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param4 = *(undefined4 *)(param1 + 0x18);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x4c);
		  param1_00 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(param1_00,1,param3_00,param4,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x6FA9", Offset = "0x6FA9", VA = "0x6FA9")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: ExtraFilterSelectedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterSelectedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a585ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserInRatingListElement_UserInRatingListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateOsaView_b__23_0__
		              );
		    DAT_ram_00a585ee = '\x01';
		  }
		  uVar1 = Gameplay_Rating_Model_RatingModel__GetMyClan
		                    (param1[2],*(undefined4 *)(param1[2] + 0x4c),*(undefined4 *)(param2 + 0x10),0);
		  if (param1[8] != 0) {
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Func_UserInRatingListElement_UserInRatingListElementArgs__bool__TypeInfo
		                          );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateOsaView_b__23_0__
		               ,0);
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar1,param1_00,
		                       Method_System_Linq_Enumerable_Where_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		    uVar1 = func_ii_6295(uVar1,
		                         Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                        );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = **(int **)(iVar2 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x10)
		              * 4))(*(int **)(iVar2 + 0x24),uVar1,
		                    *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x14))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x6FAA", Offset = "0x6FAA", VA = "0x6FAA")]
		private void UpdateOsaView(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: UpdateOsaView ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UpdateOsaView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a585ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_RatingRequestDto__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_UserRatingsRequestedEventHandler__
		              );
		    DAT_ram_00a585ef = '\x01';
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
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_UserRatingsRequestedEventHandler__
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
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_UserRatingsRequestedEventHandler__
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

		// Token: 0x1700057B RID: 1403
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057B")]
		public override Gameplay.Rating.Events.RatingEvents Events
		{
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0x6FAB", Offset = "0x6FAB", VA = "0x6FAB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x6FAC", Offset = "0x6FAC", VA = "0x6FAC")]
		private void UserRatingsRequestedEventHandler(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: UserRatingsRequestedEventHandler ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__UserRatingsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a585f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585f1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x18);
		  iVar1 = *(int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar1 + 0xf4));
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x6FAD", Offset = "0x6FAD", VA = "0x6FAD")]
		private void InitPeriodFilters()
		{
		/* --- GHIDRA: InitPeriodFilters ---
		undefined4
		Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__InitPeriodFilters
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a585f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass28_0__InitSubRatingsFilters_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass28_0_TypeInfo
		              );
		    DAT_ram_00a585f2 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass28_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x14);
		  uVar3 = Gameplay_Rating_Model_RatingModel__get_CultsPeriodFilterDatas(param1[2],0);
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent(uVar4,uVar3,0);
		  uVar3 = Gameplay_Rating_Model_RatingModel__get_CultsPeriodFilterDatas(param1[2],0);
		  uVar4 = unnamed_function_1417(System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		  func_ii_7297(uVar4,iVar1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__DisplayClass28_0__InitSubRatingsFilters_b__0__
		               ,0);
		  iVar1 = System_Array__FindAll___Il2CppFullySharedGenericType_
		                    (uVar3,uVar4,Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___
		                    );
		  if (iVar1 == -1) {
		    uVar3 = 0;
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                      (*(undefined4 *)(iVar2 + 0x14),iVar1,0);
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x6FAE", Offset = "0x6FAE", VA = "0x6FAE")]
		private SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
		/* --- GHIDRA: InitSubRatingsFilters ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__InitSubRatingsFilters
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a585f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    DAT_ram_00a585f3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x1c);
		  uVar2 = Gameplay_Rating_Model_RatingInfo___c____ctor_b__5_1(param1[2],0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x6FAF", Offset = "0x6FAF", VA = "0x6FAF")]
		private void InitExtraFilters()
		{
		/* --- GHIDRA: InitExtraFilters ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__InitExtraFilters
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x6FB0", Offset = "0x6FB0", VA = "0x6FB0")]
		private void HandleRewardsToggleChanged(bool active)
		{
		/* --- GHIDRA: HandleRewardsToggleChanged ---
		uint Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__HandleRewardsToggleChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_6965(*(undefined4 *)(param2 + 0x1c),0);
		  return (uint)(iVar1 == *(int *)(*(int *)(param1 + 0x20) + 0xc));
		}
		*/

		}

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x1C")]
		private SubFilterListElement _selectedSubFilter;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x20")]
		private CultDic _cultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SelectedRatingPeriod ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__set_SelectedRatingPeriod
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a585e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView___ctor__
		              );
		    DAT_ram_00a585e5 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView___ctor__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__set_View
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if ((param2 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(char *)(*(int *)(iVar1 + 0x28) + 0xc4) != '\0')) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(iVar1 + 0x28),0,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 *puVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a585f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInRatingListElement_UserInRatingListElementArgs__UserData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserInRatingListElement_UserInRatingListElementArgs__UserData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyCommonRatingView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__UserRatingsRequestedEventHandler_b__26_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a585f0 = '\x01';
		  }
		  if (*(int *)(param2 + 0x10) == param1[6]) {
		    Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator__ExtraFilterSelectedEventHandler
		              (param1,param2,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x10);
		    uVar2 = Gameplay_Rating_Model_RatingModel__GetMyClan
		                      (param1[2],*(undefined4 *)(param1[2] + 0x4c),*(undefined4 *)(param2 + 0x10),0)
		    ;
		    if (*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)
		              (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x5c);
		    iVar1 = puVar4[2];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)
		                  (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar4;
		      iVar1 = unnamed_function_1417
		                        (
		                        System_Func_UserInRatingListElement_UserInRatingListElementArgs__UserData__TypeInfo
		                        );
		      System_Linq_Enumerable__Where_object_
		                (iVar1,param2_00,
		                 Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c__UserRatingsRequestedEventHandler_b__26_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator___c_TypeInfo +
		                       0x5c) + 8) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar2,iVar1,
		                       Method_System_Linq_Enumerable_Select_UserInRatingListElement_UserInRatingListElementArgs__UserData___
		                      );
		    UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0___Init_b__0(param1_00,uVar2,0);
		    iVar1 = Gameplay_Rating_Model_RatingModel__GetPlacesText
		                      (param1[2],*(undefined4 *)(param1[2] + 0x4c),*(undefined4 *)(param2 + 0x10),0)
		    ;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar1 != 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar3 + 0x34),1,
		                 Method_UI_MonoBehaviourWithStates_MyCommonRatingView_State__set_CurrentState__);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Elements_Buildings_SpellItemArgs___ctor
		                (*(undefined4 *)(*(int *)(iVar3 + 0x34) + 0x1c),iVar1,
		                 Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		                );
		      return;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar3 + 0x34),2,
		               Method_UI_MonoBehaviourWithStates_MyCommonRatingView_State__set_CurrentState__);
		  }
		  return;
		}
		*/

}
