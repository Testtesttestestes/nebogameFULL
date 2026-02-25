using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	public class ChatBanItemRenderer : MonoBehaviourWithStates<ChatBanItemRenderer.ChatBanItemRendererStates>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140001AD RID: 429
		// (add) Token: 0x060043FA RID: 17402 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043FB RID: 17403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AD")]
		public event EventHandler<ChatBanArticleData> ClickEvent
		{
			[Token(Token = "0x60043FA")]
			[Address(RVA = "0x92AD", Offset = "0x92AD", VA = "0x92AD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x92AE", Offset = "0x92AE", VA = "0x92AE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043FD RID: 17405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D62")]
		public ChatBanArticleData Data
		{
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x92AF", Offset = "0x92AF", VA = "0x92AF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043FD")]
			[Address(RVA = "0x92B0", Offset = "0x92B0", VA = "0x92B0")]
			set
			{
			}
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x92B1", Offset = "0x92B1", VA = "0x92B1")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x92B2", Offset = "0x92B2", VA = "0x92B2", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004400")]
		[Address(RVA = "0x92B3", Offset = "0x92B3", VA = "0x92B3")]
		public void DataUpdated()
		{
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004401")]
		[Address(RVA = "0x92B4", Offset = "0x92B4", VA = "0x92B4")]
		public ChatBanItemRenderer()
		{
		}

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _titleTextFaild;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x24")]
		private ChatBanArticleData _data;

		// Token: 0x02000B00 RID: 2816
		[Token(Token = "0x2000B00")]
		public enum ChatBanItemRendererStates
		{
			// Token: 0x04002576 RID: 9590
			[Token(Token = "0x4002576")]
			UNKNOWN,
			// Token: 0x04002577 RID: 9591
			[Token(Token = "0x4002577")]
			DEFAULT,
			// Token: 0x04002578 RID: 9592
			[Token(Token = "0x4002578")]
			SELECTED
		}
	}
}
