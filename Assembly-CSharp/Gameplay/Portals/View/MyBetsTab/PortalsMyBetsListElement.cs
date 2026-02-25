using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Portal;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.MyBetsTab
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	public class PortalsMyBetsListElement : MonoBehaviour
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000699")]
		public Action<ulong> ClickAction
		{
			[Token(Token = "0x6002373")]
			[Address(RVA = "0x74C6", Offset = "0x74C6", VA = "0x74C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x74C7", Offset = "0x74C7", VA = "0x74C7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x74C8", Offset = "0x74C8", VA = "0x74C8")]
		private void Start()
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x74C9", Offset = "0x74C9", VA = "0x74C9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x1C95", Offset = "0x1C95", VA = "0x1C95")]
		public void Init(BetHistoryRow myBet, Action<ulong> argsClickAction)
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x74CA", Offset = "0x74CA", VA = "0x74CA")]
		private Sprite GetChoiceSprite(Bet.Types.State state)
		{
			return null;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x74CB", Offset = "0x74CB", VA = "0x74CB")]
		private string GetChoiceText(Bet.Types.State state)
		{
			return null;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x74CC", Offset = "0x74CC", VA = "0x74CC")]
		private void OnClick()
		{
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x74CD", Offset = "0x74CD", VA = "0x74CD")]
		public PortalsMyBetsListElement()
		{
		}

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _id;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _date;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _choice;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _reward;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _background;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _wait;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _win;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _lose;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x38")]
		private ulong _betId;
	}
}
