using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.ToolTip.Implementations;
using UnityEngine;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	public class StageProgressView : MonoBehaviourWithStates<StageProgressView.State>
	{
		// Token: 0x06002322 RID: 8994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x7476", Offset = "0x7476", VA = "0x7476")]
		public void SetIcon(string iconAsset)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x7477", Offset = "0x7477", VA = "0x7477")]
		public void SetStageTitle(string value)
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x7478", Offset = "0x7478", VA = "0x7478")]
		public void SetStageWaitTitle(string value)
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x7479", Offset = "0x7479", VA = "0x7479")]
		public void SetToolTip(string value)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x747A", Offset = "0x747A", VA = "0x747A")]
		public void SetProgress(ulong current, ulong total)
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x747B", Offset = "0x747B", VA = "0x747B")]
		public StageProgressView()
		{
		}

		// Token: 0x0400133F RID: 4927
		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _stageTitle;

		// Token: 0x04001340 RID: 4928
		[Token(Token = "0x4001340")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _stageWaitTitle;

		// Token: 0x04001341 RID: 4929
		[Token(Token = "0x4001341")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBarWithText _stageProgress;

		// Token: 0x04001342 RID: 4930
		[Token(Token = "0x4001342")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImageLoader _icon;

		// Token: 0x04001343 RID: 4931
		[Token(Token = "0x4001343")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextToolTip _currencyToolTip;

		// Token: 0x020005B8 RID: 1464
		[Token(Token = "0x20005B8")]
		public enum State
		{
			// Token: 0x04001345 RID: 4933
			[Token(Token = "0x4001345")]
			UNKNOWN_STATE,
			// Token: 0x04001346 RID: 4934
			[Token(Token = "0x4001346")]
			STAGE,
			// Token: 0x04001347 RID: 4935
			[Token(Token = "0x4001347")]
			STAGE_WAIT
		}
	}
}
