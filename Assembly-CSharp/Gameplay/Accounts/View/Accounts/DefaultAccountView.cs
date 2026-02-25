using System;
using AssetContent;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.View.Accounts
{
	// Token: 0x02000DD7 RID: 3543
	[Token(Token = "0x2000DD7")]
	public class DefaultAccountView : AbstractAccountView
	{
		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001191")]
		public TextMeshProUGUI ActionTitle
		{
			[Token(Token = "0x600565B")]
			[Address(RVA = "0xA3E8", Offset = "0xA3E8", VA = "0xA3E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001192")]
		public Transform ActiveBlock
		{
			[Token(Token = "0x600565C")]
			[Address(RVA = "0xA3E9", Offset = "0xA3E9", VA = "0xA3E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001193")]
		public BacktimeViewUGUI ActiveBacktime
		{
			[Token(Token = "0x600565D")]
			[Address(RVA = "0xA3EA", Offset = "0xA3EA", VA = "0xA3EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600565E RID: 22110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001194")]
		public GameRawImage Image
		{
			[Token(Token = "0x600565E")]
			[Address(RVA = "0xA3EB", Offset = "0xA3EB", VA = "0xA3EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001195")]
		public OptionBuyButtonItem OptionViewPrefab
		{
			[Token(Token = "0x600565F")]
			[Address(RVA = "0xA3EC", Offset = "0xA3EC", VA = "0xA3EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001196")]
		public Transform OptionsContainer
		{
			[Token(Token = "0x6005660")]
			[Address(RVA = "0xA3ED", Offset = "0xA3ED", VA = "0xA3ED")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001197")]
		public GameRawImage SaleRibbon
		{
			[Token(Token = "0x6005661")]
			[Address(RVA = "0xA3EE", Offset = "0xA3EE", VA = "0xA3EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005662")]
		[Address(RVA = "0xA3EF", Offset = "0xA3EF", VA = "0xA3EF", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005663")]
		[Address(RVA = "0xA3F0", Offset = "0xA3F0", VA = "0xA3F0", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005664")]
		[Address(RVA = "0xA3F1", Offset = "0xA3F1", VA = "0xA3F1", Slot = "7")]
		public override void Init(AccountsController controller, IAccountDataDecorator data)
		{
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005665")]
		[Address(RVA = "0xA3F2", Offset = "0xA3F2", VA = "0xA3F2")]
		public DefaultAccountView()
		{
		}

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Transform _activeBlock;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected BacktimeViewUGUI _activeBacktime;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected TextMeshProUGUI _actionTitle;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameRawImage _image;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected OptionBuyButtonItem _optionViewPrefab;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform _optionsContainer;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected GameRawImage _saleRibbon;

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x48")]
		private AccountViewMediator _mediator;
	}
}
