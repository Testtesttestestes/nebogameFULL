using System;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.View.Accounts
{
	// Token: 0x02000DD5 RID: 3541
	[Token(Token = "0x2000DD5")]
	public abstract class AbstractAccountView : MonoBehaviourWithStates<AccountViewStates>, IDisposable
	{
		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700118D")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6005650")]
			[Address(RVA = "0xA3DE", Offset = "0xA3DE", VA = "0xA3DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700118E")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6005651")]
			[Address(RVA = "0xA3DF", Offset = "0xA3DF", VA = "0xA3DF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700118F")]
		public TextMeshProUGUI ClarificationDescription
		{
			[Token(Token = "0x6005652")]
			[Address(RVA = "0xA3E0", Offset = "0xA3E0", VA = "0xA3E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005653")]
		[Address(RVA = "0xA3E1", Offset = "0xA3E1", VA = "0xA3E1")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005654")]
		[Address(RVA = "0xA3E2", Offset = "0xA3E2", VA = "0xA3E2", Slot = "6")]
		public virtual void Dispose()
		{
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005656 RID: 22102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001190")]
		public IAccountDataDecorator Data
		{
			[Token(Token = "0x6005655")]
			[Address(RVA = "0xA3E3", Offset = "0xA3E3", VA = "0xA3E3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005656")]
			[Address(RVA = "0xA3E4", Offset = "0xA3E4", VA = "0xA3E4")]
			private set
			{
			}
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005657")]
		[Address(RVA = "0xA3E5", Offset = "0xA3E5", VA = "0xA3E5", Slot = "7")]
		public virtual void Init(AccountsController controller, IAccountDataDecorator data)
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005658")]
		[Address(RVA = "0xA3E6", Offset = "0xA3E6", VA = "0xA3E6")]
		public void NotifyDataUpdated()
		{
		}

		// Token: 0x06005659 RID: 22105
		[Token(Token = "0x6005659")]
		protected abstract void HandleDataChanged();

		// Token: 0x0600565A RID: 22106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565A")]
		[Address(RVA = "0xA3E7", Offset = "0xA3E7", VA = "0xA3E7")]
		protected AbstractAccountView()
		{
		}

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _clarificationDescription;

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x28")]
		private IAccountDataDecorator _data;
	}
}
