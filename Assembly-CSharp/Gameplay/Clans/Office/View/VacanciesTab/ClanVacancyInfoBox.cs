using System;
using Core.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	public class ClanVacancyInfoBox : MonoBehaviourWithStates<ClanVacancyInfoBox.State>
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C06")]
		public Button InfoButton
		{
			[Token(Token = "0x6003CF6")]
			[Address(RVA = "0x8BB6", Offset = "0x8BB6", VA = "0x8BB6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C07")]
		public Button RequestButton
		{
			[Token(Token = "0x6003CF7")]
			[Address(RVA = "0x8BB7", Offset = "0x8BB7", VA = "0x8BB7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C08")]
		public Button WithdrawButton
		{
			[Token(Token = "0x6003CF8")]
			[Address(RVA = "0x8BB8", Offset = "0x8BB8", VA = "0x8BB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x8BB9", Offset = "0x8BB9", VA = "0x8BB9")]
		public void UpdateData(ClanInRatingListElement.ClanInRatingListElementArgs args, Dictionaries dict, UserData user, string honorAssetId)
		{
		/* --- GHIDRA: UpdateData ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClanVacancyInfoBox__UpdateData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State___ctor__);
		    DAT_ram_00a57f10 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ClanVacancyInfoBox_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x8BBA", Offset = "0x8BBA", VA = "0x8BBA")]
		public ClanVacancyInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_VacanciesTab_ClanVacancyInfoBox___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsViewsHolder_TypeInfo);
		    DAT_ram_00a57f11 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsViewsHolder_TypeInfo);
		  if (DAT_ram_00a57f14 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_ClanInRatingListElement___ctor__);
		    DAT_ram_00a57f14 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanTitle _title;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanLeagueBaseInfoView _leagueBaseInfo;

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TitleIconValueBackground _membersCount;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _requestButton;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _withdrawButton;

		// Token: 0x02000A05 RID: 2565
		[Token(Token = "0x2000A05")]
		public enum State
		{
			// Token: 0x040021DD RID: 8669
			[Token(Token = "0x40021DD")]
			UNKNOWN_STATE,
			// Token: 0x040021DE RID: 8670
			[Token(Token = "0x40021DE")]
			IDLE,
			// Token: 0x040021DF RID: 8671
			[Token(Token = "0x40021DF")]
			REQUESTED_CLAN
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WithdrawButton ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClanVacancyInfoBox__get_WithdrawButton
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param1_01;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57f0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a57f0f = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0x1c);
		  Gameplay_Clans_Office_View_ClanTitle__get_Text
		            (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar3 + 0x18),0);
		  Gameplay_Clans_Office_View_ClanLeagueBaseInfoView__Awake
		            (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x1c),param5,0);
		  piVar2 = *(int **)(param1 + 0x24);
		  local_4 = Core_Extensions_ClanInfoExt__GetHonorRating(iVar3,0);
		  uVar1 = func_ii_4443(&local_4,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))(piVar2,uVar1,*(undefined4 *)(iVar3 + 0xec));
		  uVar1 = Gameplay_World_Model_ClanData__GetClanCultIconAssetId
		                    (*(undefined4 *)(param2 + 0x1c),*(undefined4 *)(*(int *)(param2 + 0x24) + 0x18),
		                     param3,0);
		  param1_01 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (param1_00,param4,param4,uVar1,0);
		  UI_Requirements_RequirementsView__get_Data(param1_01,param1_00,0);
		  return;
		}
		*/

}
