using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCD RID: 3533
	[Token(Token = "0x2000DCD")]
	public class OptionBuyButtonItem : MonoBehaviour
	{
		// Token: 0x14000205 RID: 517
		// (add) Token: 0x06005627 RID: 22055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005628 RID: 22056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000205")]
		public event Action<OptionBuyButtonItem> ClickEvent
		{
			[Token(Token = "0x6005627")]
			[Address(RVA = "0xA3C5", Offset = "0xA3C5", VA = "0xA3C5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005628")]
			[Address(RVA = "0xA3C6", Offset = "0xA3C6", VA = "0xA3C6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001183")]
		public TextMeshProUGUI OptionName
		{
			[Token(Token = "0x6005629")]
			[Address(RVA = "0xA3C7", Offset = "0xA3C7", VA = "0xA3C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001184")]
		public TextMeshProUGUI ButtonLabel
		{
			[Token(Token = "0x600562A")]
			[Address(RVA = "0xA3C8", Offset = "0xA3C8", VA = "0xA3C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001185")]
		public TextMeshProUGUI SaleLabel
		{
			[Token(Token = "0x600562B")]
			[Address(RVA = "0xA3C9", Offset = "0xA3C9", VA = "0xA3C9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001186")]
		public VipPointsView VipPointsView
		{
			[Token(Token = "0x600562C")]
			[Address(RVA = "0xA3CA", Offset = "0xA3CA", VA = "0xA3CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562D")]
		[Address(RVA = "0xA3CB", Offset = "0xA3CB", VA = "0xA3CB")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562E")]
		[Address(RVA = "0xA3CC", Offset = "0xA3CC", VA = "0xA3CC")]
		private void Start()
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562F")]
		[Address(RVA = "0xA3CD", Offset = "0xA3CD", VA = "0xA3CD")]
		private void HandleBtnClickEvent()
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005630")]
		[Address(RVA = "0xA3CE", Offset = "0xA3CE", VA = "0xA3CE")]
		public OptionBuyButtonItem()
		{
		}

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _optionName;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _buttonLabel;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _saleLabel;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VipPointsView _vipPointsView;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x28")]
		public AccountOptionData OptionData;
	}
}
