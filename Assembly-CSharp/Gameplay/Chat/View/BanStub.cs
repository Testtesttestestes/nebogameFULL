using System;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x2000AE7")]
	public class BanStub : MonoBehaviour
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x91F4", Offset = "0x91F4", VA = "0x91F4")]
		private void Start()
		{
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004342 RID: 17218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D40")]
		public ChatBanData BanData
		{
			[Token(Token = "0x6004341")]
			[Address(RVA = "0x91F5", Offset = "0x91F5", VA = "0x91F5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004342")]
			[Address(RVA = "0x91F6", Offset = "0x91F6", VA = "0x91F6")]
			set
			{
			}
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x91F7", Offset = "0x91F7", VA = "0x91F7")]
		private void HandleBanDataChanged()
		{
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x91F8", Offset = "0x91F8", VA = "0x91F8")]
		public BanStub()
		{
		}

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _titleField;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x18")]
		private ChatBanData _banData;
	}
}
