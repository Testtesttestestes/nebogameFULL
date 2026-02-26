using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.ToolTip.Implementations;
using UnityEngine;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	public class PortalsRewardView : MonoBehaviourWithStates<PortalsRewardView.RewardState>
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x744B", Offset = "0x744B", VA = "0x744B")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Portals_View_PortalsRewardView__Start
		               (int param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  uint local_8;
		  uint local_4;
		  
		  if (DAT_ram_00a580e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a580e5 = '\x01';
		  }
		  UI_Elements_ProgressBars_ProgressBar__set_Value
		            (*(undefined4 *)(param1 + 0x24),(float)param2,(float)param3,0);
		  piVar2 = *(int **)(param1 + 0x24);
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  local_8 = param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar1,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x744C", Offset = "0x744C", VA = "0x744C")]
		public void SetProgress(uint current, uint total)
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x744D", Offset = "0x744D", VA = "0x744D")]
		public void SetRewardCount(string value)
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x744E", Offset = "0x744E", VA = "0x744E")]
		public void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_Portals_View_PortalsRewardView__SetTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x28),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x744F", Offset = "0x744F", VA = "0x744F")]
		public void SetIcon(string iconAsset)
		{
		/* --- GHIDRA: SetIcon ---
		void Gameplay_Portals_View_PortalsRewardView__SetIcon(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState___ctor__);
		    DAT_ram_00a580e6 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_PortalsRewardView_RewardState___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x7450", Offset = "0x7450", VA = "0x7450")]
		public PortalsRewardView()
		{
		}

		// Token: 0x0400130C RID: 4876
		[Token(Token = "0x400130C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _winTitle;

		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _rewardCount;

		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBarWithText _winBar;

		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextToolTip _progressToolTip;

		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextToolTip _rewardToolTip;

		// Token: 0x020005B2 RID: 1458
		[Token(Token = "0x20005B2")]
		public enum RewardState
		{
			// Token: 0x04001313 RID: 4883
			[Token(Token = "0x4001313")]
			UNKNOWN_STATE,
			// Token: 0x04001314 RID: 4884
			[Token(Token = "0x4001314")]
			STAGE,
			// Token: 0x04001315 RID: 4885
			[Token(Token = "0x4001315")]
			STAGE_WIN,
			// Token: 0x04001316 RID: 4886
			[Token(Token = "0x4001316")]
			STAGE_LOSE,
			// Token: 0x04001317 RID: 4887
			[Token(Token = "0x4001317")]
			STAGE_REWARD,
			// Token: 0x04001318 RID: 4888
			[Token(Token = "0x4001318")]
			BOSS
		}
	}
}
