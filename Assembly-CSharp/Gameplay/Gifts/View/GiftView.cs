using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Gifts.View
{
	// Token: 0x02000708 RID: 1800
	[Token(Token = "0x2000708")]
	public class GiftView : MonoBehaviour
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082F")]
		public SocialGiftDic GiftDic
		{
			[Token(Token = "0x6002B10")]
			[Address(RVA = "0x7BAB", Offset = "0x7BAB", VA = "0x7BAB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B11")]
			[Address(RVA = "0x7BAC", Offset = "0x7BAC", VA = "0x7BAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x7BAD", Offset = "0x7BAD", VA = "0x7BAD")]
		private void Awake()
		{
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x7BAE", Offset = "0x7BAE", VA = "0x7BAE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x7BAF", Offset = "0x7BAF", VA = "0x7BAF")]
		public void SetGiftDic(SocialGiftDic dic, UserData userData)
		{
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x7BB0", Offset = "0x7BB0", VA = "0x7BB0")]
		public void Init(UserData userData, SocialGiftDic dic)
		{
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x7BB1", Offset = "0x7BB1", VA = "0x7BB1")]
		public void SetButtonActive(bool enable)
		{
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x7BB2", Offset = "0x7BB2", VA = "0x7BB2")]
		private void HandleSendGiftEvent()
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x7BB3", Offset = "0x7BB3", VA = "0x7BB3")]
		private void HandleInfoButtonClickEvent()
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x7BB4", Offset = "0x7BB4", VA = "0x7BB4")]
		public GiftView()
		{
		}

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x24")]
		public Action<GiftView> OnSendGiftEvent;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x28")]
		public Action<GiftView> OnOpenGiftInfoEvent;
	}
}
