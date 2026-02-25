using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFC RID: 3580
	[Token(Token = "0x2000DFC")]
	public class ConfirmSelectedUserView : MonoBehaviour
	{
		// Token: 0x14000208 RID: 520
		// (add) Token: 0x06005754 RID: 22356 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005755 RID: 22357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000208")]
		public event Action<LinkerUser> OnSelectEvent
		{
			[Token(Token = "0x6005754")]
			[Address(RVA = "0xA4CF", Offset = "0xA4CF", VA = "0xA4CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005755")]
			[Address(RVA = "0xA4D0", Offset = "0xA4D0", VA = "0xA4D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005756")]
		[Address(RVA = "0xA4D1", Offset = "0xA4D1", VA = "0xA4D1")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005757")]
		[Address(RVA = "0xA4D2", Offset = "0xA4D2", VA = "0xA4D2")]
		private void Awake()
		{
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005758")]
		[Address(RVA = "0xA4D3", Offset = "0xA4D3", VA = "0xA4D3")]
		private void UserViewOnSelectEvent(object sender, LinkerUser user)
		{
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CF")]
		public AccountLinkerUserView UserView
		{
			[Token(Token = "0x6005759")]
			[Address(RVA = "0xA4D4", Offset = "0xA4D4", VA = "0xA4D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575A")]
		[Address(RVA = "0xA4D5", Offset = "0xA4D5", VA = "0xA4D5")]
		public ConfirmSelectedUserView()
		{
		}

		// Token: 0x04002F51 RID: 12113
		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountLinkerUserView _userView;
	}
}
