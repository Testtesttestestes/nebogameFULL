using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	public class SpellsAndCultDescriptionPanel : MonoBehaviourWithStates<SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState>
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x72A3", Offset = "0x72A3", VA = "0x72A3")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x72A4", Offset = "0x72A4", VA = "0x72A4")]
		private void Start()
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x72A5", Offset = "0x72A5", VA = "0x72A5")]
		private void HandleOpenBtnClickEvent()
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x72A6", Offset = "0x72A6", VA = "0x72A6")]
		private void HandleCloseBtnClickEvent()
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x72A7", Offset = "0x72A7", VA = "0x72A7")]
		public SpellsAndCultDescriptionPanel()
		{
		}

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _openBtn;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		public enum SpellsAndCultDescriptionPanelState
		{
			// Token: 0x0400122C RID: 4652
			[Token(Token = "0x400122C")]
			Unknown,
			// Token: 0x0400122D RID: 4653
			[Token(Token = "0x400122D")]
			Open,
			// Token: 0x0400122E RID: 4654
			[Token(Token = "0x400122E")]
			Close
		}
	}
}
