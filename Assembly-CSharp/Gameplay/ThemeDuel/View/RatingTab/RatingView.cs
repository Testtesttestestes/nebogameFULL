using System;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ThemeDuel.View.RatingTab
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public class RatingView : MonoBehaviour
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000563")]
		public TopLeaders TopLeaders
		{
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x6F58", Offset = "0x6F58", VA = "0x6F58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000564")]
		public GenericSubFilterView SubRatings
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x6F59", Offset = "0x6F59", VA = "0x6F59")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000565")]
		public GenericFilterView PeriodFilter
		{
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x6F5A", Offset = "0x6F5A", VA = "0x6F5A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000566")]
		public DeselectableGenericFilterView ExtraFilter
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x6F5B", Offset = "0x6F5B", VA = "0x6F5B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000567")]
		public CommonRatingOSAView UsersOSAView
		{
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x6F5C", Offset = "0x6F5C", VA = "0x6F5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000568")]
		public RatingsDescription Description
		{
			[Token(Token = "0x6001DDF")]
			[Address(RVA = "0x6F5D", Offset = "0x6F5D", VA = "0x6F5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000569")]
		public Toggle PeriodFilterToggle
		{
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x6F5E", Offset = "0x6F5E", VA = "0x6F5E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056A")]
		public Toggle ExtraFilterToggle
		{
			[Token(Token = "0x6001DE1")]
			[Address(RVA = "0x6F5F", Offset = "0x6F5F", VA = "0x6F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056B")]
		public Toggle RewardsToggle
		{
			[Token(Token = "0x6001DE2")]
			[Address(RVA = "0x6F60", Offset = "0x6F60", VA = "0x6F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056C")]
		public MyCommonRatingView MyRatingView
		{
			[Token(Token = "0x6001DE3")]
			[Address(RVA = "0x6F61", Offset = "0x6F61", VA = "0x6F61")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056D")]
		public RatingRewardsView RatingRewards
		{
			[Token(Token = "0x6001DE4")]
			[Address(RVA = "0x6F62", Offset = "0x6F62", VA = "0x6F62")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x6F63", Offset = "0x6F63", VA = "0x6F63")]
		public void Init()
		{
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x6F64", Offset = "0x6F64", VA = "0x6F64")]
		public RatingView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_View_Sections_Rating_RatingView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63a9d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    DAT_ram_00a63a9d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IDailyQuest__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IDailyQuest__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TopLeaders _topLeaders;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GenericSubFilterView _subRatings;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericFilterView _periodFilter;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private DeselectableGenericFilterView _extraFilter;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RatingsDescription _description;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CommonRatingOSAView _usersOSAView;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _periodFilterToggle;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Toggle _extraFilterToggle;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle _rewardsToggle;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MyCommonRatingView _myRatingView;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RatingRewardsView _ratingRewards;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RatingRewards ---
		void Gameplay_ThemeDuel_View_RatingTab_RatingView__get_RatingRewards(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a585cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		              );
		    DAT_ram_00a585cd = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x24),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: get_Description ---
		void Gameplay_Competition_View_Sections_Rating_RatingView__get_Description
		               (undefined4 param1,int param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int param3_00;
		  int param1_01;
		  undefined4 uVar4;
		  int *param1_02;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63a9a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_RatingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Events_RatingEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_RatingModel_TypeInfo);
		    DAT_ram_00a63a9a = '\x01';
		  }
		  local_4 = 0;
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x2c) + 0xc) + 0x10);
		  param1_02 = *(int **)(*(int *)(param2 + 0xc) + 8);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8233728e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8233728e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar5 = Core_Extensions_Dict_DictExt__TryGetCompetitionDic(uVar3,uVar4,&local_4,0);
		  uVar3 = local_4;
		  if (iVar5 != 0) {
		    uVar4 = *(undefined4 *)(param2 + 8);
		    uVar6 = *(undefined4 *)(param2 + 0x30);
		    uVar7 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		    uVar8 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x24);
		    iVar5 = unnamed_function_1417(Gameplay_Competition_Model_RatingModel_TypeInfo);
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
		    *(undefined4 *)(iVar5 + 0x14) = param1_00;
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar5,uVar4,0);
		    *(undefined4 *)(iVar5 + 0x18) = uVar3;
		    *(undefined4 *)(iVar5 + 0xc) = uVar7;
		    *(undefined4 *)(iVar5 + 0x10) = uVar6;
		    param3_00 = unnamed_function_1417(Gameplay_Competition_Events_RatingEvents_TypeInfo);
		    *(undefined4 *)(param3_00 + 0x14) = param3;
		    param1_01 = unnamed_function_1417
		                          (Gameplay_Competition_Control_Sections_RatingController_TypeInfo);
		    if (DAT_ram_00a63af7 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_RatingModel__RatingEvents___ctor__);
		      DAT_ram_00a63af7 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (param1_01,iVar5,param3_00,
		               Method_MVC_AbstractController_RatingModel__RatingEvents___ctor__);
		    *(undefined4 *)(param1_01 + 0x18) = uVar8;
		    *param4 = param1_01;
		    return;
		  }
		  local_8 = uVar4;
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar3 = unnamed_function_2232(&StringLiteral_5627);
		  uVar4 = func_ii_4419(uVar3,uVar4,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar4,0);
		  uVar4 = unnamed_function_2232
		                    (&Method_Gameplay_Competition_View_Sections_Rating_RatingView_CreateController__
		                    );
		  func_ii_1050(uVar3,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: CreateController ---
		void Gameplay_Competition_View_Sections_Rating_RatingView__CreateController
		               (undefined4 param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a9b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_RatingViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a63a9b = '\x01';
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Competition_Control_Sections_RatingViewMediator_TypeInfo);
		  if (DAT_ram_00a63afd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_RatingModel__RatingEvents__RatingController__RatingView___ctor__
		              );
		    DAT_ram_00a63afd = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4_00,param2,
		             Method_MVC_AbstractCozyViewMediator_RatingModel__RatingEvents__RatingController__RatingView___ctor__
		            );
		  *param3 = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: RunController ---
		void Gameplay_Competition_View_Sections_Rating_RatingView__RunController
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_View_Sections_BaseSectionView_RatingController___ctor__)
		    ;
		    DAT_ram_00a63a9c = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___set_View
		            (param1,
		             Method_Gameplay_Competition_View_Sections_BaseSectionView_RatingController___ctor__);
		  return;
		}
		*/

}
