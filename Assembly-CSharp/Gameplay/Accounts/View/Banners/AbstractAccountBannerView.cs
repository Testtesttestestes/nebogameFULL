using System;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD0 RID: 3536
	[Token(Token = "0x2000DD0")]
	public abstract class AbstractAccountBannerView<T> : MonoBehaviourWithStates<AccountsListItemView.States>, IDisposable where T : class, IAccountDataDecorator, new()
	{
		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06005636 RID: 22070
		[Token(Token = "0x17001188")]
		public abstract uint AccountId { [Token(Token = "0x6005636")] get; }

		// Token: 0x06005637 RID: 22071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005637")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005638")]
		private void Awake()
		{
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005639")]
		private void Start()
		{
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563A")]
		private void AccountChangedEvent(IAccountDataDecorator obj)
		{
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563B")]
		public void Dispose()
		{
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600563D RID: 22077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001189")]
		public T Data
		{
			[Token(Token = "0x600563C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600563D")]
			set
			{
			}
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563E")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600563F")]
		private void HandleButtonClickEvent()
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005640")]
		protected virtual void SetTitle(T data)
		{
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005641")]
		protected virtual void SetDescription(T data)
		{
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005642")]
		protected virtual void SetImage(T data)
		{
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005643")]
		protected virtual void SetBacktime(T data)
		{
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005644")]
		protected virtual string FormatBacktimeCallback(float value)
		{
			return null;
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005645")]
		protected AbstractAccountBannerView()
		{
		}

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _description;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameRawImage _image;

		// Token: 0x04002ECB RID: 11979
		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected BacktimeViewUGUI _backtimeView;

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Button[] _buttons;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x0")]
		public AccountDic.Types.ContentResource BackroundContentResource;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x0")]
		private AccountsEvents AccountsEvents;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x0")]
		private T _data;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		public const string ACCOUNT_ACTIVE_BACKTIME = "ACCOUNT/ACTIVE_BACKTIME";
	}
}
