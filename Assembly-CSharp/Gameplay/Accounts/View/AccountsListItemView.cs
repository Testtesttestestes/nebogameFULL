using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC8 RID: 3528
	[Token(Token = "0x2000DC8")]
	public class AccountsListItemView : MonoBehaviourWithStates<AccountsListItemView.States>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000203 RID: 515
		// (add) Token: 0x0600560B RID: 22027 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600560C RID: 22028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000203")]
		public event Action<IAccountDataDecorator> SelectEvent
		{
			[Token(Token = "0x600560B")]
			[Address(RVA = "0xA3AB", Offset = "0xA3AB", VA = "0xA3AB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600560C")]
			[Address(RVA = "0xA3AC", Offset = "0xA3AC", VA = "0xA3AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560D")]
		[Address(RVA = "0xA3AD", Offset = "0xA3AD", VA = "0xA3AD")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560E")]
		[Address(RVA = "0xA3AE", Offset = "0xA3AE", VA = "0xA3AE")]
		private void Awake()
		{
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005610 RID: 22032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700117D")]
		public IAccountDataDecorator Data
		{
			[Token(Token = "0x600560F")]
			[Address(RVA = "0xA3AF", Offset = "0xA3AF", VA = "0xA3AF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005610")]
			[Address(RVA = "0xA3B0", Offset = "0xA3B0", VA = "0xA3B0")]
			set
			{
			}
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x1D32", Offset = "0x1D32", VA = "0x1D32")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005612")]
		[Address(RVA = "0xA3B1", Offset = "0xA3B1", VA = "0xA3B1")]
		private void HandleButtonClick()
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005613")]
		[Address(RVA = "0xA3B2", Offset = "0xA3B2", VA = "0xA3B2")]
		private string BacktimeformatCallback(float value)
		{
			return null;
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005614")]
		[Address(RVA = "0xA3B3", Offset = "0xA3B3", VA = "0xA3B3")]
		public void NotifyDataUpdated()
		{
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005615")]
		[Address(RVA = "0xA3B4", Offset = "0xA3B4", VA = "0xA3B4", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005616")]
		[Address(RVA = "0xA3B5", Offset = "0xA3B5", VA = "0xA3B5")]
		public AccountsListItemView()
		{
		}

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _saleRibbon;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button[] _buttons;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x34")]
		private IAccountDataDecorator _data;

		// Token: 0x02000DC9 RID: 3529
		[Token(Token = "0x2000DC9")]
		public enum States
		{
			// Token: 0x04002EAD RID: 11949
			[Token(Token = "0x4002EAD")]
			UNKNOWN,
			// Token: 0x04002EAE RID: 11950
			[Token(Token = "0x4002EAE")]
			ACTIVE,
			// Token: 0x04002EAF RID: 11951
			[Token(Token = "0x4002EAF")]
			NOT_ACTIVE
		}
	}
}
