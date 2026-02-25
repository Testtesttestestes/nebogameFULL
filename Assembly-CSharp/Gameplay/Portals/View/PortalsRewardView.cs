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
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x744F", Offset = "0x744F", VA = "0x744F")]
		public void SetIcon(string iconAsset)
		{
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
